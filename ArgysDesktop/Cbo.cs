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
    public partial class Cbo : Form
    {
        public Cbo()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pessoa pessoa = new Pessoa();
            pessoa.Show();
        }

        private void vínculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Vinculo vinculo = new Vinculo();
            vinculo.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cargo cargo = new Cargo();
            cargo.Show();
        }

        private void calcularFolhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcFP calcFP = new CalcFP();
            calcFP.Show();
        }

        private void históricoDeCálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoricoFp historicoFp = new HistoricoFp();
            historicoFp.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void Cbo_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - CBO";
            GetDataApi();
        }

        private async Task GetDataApi()
        {
            string apiUrl = "http://localhost:5296/api/cbo";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        List<CboDto> pessoaDtos = JsonConvert.DeserializeObject<List<CboDto>>(content);

                        cboGrid.DataSource = pessoaDtos;

                        DataGridViewButtonColumn colunaExcluir = new DataGridViewButtonColumn();
                        colunaExcluir.HeaderText = "Excluir";
                        colunaExcluir.UseColumnTextForButtonValue = true;
                        cboGrid.Columns.Add(colunaExcluir);
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
    }
}
