﻿using System;
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
    public partial class CalcFP : Form
    {
        public CalcFP()
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

        private void históricoDeCálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoricoFp historicoFp = new HistoricoFp();
            historicoFp.Show();
        }

        private void uSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}