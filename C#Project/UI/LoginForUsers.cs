
namespace UI
{
    public partial class LoginForUsers : Form
    {
        public LoginForUsers()
        {
            InitializeComponent();
        }

        private void buttonForEntry_Click(object sender, EventArgs e)
        {
            string s = IdentityCard.Text;
            if (s == "")
                MessageBox.Show("לא הוכנס ת.ז");
            else
            {
                int idCustomer = int.Parse(s);
                Users users = new Users(idCustomer);
                users.ShowDialog();
                this.Close();
            }
        }
    }
}
