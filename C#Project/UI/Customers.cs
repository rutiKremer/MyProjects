
using BlApi;
using BO;

namespace UI
{
    public partial class Customers : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        private static List<BO.Customer> customers = _bl.Customer.ReadAll(readAll)!;

        public Customers()
        {
            InitializeComponent();
            customersList.DataSource = customers.Select(c => c.IdentityCard).ToList();
            identityCus.DataSource = customers.Select(c => c.IdentityCard).ToList();
            allCustomers.DataSource = customers.Select(c => c.ToStringProperty()).ToList();
            oneCustomer.DataSource = customers.Select(c => c.IdentityCard).ToList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int identity = int.Parse(IdentityCard.Text);
                string name = NameCustomer.Text;
                string addressC = address.Text;
                string phoneC = phone.Text;
                BO.Customer customer = new BO.Customer(identity, name, addressC, phoneC);
                _bl.Customer.Create(customer);
                MessageBox.Show("לקוח נוסף בהצלחה");
                IdentityCard.Clear();
                NameCustomer.Clear();
                address.Clear();
                phone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int identityCard = int.Parse(customersList.Text);
                _bl.Customer.Delete(identityCard);
                MessageBox.Show("הלקוח נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int idCus = int.Parse(identityCus.Text);
                string name = nameCus.Text;
                string address = addressCus.Text;
                string phone = phonCus.Text;
                BO.Customer customer = new BO.Customer(idCus, name, address, phone);
                _bl.Customer.Update(customer);
                MessageBox.Show("הלקוח עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool readAll(BO.Customer c)
        {
            if (c != null)
                return true;
            return false;
        }

        private void allC_Click(object sender, EventArgs e)
        {
            allCustomers.DataSource = customers.Select(c => c.ToStringProperty()).ToList();
        }

        private void searchCus_Click(object sender, EventArgs e)
        {
            BO.Customer c = _bl.Customer.Read(int.Parse(oneCustomer.Text))!;
            allCustomers.DataSource = null;
            allCustomers.DataSource = new List<string>() { c.ToStringProperty() }.ToList();
        }
    }
}
