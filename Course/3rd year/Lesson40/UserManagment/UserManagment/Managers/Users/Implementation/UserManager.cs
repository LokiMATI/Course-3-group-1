using UserManagment.Managers.Users.Interface;
using UserManagment.Models.Interface;

namespace UserManagment.Models.Managers.Implementation;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User GetUser(int userId)
    {
        return _userRepository.Get(userId);
    }

    public IEnumerable<User> GetAllUser()
    {
        return _userRepository.GetAll();
    }

    public void AddUser(string username, string email)
    {
        var user  = new User { Username = username, Email = email };
        _userRepository.Add(user);
    }

    public void DeleteUser(int userId)
    {
        _userRepository.Delete(userId);
    }
}
