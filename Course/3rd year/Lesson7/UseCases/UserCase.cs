using Core;

namespace Library.Cases;

public class UserCase
{
	private List<User> Users = new List<User> { };

	// Methods
	public void AddUser(User _User)
	{
		Users.Add(_User);
	}

	public string DeleteUser(ulong ID)
	{
		foreach (var _User in Users)
		{
			if (_User.ID == ID)
			{
                Users.Remove(_User);
				return "The user was deleted from the library.";
			}
		}
		return "The user was not found";
	}
	public List<User> GetUsers()
	{
		return Users;
	}
}