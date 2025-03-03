using UserManagment.Models;

namespace UserManagment.Managers.Users.Interface;

public interface IUserManager
{
    User GetUser(int userId);
    IEnumerable<User> GetAllUser();
    void AddUser(string username, string email);
    void DeleteUser(int userId);
}