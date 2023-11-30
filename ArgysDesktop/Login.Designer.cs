namespace ArgysDesktop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            textEmail = new TextBox();
            textPassword = new TextBox();
            ButtonLogin = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(110, 167);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 222);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.Location = new Point(110, 185);
            textEmail.MaximumSize = new Size(354, 23);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(354, 23);
            textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textPassword.Location = new Point(110, 240);
            textPassword.MaximumSize = new Size(354, 23);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(354, 23);
            textPassword.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(175, 287);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(230, 23);
            ButtonLogin.TabIndex = 4;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(175, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Location = new Point(107, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 387);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textEmail;
        private TextBox textPassword;
        private Button ButtonLogin;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}