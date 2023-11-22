namespace ArgysDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Login";
            CenterControls();
        }

        private void CenterControls()
        {
            foreach (Control control in Controls)
            {
                control.Left = (ClientSize.Width - control.Width) / 2;

                control.Top = (ClientSize.Height - control.Height) / 2;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "admin@admin.com" && textPassword.Text == "admin")
            {
                Home home = new Home();
                home.Show();

                this.Hide();
            } else
            {
                MessageBox.Show("E-mail ou senha incorretos.", "Argys Technology", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}