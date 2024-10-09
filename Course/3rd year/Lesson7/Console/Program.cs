using Library.Infrastructure;
using Core;

namespace Library;

public class Program
{
    public static void Main(string[] args)
    {
        LibraryMethods _LibraryMethods = new LibraryMethods();
        while (true)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Вывести список всех книг");
            Console.WriteLine("4. Вывести книгу по названию");
            Console.WriteLine("5. Добавить пользователя");
            Console.WriteLine("6. Удалить пользователя");
            Console.WriteLine("7. Вывести список пользователей");
            Console.WriteLine("8. Выйти");
            Console.Write("Введите ваш выбор: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Введите название книги: ");
                    string bookNewName = Console.ReadLine();
                    Console.Write("Введите автора книги: ");
                    string bookNewAuthor = Console.ReadLine();
                    Console.Write("Введите год издания книги: ");
                    string bookNewYear = (Console.ReadLine());
                    Console.Write("Введите текст книги:");
                    string bookNewText = Console.ReadLine();
                    _LibraryMethods.AddBook(bookNewName, bookNewAuthor, bookNewYear, bookNewText);
                    break;
                case 2:
                    Console.Write("Введите название книги: ");
                    string bookName = Console.ReadLine();
                    Console.WriteLine(_LibraryMethods.DeleteBook(bookName));
                    break;
                case 3:
                    List<Book> books = _LibraryMethods.GetBooks();
                    foreach (var book in books)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Название книги: " + book.Name + "\nАвтор книги: " + book.Author + "\nГод издания книги: " + book.Date + "\nТекст книги: " + book.Text);
                    }
                    Console.WriteLine("======================================");
                    break;
                case 4:
                    Console.Write("Введите название книги: ");
                    bookName = Console.ReadLine();
                    _LibraryMethods.GetBookByName(bookName);
                    break;
                case 8:
                    return;
                case 5:
                    Console.Write("Введите имя пользователя: ");
                    string userNewName = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string userNewPassword = Console.ReadLine();
                    _LibraryMethods.AddUser(userNewName, userNewPassword);
                    break;
                case 6:
                    Console.Write("Введите ID пользователя: ");
                    ulong ID = Convert.ToUInt64(Console.ReadLine());
                    Console.WriteLine(_LibraryMethods.DeleteUser(ID));
                    break;
                case 7:
                    List<User> users = _LibraryMethods.GetUsers();
                    foreach (var user in users)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("ID пользователя: " + user.ID + "\nИмя пользователя: " + user.Name);
                    }
                    Console.WriteLine("======================================");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    break;
            }
        }
    }
}