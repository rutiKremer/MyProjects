
using BO;

namespace BlApi;

    public interface IProduct
    {
    int Create(BO.Product item);
    BO.Product? Read(int id);
    List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
    void Update(BO.Product item);
    void Delete(int id);
    public List<BO.SaleInProduct> SearchSaleForProduct(int productId, bool isPrefer);
}

