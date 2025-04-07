
using BlApi;
using BO;

namespace BlImplementation;

internal class SaleImplementation:ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        return _dal.Sale.Create(item.ConvertToDoSale());
    }
    
    public BO.Sale? Read(int id) 
    { 
        return _dal.Sale.Read(id)?.ConvertToBoSale();
    }
    
    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null) 
    {
        return _dal.Sale.ReadAll(s => filter(s.ConvertToBoSale())).Select(s => s.ConvertToBoSale()).ToList();
    }
    
    public void Update(BO.Sale item)
    { 
        _dal.Sale.Update(item.ConvertToDoSale());
    }
    
    public void Delete(int id) 
    { 
        _dal.Sale.Delete(id);
    }
}
