using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL:IRegisterHelloRL
    {
        private string databaseUsername = "root";
        private string databasePassword = "root";

        private readonly HelloAppContext _context;

        public RegisterHelloRL(HelloAppContext context)
        {
            _context = context;
        }

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
        public RegisterDTO Registration(RegisterDTO newUser)
        {
            var userEntity = new UserEntity
            {
                email = newUser.email,
                firstName = newUser.firstName,
                lastName = newUser.lastName,
                password = newUser.password
            };
            _context.Users.Add(userEntity);
            _context.SaveChanges();
            return newUser;

        }
    }
}
