
namespace BO;

    public class Order
    {
        public bool IsPreferredCustomer { get; set; }

        public List<BO.ProductInOrder> ProductInOrder { get; set; }

        public double FinallPrice { get; set; }

    public Order()
    {
        ProductInOrder = new List<BO.ProductInOrder>();
    }
}

