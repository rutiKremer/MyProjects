
namespace UI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }
    }
}
