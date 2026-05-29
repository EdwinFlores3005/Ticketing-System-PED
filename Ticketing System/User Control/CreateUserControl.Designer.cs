namespace Ticketing_System.User_Control
{
    partial class CreateUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newTicketPanel = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            newUserLbl = new Label();
            titleLbl = new Label();
            nameTxtBox = new TextBox();
            label1 = new Label();
            emailTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            RoleBox = new ComboBox();
            createUserBtn = new Button();
            newTicketPanel.SuspendLayout();
            SuspendLayout();
            // 
            // newTicketPanel
            // 
            newTicketPanel.ColumnCount = 3;
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94F));
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            newTicketPanel.Controls.Add(RoleBox, 1, 9);
            newTicketPanel.Controls.Add(label3, 1, 8);
            newTicketPanel.Controls.Add(label2, 1, 6);
            newTicketPanel.Controls.Add(newUserLbl, 1, 0);
            newTicketPanel.Controls.Add(titleLbl, 1, 1);
            newTicketPanel.Controls.Add(nameTxtBox, 1, 2);
            newTicketPanel.Controls.Add(label1, 1, 4);
            newTicketPanel.Controls.Add(emailTxtBox, 1, 5);
            newTicketPanel.Controls.Add(passwordTxtBox, 1, 7);
            newTicketPanel.Location = new Point(224, 32);
            newTicketPanel.Margin = new Padding(5);
            newTicketPanel.Name = "newTicketPanel";
            newTicketPanel.Padding = new Padding(5);
            newTicketPanel.RowCount = 10;
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            newTicketPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            newTicketPanel.Size = new Size(1080, 312);
            newTicketPanel.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 228);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(999, 29);
            label3.TabIndex = 14;
            label3.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 165);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(999, 29);
            label2.TabIndex = 13;
            label2.Text = "Contraseña";
            // 
            // newUserLbl
            // 
            newUserLbl.AutoSize = true;
            newUserLbl.BackColor = Color.White;
            newUserLbl.Dock = DockStyle.Fill;
            newUserLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newUserLbl.ForeColor = Color.DarkSlateGray;
            newUserLbl.Location = new Point(40, 5);
            newUserLbl.Name = "newUserLbl";
            newUserLbl.Size = new Size(999, 31);
            newUserLbl.TabIndex = 0;
            newUserLbl.Text = "Crear Nuevo Usuario";
            newUserLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(40, 36);
            titleLbl.Name = "titleLbl";
            titleLbl.Padding = new Padding(3);
            titleLbl.Size = new Size(999, 29);
            titleLbl.TabIndex = 2;
            titleLbl.Text = "Nombre";
            // 
            // nameTxtBox
            // 
            nameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            nameTxtBox.Cursor = Cursors.IBeam;
            nameTxtBox.Dock = DockStyle.Fill;
            nameTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxtBox.Location = new Point(40, 68);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(999, 31);
            nameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 102);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(999, 29);
            label1.TabIndex = 12;
            label1.Text = "Correo Electrónico";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Cursor = Cursors.IBeam;
            emailTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxtBox.Location = new Point(40, 134);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(999, 28);
            emailTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Cursor = Cursors.IBeam;
            passwordTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.Location = new Point(40, 197);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(999, 28);
            passwordTxtBox.TabIndex = 15;
            // 
            // statusBox
            // 
            RoleBox.Dock = DockStyle.Left;
            RoleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleBox.FlatStyle = FlatStyle.Flat;
            RoleBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleBox.FormattingEnabled = true;
            RoleBox.Items.AddRange(new object[] { "Cliente", "Tecnico", "Admin" });
            RoleBox.Location = new Point(40, 260);
            RoleBox.Name = "statusBox";
            RoleBox.Size = new Size(136, 31);
            RoleBox.TabIndex = 4;
            // 
            // createUserBtn
            // 
            createUserBtn.AutoSize = true;
            createUserBtn.BackColor = Color.DarkSlateGray;
            createUserBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            createUserBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            createUserBtn.FlatStyle = FlatStyle.Flat;
            createUserBtn.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserBtn.ForeColor = Color.White;
            createUserBtn.Location = new Point(691, 400);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Padding = new Padding(3);
            createUserBtn.Size = new Size(160, 41);
            createUserBtn.TabIndex = 13;
            createUserBtn.Text = "CREAR USUARIO";
            createUserBtn.UseVisualStyleBackColor = false;
            createUserBtn.Click += this.createUserBtn_Click;
            // 
            // CreateUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(createUserBtn);
            Controls.Add(newTicketPanel);
            Name = "CreateUserControl";
            Size = new Size(1528, 840);
            newTicketPanel.ResumeLayout(false);
            newTicketPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel newTicketPanel;
        private Label label3;
        private Label label2;
        private Label newUserLbl;
        private Label titleLbl;
        private TextBox nameTxtBox;
        private Label label1;
        private TextBox emailTxtBox;
        private TextBox passwordTxtBox;
        private ComboBox RoleBox;
        private Button createUserBtn;
    }
}
