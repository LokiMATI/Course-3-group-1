namespace Lesson3Record;

public class Record
{
    public DateOnly Date { get; set; }
    public string Product { get; set; }
    public string Region { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Record(){}
    public Record(DateOnly Date_, string Product_, string Region_, int Quantity_, decimal Price_){
        this.Date = Date;
        this.Product = Product;
        this.Region = Region;
        this.Quantity = Quantity;
        this.Price = Price;
    
    }
}
