namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminEntry_Click(object sender, EventArgs e)
        {
            LoginForAdmin loginForAdmin = new LoginForAdmin();
            loginForAdmin.ShowDialog();
        }

        private void UserEntry_Click(object sender, EventArgs e)
        {
            LoginForUsers loginForUsers = new LoginForUsers();
            loginForUsers.ShowDialog();
        }
    }
}
