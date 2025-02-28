using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Service
{
    public class UserRepository
    {
        private static List<RegisterUserDTO> store=new List<RegisterUserDTO> ();
        public UserRepository() { }

        public RegisterUserDTO RegisterUserRL(RegisterUserDTO registerUserDTO)
        {
            foreach(var v in store)
            {
                if(v.email == registerUserDTO.email) return null;
            }

            store.Add(registerUserDTO);

            return registerUserDTO;
        }
    }
}
