
namespace BO;

public class ProductInOrder
{
    public int IdProduct { get; init; }
    public string NameProduct { get; set; }
    public double BasicPriceProduct { get; set; }    
    public int AmountInOrder { get; set;}         
    public List<BO.SaleInProduct> SalesList { get; set; }
    public double FinallPriceProduct { get; set; }

    public ProductInOrder()
    {
        SalesList = new List<SaleInProduct>();
    }
}
