
namespace DalList;
using DO;
using DalApi;

public static class Initialization
{
    private static IDal s_dal;

    private static void createCustomers()
    {

        s_dal.Customer.Create(new Customer(327865431,"רותי","מודיעין_עילית","089790439"));
        s_dal.Customer.Create(new Customer(546865432, "חני", "בני_ברק", "089840439"));
        s_dal.Customer.Create(new Customer(357865432, "שושי", "ירושלים", "089750439"));
        s_dal.Customer.Create(new Customer(367865437, "רחלי", "פתח_תקווה", "083740439"));
        s_dal.Customer.Create(new Customer(377865432, "מירי", "מודיעין_עילית", "089742439"));

    }

    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(456,4453,567,67.90,true,DateTime.Now,DateTime.Now.AddDays(60)));
        s_dal.Sale.Create(new Sale(457, 4454, 767, 47.90, true, DateTime.Now, DateTime.Now.AddDays(37)));
        s_dal.Sale.Create(new Sale(458, 4455, 567, 67.90, true, DateTime.Now, DateTime.Now.AddDays(67)));
    }

    private static void createProducts() 
    {
        s_dal.Product.Create(new Product( 0,"שטיח",Categories.דקורציה_ופנאי,56.7,90));
        s_dal.Product.Create(new Product(0, "סבון", Categories.חדר_רחצה, 16.7, 40));
        s_dal.Product.Create(new Product(0, "כרית", Categories.חדר_שינה, 56.7, 90));
    }

    public static void Initalize() 
    {
        s_dal = DalApi.Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }
}
