using BlApi;
using BlImplementation;
using BO;

namespace UI;

public partial class Users : Form
{
    private static IBl _bl = BlApi.Factory.Get();
    private static List<BO.Product> product = _bl.Product.ReadAll(readAll)!;
    private static BO.Order newOrder;
    private static List<BO.SaleInProduct> saleInProducts;

    public Users(int identityCard)
    {
        InitializeComponent();
        productList.DataSource = product.Select(p => p.NameProduct).ToList();
        newOrder = new BO.Order()
        {
            IsPreferredCustomer = identityCard != 0
        };
    }

    public static bool readAll(BO.Product p)
    {
        return p != null;
    }

    private void showSale_Click(object sender, EventArgs e)
    {
        salesOfProduct.DataSource = saleInProducts.Select(s => s.ToStringProperty()).ToList();
    }

    private void addToCart_Click(object sender, EventArgs e)
    {
        string pName = (string)productList.SelectedItem;
        int amountFromProduct = (int)amountForOrder.Value;
        if (amountFromProduct != 0)
        {
            try
            {
                BO.Product p = product.FirstOrDefault(p => p.NameProduct.Equals(pName))!;
                saleInProducts = _bl.Order.AddProductToOrder(newOrder, p.IdProduct, amountFromProduct);
                for (int i = 0; i < amountFromProduct; i++)
                    orderItem.Items.Add(pName);
                sum.Items.Clear();
                sum.Items.Add(newOrder.FinallPrice);
            }
            catch
            {
                MessageBox.Show("אין מספיק מהמוצר במלאי");
            }
        }
        else
        {
            MessageBox.Show("לא נבחר כמות מהמוצר");
        }
    }

    private void finishOrder_Click(object sender, EventArgs e)
    {
        _bl.Order.DoOrder(newOrder);
        MessageBox.Show("ההזמנה בוצעה בהצלחה");
    }
}
