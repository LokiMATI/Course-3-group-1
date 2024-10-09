using Core;

namespace Library.Cases;

public class BookCase
{
	private List<Book> Books = new List<Book> { };

	// Methods
	public void AddBook(Book _Book)
	{
		Books.Add(_Book);
	}

	public string DeleteBook(string bookName)
	{
		foreach (var _Book in Books)
		{
			if (_Book.Name == bookName)
			{
				Books.Remove(_Book);
				return "The book was deleted from the library.";
			}
		}
		return "The book was not found";
	}
	public List<Book> GetBooks()
	{
		return Books;
	}
}