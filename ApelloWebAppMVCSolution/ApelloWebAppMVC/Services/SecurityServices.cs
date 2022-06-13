using ApelloWebAppMVC.Models;

namespace ApelloWebAppMVC.Services
{
    public class SecurityServices
    {
        UsersDAO usersDAO = new UsersDAO();

        public SecurityServices()
        {
           
        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassowrd(user);
        }
    }
}
