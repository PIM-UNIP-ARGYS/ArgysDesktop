using ArgysDesktop.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArgysDesktop
{
    public partial class VinculoCreate : Form
    {
        public VinculoCreate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VinculoCreate_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Vinculo";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Vinculo vinculo = new Vinculo();
            vinculo.Show();

            this.Hide();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://argysapi.azurewebsites.net/api/vinculo";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    dynamic data = new
                    {
                        pessoa = pessoa.Text,
                        cbo = cbo.Text,
                        dtAdmissao = Formatted.FormatDate(dtAdmissao.Text),
                        dtFgts = Formatted.FormatDate(dtFgts.Text),
                        cargo = cargo.Text,
                        salario = salario.Text,
                        tipoPagamento = tipoPagamento.Text,
                    };

                    string dataJson = JsonConvert.SerializeObject(data);
                    StringContent dataContent = new StringContent(dataJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, dataContent);

                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        Vinculo vinculo = new Vinculo();
                        vinculo.Show();

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
