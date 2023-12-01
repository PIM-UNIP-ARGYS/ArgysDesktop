using ArgysDesktop.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgysDesktop
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private async void Pessoa_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Dados Pessoais";
            await GetDataApi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task GetDataApi()
        {
            string apiUrl = "http://localhost:5296/api/pessoa";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        List<PessoaDto> pessoaDtos = JsonConvert.DeserializeObject<List<PessoaDto>>(content);

                        pessoaGrid.DataSource = pessoaDtos;

                        DataGridViewButtonColumn colunaExcluir = new DataGridViewButtonColumn();
                        colunaExcluir.HeaderText = "Excluir";
                        colunaExcluir.UseColumnTextForButtonValue = true;
                        pessoaGrid.Columns.Add(colunaExcluir);
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao obter dados da API: {response.StatusCode} - {response.ReasonPhrase}");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter dados da API: {ex.Message}");
                }
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            this.Hide();

            PessoaCreate pessoaCreate = new PessoaCreate();
            pessoaCreate.Show();
        }
    }
}
