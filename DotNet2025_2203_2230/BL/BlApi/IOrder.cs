
namespace BlApi;

    public interface IOrder
    {
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order,int productId,int AmountForOrder);
    
    public void CalcTotalPriceForProduct(BO.ProductInOrder product);

    public void CalcTotalPrice(BO.Order order);

    public void	DoOrder(BO.Order order);

    public void SearchSaleForProduct(BO.ProductInOrder productIOnOrder, bool isPreferredCustomer);
}

