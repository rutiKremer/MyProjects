
using BlApi;
using BO;


namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
       return _dal.Customer.Create(item.ConvertToDoCustomer());
    }
    public BO.Customer? Read(int id)
    { 
        return _dal.Customer.Read(id)?.ConvertToBoCustomer();
    }
    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
       return _dal.Customer.ReadAll(c => filter(c.ConvertToBoCustomer())).Select(c => c.ConvertToBoCustomer()).ToList();
    }
    public void Update(BO.Customer item)
    {
        _dal.Customer.Update(item.ConvertToDoCustomer());
    }
    public void Delete(int id) 
    { 
        _dal.Customer.Delete(id);
    }
    public bool isExistCustomer(int customerId)
    {
        try
        {
            _dal.Customer.Read(customerId);
            return true;
        } catch {
            return false;   
        }
    }
}
