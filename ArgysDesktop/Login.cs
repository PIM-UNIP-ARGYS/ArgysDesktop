using Newtonsoft.Json;
using System.Text;

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

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {

            string apiUrl = "https://argysapi.azurewebsites.net/api/auth";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new
                    {
                        email = textEmail.Text,
                        senha = textPassword.Text,
                    };

                    string dataJson = JsonConvert.SerializeObject(data);
                    StringContent dataContent = new StringContent(dataJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, dataContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Home home = new Home();
                        home.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha estão incorretos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na requisição: {ex.Message}");
                }
            }
        }
    }
}