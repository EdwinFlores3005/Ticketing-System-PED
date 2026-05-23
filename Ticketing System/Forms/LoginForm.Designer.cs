namespace Ticketing_System.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginBtn = new Button();
            loginLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            loginIcon = new Button();
            showPassword = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkSlateGray;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(80, 292);
            loginBtn.Margin = new Padding(0, 15, 0, 0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(235, 42);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "ACCESO";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Dock = DockStyle.Fill;
            loginLbl.FlatStyle = FlatStyle.Flat;
            loginLbl.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLbl.ForeColor = Color.Black;
            loginLbl.Location = new Point(83, 84);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(235, 38);
            loginLbl.TabIndex = 3;
            loginLbl.Text = "Iniciar Sesión";
            loginLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(loginLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(emailTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(loginBtn, 1, 6);
            tableLayoutPanel1.Controls.Add(passwordTxt, 1, 4);
            tableLayoutPanel1.Controls.Add(loginIcon, 1, 0);
            tableLayoutPanel1.Controls.Add(showPassword, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 420);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.Size = new Size(402, 420);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.White;
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Dock = DockStyle.Fill;
            emailTxt.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(80, 151);
            emailTxt.Margin = new Padding(0, 8, 0, 8);
            emailTxt.MinimumSize = new Size(0, 38);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Email";
            emailTxt.Size = new Size(241, 38);
            emailTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.White;
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Dock = DockStyle.Fill;
            passwordTxt.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(80, 205);
            passwordTxt.Margin = new Padding(0, 8, 0, 8);
            passwordTxt.MinimumSize = new Size(0, 38);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Contraseña";
            passwordTxt.Size = new Size(241, 38);
            passwordTxt.TabIndex = 1;
            passwordTxt.UseSystemPasswordChar = true;
            passwordTxt.KeyDown += passwordTxt_KeyDown;
            // 
            // loginIcon
            // 
            loginIcon.Anchor = AnchorStyles.None;
            loginIcon.BackColor = Color.Transparent;
            loginIcon.Enabled = false;
            loginIcon.FlatAppearance.BorderSize = 0;
            loginIcon.FlatStyle = FlatStyle.Flat;
            loginIcon.Image = Properties.Resources.cuentaImg;
            loginIcon.Location = new Point(126, 3);
            loginIcon.Name = "loginIcon";
            loginIcon.Size = new Size(149, 77);
            loginIcon.TabIndex = 4;
            loginIcon.UseVisualStyleBackColor = false;
            // 
            // showPassword
            // 
            showPassword.Anchor = AnchorStyles.None;
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassword.Location = new Point(114, 254);
            showPassword.MaximumSize = new Size(0, 20);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(172, 20);
            showPassword.TabIndex = 5;
            showPassword.Text = "Mostrar Contraseña";
            showPassword.TextAlign = ContentAlignment.MiddleCenter;
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += checkbox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 411);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button loginBtn;
        private Label loginLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox passwordTxt;
        private TextBox emailTxt;
        private Button loginIcon;
        private CheckBox showPassword;
    }
}