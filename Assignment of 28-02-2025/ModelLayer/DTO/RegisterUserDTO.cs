using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class RegisterUserDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        override

            public string ToString()
        {
            return $"FirstName: {firstName} LastName: {lastName} Email: {email} Password: {password}";
        }
        
    }
}
