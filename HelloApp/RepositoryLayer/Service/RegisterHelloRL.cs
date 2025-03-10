using ModelLayer.DTO;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
      
        private string databaseUsername = "root";
        private string databasePassword = "root";

        public string GetHello(string name)
        {
            return name + " Hello from Repository layer ";
        }

        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            loginDTO.username = databaseUsername;
            loginDTO.password = databasePassword;

            return loginDTO;

        }


    }
}
