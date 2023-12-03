using ArgysDesktop.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgysDesktop
{
    public partial class PessoaCreate : Form
    {
        public PessoaCreate()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:5296/api/pessoa";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    dynamic data = new
                    {
                        nome = nome.Text,
                        nomeSocial = nomeSocial.Text ?? null,
                        informacoesPessoais = new
                        {
                            sexo = sexo.Text,
                            raca = raca.Text,
                            estadoCivil = estadoCivil.Text,
                            dataNascimento = Formatted.FormatDate(dataNascimento.Text),
                            grauInstituicao = grauInstituicao.Text,
                            deficiencia = deficiencia.Text,
                            nacionalidade = nacionalidade.Text,
                            cotaDeficiencia = cotaDeficiencia.Checked,
                            proprietario = proprietario.Checked,
                            mae = mae.Text,
                            pai = pai.Text,
                        },
                        documentos = new
                        {
                            cpf = cpf.Text,
                            pisNis = pisNis.Text,
                            rg = Formatted.GetRgNumberAndRemoveDigit(rg.Text),
                            rgDigito = Formatted.GetRgDigit(rg.Text),
                            ufRg = ufRg.Text,
                            dataEmissaoRg = Formatted.FormatDate(dataEmissaoRg.Text),
                            orgaoExpedidor = orgaoExpedidor.Text,
                        },
                        tituloEleitor = new
                        {
                            tituloEleitor = tituloEleitor.Text,
                            secao = secao.Text,
                            zonaEleitoral = zonaEleitoral.Text,
                        },
                        ctps = new
                        {
                            numero = numero.Text,
                            serie = serie.Text,
                            expedicao = Formatted.FormatDate(expedicao.Text),
                            uf = uf.Text,
                        },
                        endereco = new
                        {
                            cep = cep.Text,
                            uf = ufEndereco.Text,
                            cidade = cidade.Text,
                            bairro = bairro.Text,
                            logradouro = logradouro.Text,
                            numero = numeroEndereco.Text,
                            complemento = complemento.Text,
                            tipo = tipo.Text,
                        },
                    };

                    string dataJson = JsonConvert.SerializeObject(data);
                    StringContent dataContent = new StringContent(dataJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, dataContent);

                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        Pessoa pessoa = new Pessoa();
                        pessoa.Show();

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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }

        private void PessoaCreate_Load(object sender, EventArgs e)
        {
            this.Text = "Argys Technology - Pessoa";
        }
    }
}
