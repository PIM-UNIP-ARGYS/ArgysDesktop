﻿namespace ArgysDesktop
{
    partial class Cbo
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
            panel1 = new Panel();
            ButtonCreate = new Button();
            cboGrid = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, mANUTENÇÃOToolStripMenuItem, tabelasToolStripMenuItem, pROCESSOSToolStripMenuItem, uSUÁRIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
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
            // panel1
            // 
            panel1.Controls.Add(ButtonCreate);
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 6;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(719, 2);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(75, 23);
            ButtonCreate.TabIndex = 0;
            ButtonCreate.Text = "Adicionar";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // cboGrid
            // 
            cboGrid.AllowUserToOrderColumns = true;
            cboGrid.BackgroundColor = SystemColors.Window;
            cboGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cboGrid.Location = new Point(0, 56);
            cboGrid.Name = "cboGrid";
            cboGrid.RowTemplate.Height = 25;
            cboGrid.Size = new Size(800, 394);
            cboGrid.TabIndex = 5;
            // 
            // Cbo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(cboGrid);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Cbo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cbo";
            Load += Cbo_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cboGrid).EndInit();
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
        private Panel panel1;
        private Button ButtonCreate;
        private DataGridView cboGrid;
    }
}