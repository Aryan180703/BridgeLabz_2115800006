using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        IRegisterHelloRL _registerHelloRL;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }

        public string registration(string str)
        {
            return "";
        }
        public ResponseRegisterDTO RegistrationBL(RegisterDTO registerDTO)
        {
            var result=_registerHelloRL.RegistrationRL(registerDTO);

            ResponseRegisterDTO responseRegisterDTO = new ResponseRegisterDTO();
            if (result == null)
            {
                return null;
            }
            responseRegisterDTO.FirstName = result.FirstName;
            responseRegisterDTO.LastName = result.LastName;
            responseRegisterDTO.Email = result.Email;

            return responseRegisterDTO;
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            string frontendUsername = loginDTO.username;
            string frontendPassword = loginDTO.password;

            LoginDTO result = _registerHelloRL.getUsernamePassword(loginDTO);

            bool res = checkUsernamePassword(frontendUsername, frontendPassword, result);

            return res;
        }

        public List<ResponseRegisterDTO> GetAllUsersBL()
        {
            var result = _registerHelloRL.GetAllUsersRL();
            return result;
        }

        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {

            if (frontendUsername.Equals(result.username) && frontendPassword.Equals(result.password))
            {
                return true;
            }
            return false;
        }
    }
}
