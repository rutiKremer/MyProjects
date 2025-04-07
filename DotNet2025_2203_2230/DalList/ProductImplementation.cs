using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal;
internal class ProductImplementation : IProduct
{

    public int Create(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Strat - create product");
        Product p = item with { IdProduct = DataSource.Config.ProductCode };
        DataSource.Products.Add(p);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - create product");
        return p.IdProduct;
    }

    public Product? Read(int id) 
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - read product");
        try
        {
            return DataSource.Products.First(p => p.IdProduct == id);
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - create product");
            throw new DalNotFound("product code not found");
        }
        finally
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - read product");
        }
    }

    public Product Read(Func<Product, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read product");
        return DataSource.Products.FirstOrDefault(p => filter(p));
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll product");
        if (filter != null)
            return DataSource.Products.Where(c => filter(c)).ToList();
        return new List<Product?>(DataSource.Products);
    }

    public void Update(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update product");
        Delete(item.IdProduct);
        DataSource.Products.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update product");
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete product");
        Product p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete product");
    }
}
