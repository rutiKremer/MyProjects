using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal;
internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - create sale");
        Sale s = item with { Id = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - create sale");
        return s.Id;
    }

    public Sale? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - read sale");
        try
        {               
        return DataSource.Sales.First(s => s.Id == id);       
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - read sale");
            throw new DalNotFound("sale code not found");
        }
    }

    public Sale Read(Func<Sale, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read sale");
        return DataSource.Sales.FirstOrDefault(s => filter(s));
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll sale");
        if (filter != null)
            return DataSource.Sales.Where(s => filter(s)).ToList();
        return new List<Sale?>(DataSource.Sales);
    }

    public void Update(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update sale");
        Delete(item.Id);
        DataSource.Sales.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update sale");
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete sale");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete sale");
    }
}
