
using System.Reflection;
using System.Text;

namespace BO;

public static class Tools
{
    public static DO.Customer ConvertToDoCustomer(this BO.Customer c)
    {
        return new DO.Customer (c.IdentityCard,c.NameCustomer,c.Address,c.Phone);
    }

    public static DO.Product ConvertToDoProduct(this BO.Product p)
    {
        return new DO.Product(p.IdProduct, p.NameProduct, (DO.Categories)p.Category, p.Price, p.StockAmount);
    }

    public static DO.Sale ConvertToDoSale(this BO.Sale s)
    {
        return new DO.Sale(s.Id,s.IdProduct,s.AmountForSale,s.IncludingPriceInSale,s.IsTheSaleForEverybody,s.DateBeginSale,s.DateEndSale);
    }


    public static BO.Customer ConvertToBoCustomer(this DO.Customer c)
    {
        return new BO.Customer(c.IdentityCard, c.NameCustomer, c.Address, c.Phone);
    }

    public static BO.Product ConvertToBoProduct(this DO.Product p)
    {
        return new BO.Product(p.IdProduct,p.NameProduct,(BO.Categories)p.Category,p.Price,p.StockAmount);
    }

    public static BO.Sale ConvertToBoSale(this DO.Sale s)
    {
        return new BO.Sale(s.Id,s.IdProduct,s.AmountForSale,s.IncludingPriceInSale,s.IsTheSaleForEverybody,s.DateBeginSale,s.DateEndSale);
    }

    public static string ToStringProperty<T>(this T obj)
    {
        StringBuilder str = new StringBuilder();
        foreach (var item in obj.GetType().GetRuntimeProperties())
        {
            str.AppendLine($"{item.Name} - {item.GetValue(obj)}  ");
        }

        return str.ToString();
    }
}
