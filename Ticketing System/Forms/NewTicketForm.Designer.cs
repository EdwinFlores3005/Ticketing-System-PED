namespace Ticketing_System
{
    partial class NewTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTicketForm));
            emailTxtBox = new TextBox();
            titleLbl = new Label();
            titleTxtBox = new TextBox();
            prioBox = new ComboBox();
            button1 = new Button();
            descTxtBox = new TextBox();
            createBtn = new Button();
            cancelBtn = new Button();
            newTicketPanel = new TableLayoutPanel();
            statusBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            nameFormLbl = new Label();
            label1 = new Label();
            descriptionLbl = new Label();
            newTicketPanel.SuspendLayout();
            SuspendLayout();
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
            titleLbl.Text = "Título";
            // 
            // titleTxtBox
            // 
            titleTxtBox.BorderStyle = BorderStyle.FixedSingle;
            titleTxtBox.Cursor = Cursors.IBeam;
            titleTxtBox.Dock = DockStyle.Fill;
            titleTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxtBox.Location = new Point(40, 68);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(999, 31);
            titleTxtBox.TabIndex = 1;
            // 
            // prioBox
            // 
            prioBox.Dock = DockStyle.Left;
            prioBox.DropDownStyle = ComboBoxStyle.DropDownList;
            prioBox.FlatStyle = FlatStyle.Flat;
            prioBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prioBox.FormattingEnabled = true;
            prioBox.Items.AddRange(new object[] { "Crítico", "Alta", "Media", "Baja" });
            prioBox.Location = new Point(40, 197);
            prioBox.Name = "prioBox";
            prioBox.Size = new Size(136, 31);
            prioBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(701, 114);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // descTxtBox
            // 
            descTxtBox.Dock = DockStyle.Fill;
            descTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descTxtBox.Location = new Point(40, 329);
            descTxtBox.Multiline = true;
            descTxtBox.Name = "descTxtBox";
            descTxtBox.PlaceholderText = "Agregar nota...";
            descTxtBox.ScrollBars = ScrollBars.Vertical;
            descTxtBox.Size = new Size(999, 439);
            descTxtBox.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.AutoSize = true;
            createBtn.BackColor = Color.DarkSlateGray;
            createBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            createBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(376, 816);
            createBtn.Name = "createBtn";
            createBtn.Padding = new Padding(3);
            createBtn.Size = new Size(146, 41);
            createBtn.TabIndex = 6;
            createBtn.Text = "CREAR TICKET";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(528, 816);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(3);
            cancelBtn.Size = new Size(115, 41);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "CANCELAR";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // newTicketPanel
            // 
            newTicketPanel.ColumnCount = 3;
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94F));
            newTicketPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            newTicketPanel.Controls.Add(statusBox, 1, 9);
            newTicketPanel.Controls.Add(label3, 1, 8);
            newTicketPanel.Controls.Add(prioBox, 1, 7);
            newTicketPanel.Controls.Add(descTxtBox, 1, 11);
            newTicketPanel.Controls.Add(label2, 1, 6);
            newTicketPanel.Controls.Add(nameFormLbl, 1, 0);
            newTicketPanel.Controls.Add(titleLbl, 1, 1);
            newTicketPanel.Controls.Add(titleTxtBox, 1, 2);
            newTicketPanel.Controls.Add(label1, 1, 4);
            newTicketPanel.Controls.Add(emailTxtBox, 1, 5);
            newTicketPanel.Controls.Add(descriptionLbl, 1, 10);
            newTicketPanel.Location = new Point(0, 0);
            newTicketPanel.Margin = new Padding(5);
            newTicketPanel.Name = "newTicketPanel";
            newTicketPanel.Padding = new Padding(5);
            newTicketPanel.RowCount = 12;
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
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle());
            newTicketPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            newTicketPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            newTicketPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            newTicketPanel.Size = new Size(1080, 776);
            newTicketPanel.TabIndex = 11;
            // 
            // statusBox
            // 
            statusBox.Dock = DockStyle.Left;
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.FlatStyle = FlatStyle.Flat;
            statusBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "New", "Open", "Pending", "On Hold", "Closed" });
            statusBox.Location = new Point(40, 263);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(136, 31);
            statusBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 231);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(999, 29);
            label3.TabIndex = 14;
            label3.Text = "Estado";
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
            label2.Text = "Prioridad";
            // 
            // nameFormLbl
            // 
            nameFormLbl.AutoSize = true;
            nameFormLbl.BackColor = Color.White;
            nameFormLbl.Dock = DockStyle.Fill;
            nameFormLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameFormLbl.ForeColor = Color.DarkSlateGray;
            nameFormLbl.Location = new Point(40, 5);
            nameFormLbl.Name = "nameFormLbl";
            nameFormLbl.Size = new Size(999, 31);
            nameFormLbl.TabIndex = 0;
            nameFormLbl.Text = "Crear Ticket de Soporte";
            nameFormLbl.TextAlign = ContentAlignment.MiddleCenter;
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
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Dock = DockStyle.Fill;
            descriptionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLbl.Location = new Point(40, 297);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Padding = new Padding(3);
            descriptionLbl.Size = new Size(999, 29);
            descriptionLbl.TabIndex = 14;
            descriptionLbl.Text = "Descripción";
            // 
            // NewTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1082, 873);
            Controls.Add(newTicketPanel);
            Controls.Add(cancelBtn);
            Controls.Add(button1);
            Controls.Add(createBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Ticket";
            newTicketPanel.ResumeLayout(false);
            newTicketPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox emailTxtBox;
        private Label titleLbl;
        private TextBox titleTxtBox;
        private ComboBox prioBox;
        private Button button1;
        private TextBox descTxtBox;
        private Button createBtn;
        private Button cancelBtn;
        private TableLayoutPanel newTicketPanel;
        private Label nameFormLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox statusBox;
        private Label descriptionLbl;
    }
}