using System.Reflection;
using DO;
using DalApi;
using Tools;
namespace Dal;
internal class CustomerImplementation : ICustomer
{

    public int Create(Customer item) 
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,MethodBase.GetCurrentMethod().Name, "Start - create customer object");
       if (DataSource.Customers.Any(c => c.IdentityCard == item.IdentityCard))
              throw new DalExistsThisId("exists customer with this IdentityCard");
        DataSource.Customers.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,MethodBase.GetCurrentMethod().Name, "End - create customer object");
        return item.IdentityCard;
    }

    public Customer? Read(int id) 
    {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,MethodBase.GetCurrentMethod().Name, "Start - read customer");
        try
        {
            return DataSource.Customers.First(p => p.IdentityCard == id);
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,MethodBase.GetCurrentMethod().Name, "Failed - read customer");
            throw new DalNotFound("IdentityCard customer not found");            
        
        }
        finally
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,MethodBase.GetCurrentMethod().Name, "End - read customer");
        }
    }

    public Customer Read(Func<Customer, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " read customer");
        return DataSource.Customers.FirstOrDefault(c => filter(c));
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll customer");
        if (filter != null)
           return DataSource.Customers.Where(c => filter(c)).ToList();
        return new List<Customer?>(DataSource.Customers);
    }

    public void Update(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update customer");
        Delete(item.IdentityCard);
        DataSource.Customers.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update customer");
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete customer");
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete customer");
    }
}
