namespace Ticketing_System
{
    partial class TicketDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketDetailForm));
            sideLayoutPanel = new TableLayoutPanel();
            ticketIdTxt = new Label();
            userLbl = new Label();
            agentLbl = new Label();
            stateLbl = new Label();
            prioLbl = new Label();
            emailTxt = new Label();
            agentTxt = new Label();
            stateBox = new ComboBox();
            prioBox = new ComboBox();
            usernameTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleLbl = new Label();
            ticketStatusLbl = new Label();
            initialNoteTxt = new TextBox();
            Actualizar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            notesTxt = new TextBox();
            historyFlowPanel = new FlowLayoutPanel();
            sideLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // sideLayoutPanel
            // 
            sideLayoutPanel.BackColor = Color.DarkSlateGray;
            sideLayoutPanel.ColumnCount = 3;
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            sideLayoutPanel.Controls.Add(ticketIdTxt, 1, 0);
            sideLayoutPanel.Controls.Add(userLbl, 1, 1);
            sideLayoutPanel.Controls.Add(agentLbl, 1, 5);
            sideLayoutPanel.Controls.Add(stateLbl, 1, 7);
            sideLayoutPanel.Controls.Add(prioLbl, 1, 9);
            sideLayoutPanel.Controls.Add(emailTxt, 1, 4);
            sideLayoutPanel.Controls.Add(agentTxt, 1, 6);
            sideLayoutPanel.Controls.Add(stateBox, 1, 8);
            sideLayoutPanel.Controls.Add(prioBox, 1, 10);
            sideLayoutPanel.Controls.Add(usernameTxt, 1, 2);
            sideLayoutPanel.Dock = DockStyle.Left;
            sideLayoutPanel.Location = new Point(0, 0);
            sideLayoutPanel.Name = "sideLayoutPanel";
            sideLayoutPanel.RowCount = 11;
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.RowStyles.Add(new RowStyle());
            sideLayoutPanel.Size = new Size(232, 720);
            sideLayoutPanel.TabIndex = 1;
            // 
            // ticketIdTxt
            // 
            ticketIdTxt.AutoSize = true;
            ticketIdTxt.Dock = DockStyle.Fill;
            ticketIdTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketIdTxt.ForeColor = Color.White;
            ticketIdTxt.Location = new Point(9, 0);
            ticketIdTxt.Name = "ticketIdTxt";
            ticketIdTxt.Padding = new Padding(3);
            ticketIdTxt.Size = new Size(216, 31);
            ticketIdTxt.TabIndex = 7;
            ticketIdTxt.Text = "Ticket #";
            ticketIdTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Dock = DockStyle.Fill;
            userLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLbl.ForeColor = Color.White;
            userLbl.Location = new Point(9, 31);
            userLbl.Name = "userLbl";
            userLbl.Padding = new Padding(3);
            userLbl.Size = new Size(216, 31);
            userLbl.TabIndex = 1;
            userLbl.Text = "Usuario";
            userLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agentLbl
            // 
            agentLbl.AutoSize = true;
            agentLbl.Dock = DockStyle.Fill;
            agentLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agentLbl.ForeColor = Color.White;
            agentLbl.Location = new Point(9, 124);
            agentLbl.Name = "agentLbl";
            agentLbl.Padding = new Padding(3);
            agentLbl.Size = new Size(216, 31);
            agentLbl.TabIndex = 2;
            agentLbl.Text = "Agente";
            agentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stateLbl
            // 
            stateLbl.AutoSize = true;
            stateLbl.Dock = DockStyle.Fill;
            stateLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateLbl.ForeColor = Color.White;
            stateLbl.Location = new Point(9, 186);
            stateLbl.Name = "stateLbl";
            stateLbl.Padding = new Padding(3);
            stateLbl.Size = new Size(216, 31);
            stateLbl.TabIndex = 3;
            stateLbl.Text = "Estado";
            stateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prioLbl
            // 
            prioLbl.AutoSize = true;
            prioLbl.Dock = DockStyle.Fill;
            prioLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prioLbl.ForeColor = Color.White;
            prioLbl.Location = new Point(9, 251);
            prioLbl.Name = "prioLbl";
            prioLbl.Padding = new Padding(3);
            prioLbl.Size = new Size(216, 31);
            prioLbl.TabIndex = 4;
            prioLbl.Text = "Prioridad";
            prioLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Dock = DockStyle.Fill;
            emailTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.White;
            emailTxt.Location = new Point(9, 93);
            emailTxt.Name = "emailTxt";
            emailTxt.Padding = new Padding(3);
            emailTxt.Size = new Size(216, 31);
            emailTxt.TabIndex = 5;
            emailTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agentTxt
            // 
            agentTxt.AutoSize = true;
            agentTxt.Dock = DockStyle.Fill;
            agentTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agentTxt.ForeColor = Color.White;
            agentTxt.Location = new Point(9, 155);
            agentTxt.Name = "agentTxt";
            agentTxt.Padding = new Padding(3);
            agentTxt.Size = new Size(216, 31);
            agentTxt.TabIndex = 6;
            agentTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stateBox
            // 
            stateBox.BackColor = SystemColors.Window;
            stateBox.Dock = DockStyle.Fill;
            stateBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateBox.FlatStyle = FlatStyle.Flat;
            stateBox.FormattingEnabled = true;
            stateBox.Items.AddRange(new object[] { "New", "Open", "Pending", "On Hold", "Closed" });
            stateBox.Location = new Point(9, 220);
            stateBox.Name = "stateBox";
            stateBox.Size = new Size(216, 28);
            stateBox.TabIndex = 7;
            // 
            // prioBox
            // 
            prioBox.BackColor = SystemColors.Window;
            prioBox.Dock = DockStyle.Fill;
            prioBox.DropDownStyle = ComboBoxStyle.DropDownList;
            prioBox.FlatStyle = FlatStyle.Flat;
            prioBox.FormattingEnabled = true;
            prioBox.Items.AddRange(new object[] { "Critico", "Alta", "Media", "Baja" });
            prioBox.Location = new Point(9, 285);
            prioBox.Name = "prioBox";
            prioBox.Size = new Size(216, 28);
            prioBox.TabIndex = 8;
            // 
            // usernameTxt
            // 
            usernameTxt.AutoSize = true;
            usernameTxt.Dock = DockStyle.Fill;
            usernameTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.White;
            usernameTxt.Location = new Point(9, 62);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Padding = new Padding(3);
            usernameTxt.Size = new Size(216, 31);
            usernameTxt.TabIndex = 9;
            usernameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.Controls.Add(titleLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(ticketStatusLbl, 1, 1);
            tableLayoutPanel1.Location = new Point(232, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1028, 64);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(16, 3);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(995, 29);
            titleLbl.TabIndex = 2;
            titleLbl.Text = "Title";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ticketStatusLbl
            // 
            ticketStatusLbl.AutoSize = true;
            ticketStatusLbl.Dock = DockStyle.Fill;
            ticketStatusLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketStatusLbl.Location = new Point(16, 32);
            ticketStatusLbl.Name = "ticketStatusLbl";
            ticketStatusLbl.Size = new Size(995, 29);
            ticketStatusLbl.TabIndex = 1;
            ticketStatusLbl.Text = "Ticket - Status";
            ticketStatusLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // initialNoteTxt
            // 
            initialNoteTxt.BackColor = Color.White;
            initialNoteTxt.BorderStyle = BorderStyle.None;
            initialNoteTxt.Dock = DockStyle.Fill;
            initialNoteTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialNoteTxt.Location = new Point(16, 6);
            initialNoteTxt.Multiline = true;
            initialNoteTxt.Name = "initialNoteTxt";
            initialNoteTxt.ReadOnly = true;
            initialNoteTxt.Size = new Size(999, 159);
            initialNoteTxt.TabIndex = 2;
            initialNoteTxt.Text = "Initial Description";
            // 
            // Actualizar
            // 
            Actualizar.BackColor = Color.DarkSlateGray;
            Actualizar.FlatStyle = FlatStyle.Flat;
            Actualizar.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actualizar.ForeColor = Color.White;
            Actualizar.Location = new Point(1112, 672);
            Actualizar.Name = "Actualizar";
            Actualizar.Padding = new Padding(3);
            Actualizar.Size = new Size(136, 37);
            Actualizar.TabIndex = 7;
            Actualizar.Text = "ACTUALIZAR";
            Actualizar.UseVisualStyleBackColor = false;
            Actualizar.Click += Actualizar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel2.Controls.Add(initialNoteTxt, 1, 0);
            tableLayoutPanel2.Controls.Add(notesTxt, 1, 2);
            tableLayoutPanel2.Controls.Add(historyFlowPanel, 1, 1);
            tableLayoutPanel2.Location = new Point(232, 72);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.77778F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.Size = new Size(1032, 600);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // notesTxt
            // 
            notesTxt.BackColor = Color.White;
            notesTxt.BorderStyle = BorderStyle.None;
            notesTxt.Dock = DockStyle.Fill;
            notesTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notesTxt.Location = new Point(16, 468);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.PlaceholderText = "Agregar nota...";
            notesTxt.Size = new Size(999, 126);
            notesTxt.TabIndex = 4;
            // 
            // historyFlowPanel
            // 
            historyFlowPanel.AutoScroll = true;
            historyFlowPanel.Dock = DockStyle.Fill;
            historyFlowPanel.FlowDirection = FlowDirection.TopDown;
            historyFlowPanel.Location = new Point(16, 171);
            historyFlowPanel.Name = "historyFlowPanel";
            historyFlowPanel.Size = new Size(999, 291);
            historyFlowPanel.TabIndex = 5;
            historyFlowPanel.WrapContents = false;
            // 
            // TicketDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 720);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(Actualizar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sideLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            TopMost = true;
            sideLayoutPanel.ResumeLayout(false);
            sideLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel sideLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label agentLbl;
        private Label stateLbl;
        private Label emailTxt;
        private Label ticketStatusLbl;
        private TextBox initialNoteTxt;
        private Label prioLbl;
        private Label agentTxt;
        private ComboBox stateBox;
        private Label userLbl;
        private ComboBox prioBox;
        private Label usernameTxt;
        private Label ticketIdTxt;
        private Label titleLbl;
        private Button Actualizar;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox notesTxt;
        private FlowLayoutPanel historyFlowPanel;
    }
}