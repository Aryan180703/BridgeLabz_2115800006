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
    public class RegisterHelloBL:IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;

       public RegisterHelloBL(IRegisterHelloRL registerHelloRL) 
        {
            _registerHelloRL = registerHelloRL;
        }

        public string registration(string name)
        {
            return " Data from Business Layer "+ _registerHelloRL.GetHello(name);
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            string frontendUsername = loginDTO.username;
            string frontendPassword = loginDTO.password;

            LoginDTO result =_registerHelloRL.getUsernamePassword(loginDTO);

            bool res =checkUsernamePassword(frontendUsername, frontendPassword, result);

            return res;
        }

        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            
            if(frontendUsername.Equals(result.username) && frontendPassword.Equals(result.password)) 
            {
                return true;
            }
            return false;
        }
    }
}
