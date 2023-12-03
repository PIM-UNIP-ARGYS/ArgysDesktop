namespace ArgysDesktop
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            mANUTENÇÃOToolStripMenuItem = new ToolStripMenuItem();
            dadosPessoaisToolStripMenuItem = new ToolStripMenuItem();
            vínculoToolStripMenuItem = new ToolStripMenuItem();
            tabelasToolStripMenuItem = new ToolStripMenuItem();
            cargoToolStripMenuItem = new ToolStripMenuItem();
            cBOToolStripMenuItem = new ToolStripMenuItem();
            pROCESSOSToolStripMenuItem = new ToolStripMenuItem();
            calcularFolhaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            históricoDeCálculosToolStripMenuItem = new ToolStripMenuItem();
            uSUÁRIOToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, mANUTENÇÃOToolStripMenuItem, tabelasToolStripMenuItem, pROCESSOSToolStripMenuItem, uSUÁRIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(54, 20);
            homeToolStripMenuItem.Text = "HOME";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // mANUTENÇÃOToolStripMenuItem
            // 
            mANUTENÇÃOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dadosPessoaisToolStripMenuItem, vínculoToolStripMenuItem });
            mANUTENÇÃOToolStripMenuItem.Name = "mANUTENÇÃOToolStripMenuItem";
            mANUTENÇÃOToolStripMenuItem.Size = new Size(101, 20);
            mANUTENÇÃOToolStripMenuItem.Text = "MANUTENÇÃO";
            // 
            // dadosPessoaisToolStripMenuItem
            // 
            dadosPessoaisToolStripMenuItem.Name = "dadosPessoaisToolStripMenuItem";
            dadosPessoaisToolStripMenuItem.Size = new Size(154, 22);
            dadosPessoaisToolStripMenuItem.Text = "Dados Pessoais";
            dadosPessoaisToolStripMenuItem.Click += dadosPessoaisToolStripMenuItem_Click;
            // 
            // vínculoToolStripMenuItem
            // 
            vínculoToolStripMenuItem.Name = "vínculoToolStripMenuItem";
            vínculoToolStripMenuItem.Size = new Size(154, 22);
            vínculoToolStripMenuItem.Text = "Vínculo";
            vínculoToolStripMenuItem.Click += vínculoToolStripMenuItem_Click;
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargoToolStripMenuItem, cBOToolStripMenuItem });
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(65, 20);
            tabelasToolStripMenuItem.Text = "TABELAS";
            tabelasToolStripMenuItem.Click += tabelasToolStripMenuItem_Click_1;
            // 
            // cargoToolStripMenuItem
            // 
            cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            cargoToolStripMenuItem.Size = new Size(106, 22);
            cargoToolStripMenuItem.Text = "Cargo";
            cargoToolStripMenuItem.Click += cargoToolStripMenuItem_Click;
            // 
            // cBOToolStripMenuItem
            // 
            cBOToolStripMenuItem.Name = "cBOToolStripMenuItem";
            cBOToolStripMenuItem.Size = new Size(106, 22);
            cBOToolStripMenuItem.Text = "CBO";
            cBOToolStripMenuItem.Click += cBOToolStripMenuItem_Click;
            // 
            // pROCESSOSToolStripMenuItem
            // 
            pROCESSOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calcularFolhaDePagamentoToolStripMenuItem, históricoDeCálculosToolStripMenuItem });
            pROCESSOSToolStripMenuItem.Name = "pROCESSOSToolStripMenuItem";
            pROCESSOSToolStripMenuItem.Size = new Size(83, 20);
            pROCESSOSToolStripMenuItem.Text = "PROCESSOS";
            // 
            // calcularFolhaDePagamentoToolStripMenuItem
            // 
            calcularFolhaDePagamentoToolStripMenuItem.Name = "calcularFolhaDePagamentoToolStripMenuItem";
            calcularFolhaDePagamentoToolStripMenuItem.Size = new Size(229, 22);
            calcularFolhaDePagamentoToolStripMenuItem.Text = "Calcular Folha de Pagamento";
            calcularFolhaDePagamentoToolStripMenuItem.Click += calcularFolhaDePagamentoToolStripMenuItem_Click;
            // 
            // históricoDeCálculosToolStripMenuItem
            // 
            históricoDeCálculosToolStripMenuItem.Name = "históricoDeCálculosToolStripMenuItem";
            históricoDeCálculosToolStripMenuItem.Size = new Size(229, 22);
            históricoDeCálculosToolStripMenuItem.Text = "Histórico de Cálculos";
            históricoDeCálculosToolStripMenuItem.Click += históricoDeCálculosToolStripMenuItem_Click;
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            uSUÁRIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            uSUÁRIOToolStripMenuItem.Size = new Size(68, 20);
            uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(878, 384);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mANUTENÇÃOToolStripMenuItem;
        private ToolStripMenuItem dadosPessoaisToolStripMenuItem;
        private ToolStripMenuItem vínculoToolStripMenuItem;
        private ToolStripMenuItem tabelasToolStripMenuItem;
        private ToolStripMenuItem cargoToolStripMenuItem;
        private ToolStripMenuItem cBOToolStripMenuItem;
        private ToolStripMenuItem pROCESSOSToolStripMenuItem;
        private ToolStripMenuItem calcularFolhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem históricoDeCálculosToolStripMenuItem;
        private ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}