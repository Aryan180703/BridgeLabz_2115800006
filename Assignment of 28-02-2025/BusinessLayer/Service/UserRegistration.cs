using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistration
    {
        UserRepository _userRegistrationRL;
        public UserRegistration(UserRepository userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool UserRegistrationBL(RegisterUserDTO registerUserDTO)
        {
            return _userRegistrationRL.RegisterUserRL(registerUserDTO) != null;
        }
    }
}
