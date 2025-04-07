
namespace DO;
/// <summary>
/// 
/// </summary>
/// מחלקת מוצר  
/// <param name="IdProduct">מזהה מוצר רץ</param>
/// <param name="NameProduct">שם מוצר</param>
/// <param name="Category">קטגוריה</param>
/// <param name="Price">מחיר</param>
/// <param name="StockAmount">כמות במלאי</param>
public record Product
    (int IdProduct,
    string NameProduct,
    Categories Category,
    double Price,
    int StockAmount)
{
    public Product(string value) :this(-1,"",Categories.מטבח , 0,0)
    {}

}
