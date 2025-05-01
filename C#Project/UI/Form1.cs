namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserEntry_Click(object sender, EventArgs e)
        {
            LoginForUsers loginForUsers = new LoginForUsers();
            loginForUsers.ShowDialog();
        }

        private void AdminEntry_Click_1(object sender, EventArgs e)
        {
            LoginForAdmin loginForAdmin = new LoginForAdmin();
            loginForAdmin.ShowDialog();
        }
    }
}
