

using BlApi;
using BO;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product item)
    {
        return _dal.Product.Create(item.ConvertToDoProduct());
    }
   
    public BO.Product? Read(int id)
    {
        return _dal.Product.Read(id)?.ConvertToBoProduct();
    }
    
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        return _dal.Product.ReadAll(p => filter(p.ConvertToBoProduct())).Select(p => p.ConvertToBoProduct()).ToList();

    }
    
    public void Update(BO.Product item)
    {
        _dal.Product.Update(item.ConvertToDoProduct());
    }
    
    public void Delete(int id)
    {
        _dal.Product.Delete(id);
    }
    
    public List<BO.SaleInProduct> SearchSaleForProduct(int productId, bool isPrefer)
    {
        try
        {
            return _dal.Sale.ReadAll(s => s.IdProduct == productId && (isPrefer || s.IsTheSaleForEverybody)
            && DateTime.Now >= s.DateBeginSale && DateTime.Now <= s.DateEndSale)
                 .Select(s => new SaleInProduct() 
           { IdSale = s.Id, AmountForSale = s.AmountForSale, IsForAllCustomer = s.IsTheSaleForEverybody, Price = s.IncludingPriceInSale }).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }


}
