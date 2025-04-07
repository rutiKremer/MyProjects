using BO;
namespace BlTest
{
    internal class Program
    {
        public static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        public static void Main(string[] args)
        {
            try
            {
               // Initialization.Initalize();
                int select;
                do
                {
                    Console.WriteLine("For create order press 1 For exit press 0");
                    select = int.Parse(Console.ReadLine());
                    if (select == 1)
                        menu();
                } while (select != 0);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        public static void menu()
        {
            try
            {
                Console.WriteLine("press identity card or 0");
                int identityCard = int.Parse(Console.ReadLine());
                int select;
                do
                {
                    Console.WriteLine("For add product press 1 for finish the order press 0");
                    select = int.Parse(Console.ReadLine());
                    if (select == 1)
                    {
                        BO.Order order = new BO.Order()
                        {
                            IsPreferredCustomer = identityCard != 0,
                        };
                        AddProduct(order, identityCard);
                    }
                } while (select != 0);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }

        public static void AddProduct(BO.Order order, int identityCard)
        {
            try
            {
                Console.WriteLine("press product id");
                int idProduct = int.Parse(Console.ReadLine());
                Console.WriteLine("press amount for order");
                int quantity = int.Parse(Console.ReadLine());
                List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, idProduct, quantity);
                foreach (SaleInProduct sale in sales)
                {
                    Console.WriteLine(sale);
                }
                Console.WriteLine($"finall price to order {order.FinallPrice}");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }

    }
}
