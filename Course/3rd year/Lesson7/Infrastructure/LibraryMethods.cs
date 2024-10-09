using Library.Cases;
using Core;

namespace Library.Infrastructure;

public class LibraryMethods {
    private BookCase _BookCase = new BookCase();
    private UserCase _UserCase = new UserCase();

    // Methods Book
    public void AddBook(string Name, string Author, string Date, string Text){
        List<Book> Books = _BookCase.GetBooks();
        if (Books.Count != 0)
        {
            ulong MaxID = Books.Max(x => x.ID);
            _BookCase.AddBook(new Book(MaxID + 1, Name, Author, Date, Text));
        }
        else
        {
            _BookCase.AddBook(new Book(1, Name, Author, Date, Text));
        }
        }
    public string DeleteBook(string bookName) => _BookCase.DeleteBook(bookName);
    public List<Book> GetBooks() => _BookCase.GetBooks();
    public Book GetBookByID(ulong ID){
        foreach (var _Book in _BookCase.GetBooks())
        {
            if (_Book.ID == ID)
            {
                return _Book;
            }
        }
        return null;
    }
    public Book GetBookByName(string Name){
        foreach (var _Book in _BookCase.GetBooks())
        {
            if (_Book.Name == Name)
            {
                return _Book;
            }
        }
        return null;
    }

    public string EditBookName(string OldName, string NewName){
        foreach (var _Book1 in _BookCase.GetBooks()){
            if (_Book1.Name == OldName)
            {
                _Book1.Name = NewName;
            return "The book was edited.";
            }
        }
        return "The book was not found.";
    }

    public string EditBookText(string Name, string NewText)
    {
        foreach (var _Book1 in _BookCase.GetBooks())
        {
            if (_Book1.Name == Name)
            {
                _Book1.Text = NewText;
                return "The book was edited.";
            }
        }
        return "The book was not found.";
    }

    // Methods User
    public void AddUser(string Name, string Password){
        List<User> Users = _UserCase.GetUsers();
        if (Users.Count != 0) {
            ulong MaxID = Users.Max(x => x.ID);
            _UserCase.AddUser(new User(MaxID + 1, Name, Password));
        }
        else
        {
            _UserCase.AddUser(new User(1, Name, Password));
        }
    }
    public string DeleteUser(ulong ID) => _UserCase.DeleteUser(ID);
    public List<User> GetUsers() => _UserCase.GetUsers();
    public User GetUserByID(ulong ID){
        foreach (var _User in _UserCase.GetUsers())
        {
            if (_User.ID == ID)
            {
                return _User;
            }
        }
        return null;
    }
    //public string AddFavorite(ulong UserID, string BookName){
    //    foreach (var Book in _BookCase.GetBooks()){
    //        if (Book.Name == BookName){
    //            foreach (var User in _UserCase.GetUsers()){
    //                if (User.ID == UserID){
    //                    User.BooksID.Add(Book.ID);
    //                    return "The book was added to the favorites.";
    //                }
    //            }
    //            return "The user was not found.";
    //        }
    //    }
    //    return "The book was not found.";
    //}
}