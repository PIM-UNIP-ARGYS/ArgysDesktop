namespace ArgysDesktop
{
    partial class HistoricoFp
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
            pessoaGrid = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pessoaGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, mANUTENÇÃOToolStripMenuItem, tabelasToolStripMenuItem, pROCESSOSToolStripMenuItem, uSUÁRIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1058, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(54, 20);
            homeToolStripMenuItem.Text = "HOME";
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
            // 
            // vínculoToolStripMenuItem
            // 
            vínculoToolStripMenuItem.Name = "vínculoToolStripMenuItem";
            vínculoToolStripMenuItem.Size = new Size(154, 22);
            vínculoToolStripMenuItem.Text = "Vínculo";
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargoToolStripMenuItem, cBOToolStripMenuItem });
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(65, 20);
            tabelasToolStripMenuItem.Text = "TABELAS";
            // 
            // cargoToolStripMenuItem
            // 
            cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            cargoToolStripMenuItem.Size = new Size(106, 22);
            cargoToolStripMenuItem.Text = "Cargo";
            // 
            // cBOToolStripMenuItem
            // 
            cBOToolStripMenuItem.Name = "cBOToolStripMenuItem";
            cBOToolStripMenuItem.Size = new Size(106, 22);
            cBOToolStripMenuItem.Text = "CBO";
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
            // 
            // históricoDeCálculosToolStripMenuItem
            // 
            históricoDeCálculosToolStripMenuItem.Name = "históricoDeCálculosToolStripMenuItem";
            históricoDeCálculosToolStripMenuItem.Size = new Size(229, 22);
            históricoDeCálculosToolStripMenuItem.Text = "Histórico de Cálculos";
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
            // 
            // pessoaGrid
            // 
            pessoaGrid.AllowUserToOrderColumns = true;
            pessoaGrid.BackgroundColor = SystemColors.Window;
            pessoaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pessoaGrid.Location = new Point(0, 29);
            pessoaGrid.Name = "pessoaGrid";
            pessoaGrid.RowTemplate.Height = 25;
            pessoaGrid.Size = new Size(1058, 478);
            pessoaGrid.TabIndex = 7;
            // 
            // HistoricoFp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 508);
            Controls.Add(pessoaGrid);
            Controls.Add(menuStrip1);
            Name = "HistoricoFp";
            Text = "HistoricoFp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pessoaGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
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
        private DataGridView pessoaGrid;
    }
}