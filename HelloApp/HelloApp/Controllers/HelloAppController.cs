using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using BusinessLayer.Interface;
using ModelLayer.DTO;

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
                    //return loginDTO.ToString();
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

    }
}
