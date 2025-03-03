namespace UserManagment.Models.Interface;

public interface IUserRepository
{
    User Get(int id);
    IEnumerable<User> GetAll();
    void Add(User user);
    void Delete(int id);
}