using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgysDesktop
{
    public partial class CargoCreate : Form
    {
        public CargoCreate()
        {
            InitializeComponent();
        }

        private void CargoCreate_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Cargo";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cargo cargo = new Cargo();
            cargo.Show();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:5296/api/cargo";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    dynamic data = new
                    {
                        cbo = cbo.Text,
                        descricao = descricao.Text,
                    };

                    string dataJson = JsonConvert.SerializeObject(data);
                    StringContent dataContent = new StringContent(dataJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, dataContent);

                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        Cargo cargo = new Cargo();
                        cargo.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
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
