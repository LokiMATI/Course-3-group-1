namespace Core;

public class Book
{
	public ulong ID { get; set; }
	public string Name { get; set; }
	public string Author { get; set; }
	public string Date { get; set; }
	public string? Text { get; set; }
	public Book(ulong _ID, string _Name, string _Author, string _Date, string _Text = "")
	{
		this.ID = _ID;
		this.Name = _Name;
		this.Author = _Author;
		this.Date = _Date;
		this.Text = _Text;
	}
}