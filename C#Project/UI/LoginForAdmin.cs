
namespace UI
{
    public partial class LoginForAdmin : Form
    {
        public LoginForAdmin()
        {
            InitializeComponent();
        }

        private void buttonForEntry_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals("4667"))
            {
                Admin admin = new Admin();
                admin.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("סיסמה שגויה");
        }

    }
}
