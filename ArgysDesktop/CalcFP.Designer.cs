namespace ArgysDesktop
{
    partial class CalcFP
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
            groupBox2 = new GroupBox();
            ButtonSave = new Button();
            groupBox1 = new GroupBox();
            referencia = new MaskedTextBox();
            label3 = new Label();
            label1 = new Label();
            TextNome = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            uSUÁRIOToolStripMenuItem.Click += uSUÁRIOToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ButtonSave);
            groupBox2.Location = new Point(956, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(90, 78);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(6, 33);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Gerar";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(referencia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TextNome);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 78);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // referencia
            // 
            referencia.Location = new Point(766, 33);
            referencia.Mask = "00/0000";
            referencia.Name = "referencia";
            referencia.Size = new Size(166, 23);
            referencia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 15);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Referência";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Empresa";
            // 
            // TextNome
            // 
            TextNome.Enabled = false;
            TextNome.Location = new Point(6, 33);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(754, 23);
            TextNome.TabIndex = 0;
            TextNome.Text = "Default";
            // 
            // CalcFP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 272);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "CalcFP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcFP";
            Load += CalcFP_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private Button ButtonSave;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox TextNome;
        private MaskedTextBox referencia;
    }
}