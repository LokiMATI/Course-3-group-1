using UserManagment.Models.Interface;

namespace UserManagment.Models;

public class UserRepository : IUserRepository
{
    private List<User> users = new List<User>();
    
    public User Get(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }

    public IEnumerable<User> GetAll()
    {
        return users;
    }

    public void Add(User user)
    {
        users.Add(user);
    }

    public void Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        
        if (user != null)
            users.Remove(user);
    }
}