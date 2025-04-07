using BlApi;
using BO;

namespace BlImplementation;

public class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int AmountForOrder)
    {
        try
        {
            DO.Product product = _dal.Product.Read(productId)!;
            BO.ProductInOrder? productInOrder = order.ProductInOrder.FirstOrDefault(p => p.IdProduct == product.IdProduct);
            if (productInOrder != null)
            {
                if (product.StockAmount >= AmountForOrder + productInOrder.AmountInOrder)
                    productInOrder.AmountInOrder += AmountForOrder;
                else
                    throw new BLNotEnoughInStock("אין מספיק מהמוצר במלאי");
            }
            else
            {
                if (product.StockAmount - AmountForOrder >= 0)
                {
                    productInOrder = new ProductInOrder()
                    {
                        IdProduct = productId,
                        BasicPriceProduct = product.Price,
                        NameProduct = product.NameProduct,
                        AmountInOrder = AmountForOrder
                    };
                    order.ProductInOrder.Add(productInOrder);
                }
                else
                    throw new BLNotEnoughInStock("אין מספיק מהמוצר במלאי");
            }

            SearchSaleForProduct(productInOrder, order.IsPreferredCustomer);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);
            return productInOrder.SalesList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {
        int count = productInOrder.AmountInOrder;
        List<BO.SaleInProduct> salesForProduct = new List<SaleInProduct>();
        try
        {
            if (productInOrder.SalesList.Count == 0)
            {
                double price = _dal.Product.Read(productInOrder.IdProduct).Price;
                productInOrder.FinallPriceProduct = productInOrder.AmountInOrder * price;
            }
            else
                foreach (BO.SaleInProduct sale in productInOrder.SalesList)
                {
                    if (count == 0)
                        break;
                    if (count < sale.AmountForSale)
                        continue;
                    else
                    {
                        int time = count / sale.AmountForSale;
                        productInOrder.FinallPriceProduct += time * sale.Price;
                        count -= time;
                        salesForProduct.Add(sale);
                    }
                }
            productInOrder.FinallPriceProduct += productInOrder.BasicPriceProduct * count;
            productInOrder.SalesList = salesForProduct;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            order.FinallPrice = order.ProductInOrder.Sum(p => p.FinallPriceProduct);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder product in order.ProductInOrder)
            {
                DO.Product p = _dal.Product.Read(product.IdProduct);
                int count = p.StockAmount - product.AmountInOrder;
                _dal.Product.Update(p with { StockAmount = count });
            }
        }
        catch
        {
            throw new Exception("עדכון כמות המוצר במלאי נכשל");
        }
    }

    public void SearchSaleForProduct(BO.ProductInOrder productIOnOrder, bool isPreferredCustomer)
    {
        try
        {
            productIOnOrder.SalesList = _dal.Sale.ReadAll(s => s.IdProduct == productIOnOrder.IdProduct &&
                (s.DateBeginSale <= DateTime.Now) && (s.DateEndSale >= DateTime.Now)
                && (productIOnOrder.AmountInOrder >= s.AmountForSale) &&
                isPreferredCustomer || (!isPreferredCustomer && s.IsTheSaleForEverybody)).
                Select(s => new SaleInProduct() { AmountForSale = s.AmountForSale, IdSale = s.Id, Price = s.IncludingPriceInSale, IsForAllCustomer = s.IsTheSaleForEverybody }).OrderBy(s => s.Price / s.AmountForSale).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
