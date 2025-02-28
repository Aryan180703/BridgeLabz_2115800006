using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

using BusinessLayer.Service;

namespace UserRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistration _userRegistration;
        ResponseDTO<RegisterUserDTO> responseDTO;

        public UserRegistrationController(UserRegistration userRegistration)
        {
            _userRegistration = userRegistration;
        }
        [HttpGet]
        public string Get()
        {
            return "Aryan";
        }


        [HttpPost]

        public IActionResult Post([FromBody] RegisterUserDTO registerUserDTO)
        {
            try
            {
                responseDTO = new ResponseDTO<RegisterUserDTO>();

                bool result = _userRegistration.UserRegistrationBL(registerUserDTO);

                    responseDTO.Success = true;
                    responseDTO.Message = result?"User Registered Successfully!": "User Can't Register , Already exists e-mail!";
                    responseDTO.Data = registerUserDTO;

                    return result ? Ok(responseDTO): NotFound(responseDTO); ;
                
            }
            catch (Exception ex)
            {
                responseDTO.Success = false;
                responseDTO.Message = ex.Message;
                responseDTO.Data = null!;

                return BadRequest(responseDTO);
            }

        }

    }
}
