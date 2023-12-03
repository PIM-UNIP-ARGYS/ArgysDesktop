namespace ArgysDesktop
{
    partial class VinculoCreate
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
            groupBox2 = new GroupBox();
            ButtonBack = new Button();
            ButtonSave = new Button();
            groupBox1 = new GroupBox();
            label12 = new Label();
            textBox13 = new TextBox();
            label2 = new Label();
            pessoa = new TextBox();
            label1 = new Label();
            TextNome = new TextBox();
            tabPage1 = new TabPage();
            salario = new TextBox();
            cargo = new TextBox();
            cbo = new TextBox();
            dtAdmissao = new MaskedTextBox();
            label7 = new Label();
            tipoPagamento = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            dtFgts = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ButtonBack);
            groupBox2.Controls.Add(ButtonSave);
            groupBox2.Location = new Point(956, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(90, 121);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(6, 64);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 1;
            ButtonBack.Text = "Voltar";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(6, 33);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Salvar";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pessoa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TextNome);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 121);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(273, 16);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 5;
            label12.Text = "Matrícula";
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Location = new Point(273, 34);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(208, 23);
            textBox13.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Trabalhador";
            label2.Click += label2_Click;
            // 
            // pessoa
            // 
            pessoa.Location = new Point(6, 82);
            pessoa.Name = "pessoa";
            pessoa.Size = new Size(926, 23);
            pessoa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Matrícula eSocial";
            // 
            // TextNome
            // 
            TextNome.Enabled = false;
            TextNome.Location = new Point(6, 34);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(212, 23);
            TextNome.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(salario);
            tabPage1.Controls.Add(cargo);
            tabPage1.Controls.Add(cbo);
            tabPage1.Controls.Add(dtAdmissao);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(tipoPagamento);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dtFgts);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1026, 314);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Gerais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // salario
            // 
            salario.Location = new Point(269, 95);
            salario.Name = "salario";
            salario.Size = new Size(208, 23);
            salario.TabIndex = 24;
            // 
            // cargo
            // 
            cargo.Location = new Point(6, 95);
            cargo.Name = "cargo";
            cargo.Size = new Size(208, 23);
            cargo.TabIndex = 23;
            // 
            // cbo
            // 
            cbo.Location = new Point(6, 21);
            cbo.Name = "cbo";
            cbo.Size = new Size(208, 23);
            cbo.TabIndex = 21;
            // 
            // dtAdmissao
            // 
            dtAdmissao.Location = new Point(269, 21);
            dtAdmissao.Mask = "00/00/0000";
            dtAdmissao.Name = "dtAdmissao";
            dtAdmissao.Size = new Size(208, 23);
            dtAdmissao.TabIndex = 22;
            dtAdmissao.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(535, 80);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 14;
            label7.Text = "Tipo de pagamento";
            // 
            // tipoPagamento
            // 
            tipoPagamento.FormattingEnabled = true;
            tipoPagamento.Items.AddRange(new object[] { "Mensal" });
            tipoPagamento.Location = new Point(535, 95);
            tipoPagamento.Name = "tipoPagamento";
            tipoPagamento.Size = new Size(208, 23);
            tipoPagamento.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 80);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 12;
            label8.Text = "Salário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 80);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 10;
            label9.Text = "Cargo";
            // 
            // dtFgts
            // 
            dtFgts.Location = new Point(535, 24);
            dtFgts.Mask = "00/00/0000";
            dtFgts.Name = "dtFgts";
            dtFgts.Size = new Size(208, 23);
            dtFgts.TabIndex = 8;
            dtFgts.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 6);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 5;
            label5.Text = "Data de opção FGTS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 6);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de admissão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 6);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "CBO";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 147);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 342);
            tabControl1.TabIndex = 9;
            // 
            // VinculoCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 508);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "VinculoCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vinculo";
            Load += VinculoCreate_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button ButtonBack;
        private Button ButtonSave;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox pessoa;
        private Label label1;
        private TextBox TextNome;
        private Label label12;
        private TextBox textBox13;
        private TabPage tabPage1;
        private TextBox salario;
        private TextBox cargo;
        private TextBox cbo;
        private MaskedTextBox dtAdmissao;
        private Label label7;
        private ComboBox tipoPagamento;
        private Label label8;
        private Label label9;
        private MaskedTextBox dtFgts;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabControl tabControl1;
    }
}