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
            Console.WriteLine("5. Выйти");
            Console.Write("Введите ваш выбор: ");
            switch (ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Введите название книги: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Введите автора книги: ");
                    string bookAuthor = Console.ReadLine();
                    Console.Write("Введите год издания книги: ");
                    int bookYear = ToInt32(Console.ReadLine());
                    Console.Write("Введите текст книги:");
                    string bookText = Console.ReadLine();
                    _LibraryMethods.AddBook(bookName, bookAuthor, bookYear, bookText);
                    break;
                case 2:
                    Console.Write("Введите название книги: ");
                    bookName = Console.ReadLine();
                    Console.WriteLine(_LibraryMethods.DeleteBook(bookName));
                    break;
                case 3:
                    List<Book> books = _LibraryMethods.GetBooks();
                    foreach (var book in books)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Название книги: " + book.Name + "\nАвтор книги: " + book.Author + "\nГод издания книги: " + book.Year + "\nТекст книги: " + book.Text);
                    }
                    break;
                case 4:
                    Console.Write("Введите название книги: ");
                    bookName = Console.ReadLine();
                    _LibraryMethods.GetBookByName(bookName);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    break;
            }
        }
    }
}