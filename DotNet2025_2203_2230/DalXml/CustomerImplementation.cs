using Tools;
using DO;
using DalApi;
using System.Xml.Linq;
using System.Reflection;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    private const string CUSTOMER = "Customer";
    private const string IDENTITY_CARD = "IdentityCard";
    private const string NAME_CUSTOMER = "NameCustomer";
    private const string ADDRESS = "Address";
    private const string PHONE = "Phone";
    private const string FILE_PATH = @"..\xml\customers.xml";


    public int Create(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - create customer object");
        XElement element = XElement.Load(FILE_PATH);
        if (element.HasElements)
        {
            bool temp = element.Elements().Any(c => c.Element(IDENTITY_CARD) != null && int.Parse(c.Element(IDENTITY_CARD).Value) == item.IdentityCard);
            if (temp)
                throw new DalExistsThisId("כבר קיים כזה לקוח");
        }
        XElement customer = new XElement(CUSTOMER,
       new XElement(IDENTITY_CARD, item.IdentityCard),
       new XElement(NAME_CUSTOMER, item.NameCustomer),
       new XElement(ADDRESS, item.Address),
       new XElement(PHONE, item.Phone));
       element.Add(customer);
       element.Save(FILE_PATH);
       LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - create customer object");
        return item.IdentityCard;

    }

    public Customer? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - read customer");
        XElement? element = XElement.Load(FILE_PATH)
        .Elements(CUSTOMER).FirstOrDefault(p => int.Parse(p.Element(IDENTITY_CARD).Value) == id);

        if (element == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - read customer");
            throw new DalNotFound("לא קיים כזה לקוח");
        }
        else
        {
            Customer p = new Customer(int.Parse(element.Element(IDENTITY_CARD)!.Value),
            element.Element(NAME_CUSTOMER)!.Value,
            element.Element(ADDRESS)!.Value,
            element.Element(PHONE)!.Value);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - read customer");
            return p;
        }
    }

    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " read customer");
        List<Customer> customers = XElement.Load(FILE_PATH)
       .Elements(CUSTOMER)
        .Select(c => new Customer(
            int.Parse(c.Element(IDENTITY_CARD)!.Value),
            c.Element(NAME_CUSTOMER)!.Value,
            c.Element(ADDRESS)!.Value,
            c.Element(PHONE)!.Value))
        .ToList();
        Customer? customer = customers.FirstOrDefault(filter);
        if (customer == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " read customer failed");
            throw new DalNotFound("לא קיים כזה לקוח");
        }
        return customer;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll customer");
        XElement element = XElement.Load(FILE_PATH);
        List<Customer> customers = element.Elements(CUSTOMER)
                .Select(p => new Customer
                {
                    IdentityCard = int.Parse(p.Element(IDENTITY_CARD)!.Value),
                    NameCustomer = p.Element(NAME_CUSTOMER)!.Value,
                    Address = p.Element(ADDRESS)!.Value,
                    Phone = p.Element(PHONE)!.Value
                }).ToList();
        if (filter != null)
            customers = customers.Where(filter).ToList();
        return customers;
    }

    public void Update(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update customer");
        XElement customers = XElement.Load(FILE_PATH);
        XElement element = customers.Elements(CUSTOMER)
            .FirstOrDefault(p => int.Parse(p.Element(IDENTITY_CARD)!.Value) == item.IdentityCard);

        if (element == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " update customer failed");
           throw new DalNotFound("לא קיים כזה לקוח");
        }

        element.Element(NAME_CUSTOMER)!.SetValue(item.NameCustomer);
        element.Element(ADDRESS)!.SetValue(item.Address);
        element.Element(PHONE)!.SetValue(item.Phone);
        customers.Save(FILE_PATH);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update customer");
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete customer");
        try
        {
            XElement customers = XElement.Load(FILE_PATH);
            XElement customerToDelete = customers.Elements(CUSTOMER)
            .FirstOrDefault(p => int.Parse(p.Element(IDENTITY_CARD)!.Value) == id);

            if (customerToDelete == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " delete customer failed");
                throw new DalNotFound("לא קיים לקוח עם תעודת זהות זו");
            }
            customerToDelete.Remove();
            customers.Save(FILE_PATH);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete customer");
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer failed");
            throw new DalNotFound("לא קיים כזה מוצר");
        }
    }
}
