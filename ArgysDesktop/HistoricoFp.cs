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
    public partial class HistoricoFp : Form
    {
        public HistoricoFp()
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

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbo cbo = new Cbo();
            cbo.Show();
        }

        private void calcularFolhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcFP calcFP = new CalcFP();
            calcFP.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void HistoricoFp_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Histórico Folha de Pagamento";
            GetDataApi();
        }

        private async Task GetDataApi()
        {
            string apiUrl = "https://argysapi.azurewebsites.net/api/folha_pagamento/historico";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        List<FpDto> fpDtos = JsonConvert.DeserializeObject<List<FpDto>>(content);

                        historicoGrid.DataSource = fpDtos;

                        DataGridViewButtonColumn colunaDownload = new DataGridViewButtonColumn();
                        colunaDownload.HeaderText = "Download";
                        colunaDownload.UseColumnTextForButtonValue = true;
                        historicoGrid.Columns.Add(colunaDownload);
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

        private void historicoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == historicoGrid.Columns["Download"].Index && e.RowIndex >= 0)
            {
                string base64Data = historicoGrid.Rows[e.RowIndex].Cells["FolhaPagamento"].Value.ToString();
                string fileName = historicoGrid.Rows[e.RowIndex].Cells["NomeArquivo"].Value.ToString();

                BaixarPDF(base64Data, fileName);
            }
        }

        private void BaixarPDF(string base64Data, string fileName)
        {
            try
            {
                byte[] pdfBytes = Convert.FromBase64String(base64Data);

                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string filePath = Path.Combine(downloadsFolder, fileName);

                File.WriteAllBytes(filePath, pdfBytes);

                MessageBox.Show("PDF baixado com sucesso! Caminho: " + filePath, "Download Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar o PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
