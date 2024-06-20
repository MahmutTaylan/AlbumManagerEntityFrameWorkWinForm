namespace PL
{
    partial class ManagerLoginScreen
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonClose = new Button();
            buttonCreateNewManager = new Button();
            checkBoxShowPassword = new CheckBox();
            buttonLogin = new Button();
            linkLabelCreateAccount = new LinkLabel();
            labelYoneticiGirisiText = new Label();
            labelPasswordText = new Label();
            labelEmailText = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonCreateNewManager);
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(linkLabelCreateAccount);
            panel1.Controls.Add(labelYoneticiGirisiText);
            panel1.Controls.Add(labelPasswordText);
            panel1.Controls.Add(labelEmailText);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 477);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 35);
            panel2.TabIndex = 18;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(488, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(43, 35);
            buttonClose.TabIndex = 19;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click_1;
            // 
            // buttonCreateNewManager
            // 
            buttonCreateNewManager.BackColor = Color.IndianRed;
            buttonCreateNewManager.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCreateNewManager.Location = new Point(252, 436);
            buttonCreateNewManager.Name = "buttonCreateNewManager";
            buttonCreateNewManager.Size = new Size(145, 28);
            buttonCreateNewManager.TabIndex = 17;
            buttonCreateNewManager.Text = "Yönetici Oluştur";
            buttonCreateNewManager.UseVisualStyleBackColor = false;
            buttonCreateNewManager.Click += buttonCreateNewManager_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxShowPassword.Location = new Point(440, 298);
            checkBoxShowPassword.Margin = new Padding(2);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(79, 26);
            checkBoxShowPassword.TabIndex = 15;
            checkBoxShowPassword.Text = "Göster";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(221, 356);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(212, 44);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "GİRİŞ";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabelCreateAccount.Location = new Point(268, 424);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(0, 22);
            linkLabelCreateAccount.TabIndex = 5;
            // 
            // labelYoneticiGirisiText
            // 
            labelYoneticiGirisiText.AutoSize = true;
            labelYoneticiGirisiText.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelYoneticiGirisiText.ForeColor = Color.Black;
            labelYoneticiGirisiText.Location = new Point(112, 80);
            labelYoneticiGirisiText.Name = "labelYoneticiGirisiText";
            labelYoneticiGirisiText.Size = new Size(321, 62);
            labelYoneticiGirisiText.TabIndex = 4;
            labelYoneticiGirisiText.Text = "Yönetici Girişi";
            // 
            // labelPasswordText
            // 
            labelPasswordText.AutoSize = true;
            labelPasswordText.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            labelPasswordText.Location = new Point(26, 276);
            labelPasswordText.Name = "labelPasswordText";
            labelPasswordText.Size = new Size(121, 48);
            labelPasswordText.TabIndex = 3;
            labelPasswordText.Text = "Şifre:";
            // 
            // labelEmailText
            // 
            labelEmailText.AutoSize = true;
            labelEmailText.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEmailText.Location = new Point(26, 196);
            labelEmailText.Name = "labelEmailText";
            labelEmailText.Size = new Size(145, 48);
            labelEmailText.TabIndex = 2;
            labelEmailText.Text = "E-Mail:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(221, 294);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(212, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(221, 214);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(212, 27);
            textBoxEmail.TabIndex = 0;
            // 
            // ManagerLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 478);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerLoginScreen";
            Load += ManagerLoginScreen_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private LinkLabel linkLabelCreateAccount;
        private Label labelYoneticiGirisiText;
        private Label labelPasswordText;
        private Label labelEmailText;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Button buttonCreateNewManager;
        private Panel panel2;
        private Button buttonClose;
    }
}
