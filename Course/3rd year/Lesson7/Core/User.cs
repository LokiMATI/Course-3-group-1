namespace Core;

public class User
{
    public ulong ID { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    //public List<ulong>? BooksID { get; set; }

    public User(ulong _ID, string _Name, string _Password)
    {
        this.ID = _ID;
        this.Name = _Name;
        this.Password = _Password;
        //this.BooksID = _BooksID;
    }
}