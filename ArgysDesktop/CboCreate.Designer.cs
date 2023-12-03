namespace ArgysDesktop
{
    partial class CboCreate
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
            motoristaProfissional = new CheckBox();
            salarioAula = new CheckBox();
            label2 = new Label();
            descricao = new TextBox();
            label1 = new Label();
            codigo = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ButtonBack);
            groupBox2.Controls.Add(ButtonSave);
            groupBox2.Location = new Point(956, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(90, 121);
            groupBox2.TabIndex = 7;
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
            groupBox1.Controls.Add(motoristaProfissional);
            groupBox1.Controls.Add(salarioAula);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(descricao);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(codigo);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 121);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // motoristaProfissional
            // 
            motoristaProfissional.AutoSize = true;
            motoristaProfissional.Location = new Point(273, 35);
            motoristaProfissional.Name = "motoristaProfissional";
            motoristaProfissional.Size = new Size(150, 19);
            motoristaProfissional.TabIndex = 17;
            motoristaProfissional.Text = "É motorista profissional";
            motoristaProfissional.UseVisualStyleBackColor = true;
            // 
            // salarioAula
            // 
            salarioAula.AutoSize = true;
            salarioAula.Location = new Point(181, 35);
            salarioAula.Name = "salarioAula";
            salarioAula.Size = new Size(86, 19);
            salarioAula.TabIndex = 16;
            salarioAula.Text = "Salário aula";
            salarioAula.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // descricao
            // 
            descricao.Location = new Point(6, 82);
            descricao.Name = "descricao";
            descricao.Size = new Size(926, 23);
            descricao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // codigo
            // 
            codigo.Enabled = false;
            codigo.Location = new Point(6, 33);
            codigo.Name = "codigo";
            codigo.Size = new Size(157, 23);
            codigo.TabIndex = 0;
            // 
            // CboCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 508);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CboCreate";
            Text = "CboCreate";
            Load += CboCreate_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button ButtonBack;
        private Button ButtonSave;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox descricao;
        private Label label1;
        private TextBox codigo;
        private CheckBox motoristaProfissional;
        private CheckBox salarioAula;
    }
}