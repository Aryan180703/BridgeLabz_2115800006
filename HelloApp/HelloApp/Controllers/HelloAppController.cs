using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        IRegisterHelloBL _registerHelloBL;
        ResponseModel<String> response;


        public HelloAppController(IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var result=_registerHelloBL.GetAllUsersBL();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public String Get()
        {
            return _registerHelloBL.registration(" value from controller ");
        }
        
        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                response = new ResponseModel<String>();

                bool result = _registerHelloBL.loginuser(loginDTO);
               
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Sucessfull";
                    response.Data = loginDTO.username;
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Login failed";
                response.Data = "";
                return NotFound();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Login failed";
                response.Data = ex.Message;
                return BadRequest();
            }
            

        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            try
            {
                return Ok(_registerHelloBL.RegistrationBL(registerDTO));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
