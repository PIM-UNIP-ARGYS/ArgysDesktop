using ArgysDesktop.Utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ArgysDesktop
{
    public partial class CboCreate : Form
    {
        public CboCreate()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cbo cbo = new Cbo();
            cbo.Show();
        }

        private void CboCreate_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - CBO";
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:5296/api/cbo";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    dynamic data = new
                    {
                        descricao = descricao.Text,
                        salarioAula = salarioAula.Checked,
                        motoristaProfissional = motoristaProfissional.Checked,
                    };

                    string dataJson = JsonConvert.SerializeObject(data);
                    StringContent dataContent = new StringContent(dataJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, dataContent);

                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        Cbo cbo = new Cbo();
                        cbo.Show();

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
