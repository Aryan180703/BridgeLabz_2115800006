using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class RegisterDTO
    {
        public int userId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
        public string password { get; set; }

    }
}
