
namespace BO;

    public class Product
    {
    public int IdProduct { get; init; }
    public string NameProduct { get; set; }
    public Categories? Category { get; set; }
    public double Price { get; set; }
    public int StockAmount { get; set; }
    public List<SaleInProduct>? ProductInSale { get; set; }

    public Product(int idProduct, string nameProduct, Categories? category, double price, int stockAmount)
    {
        IdProduct = idProduct;
        NameProduct = nameProduct;
        Category = category;
        Price = price;
        StockAmount = stockAmount;
        ProductInSale = new List<SaleInProduct>();
    }
}


