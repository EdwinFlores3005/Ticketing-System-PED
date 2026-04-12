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
            userLbl = new Label();
            agentLbl = new Label();
            stateLbl = new Label();
            prioLbl = new Label();
            emailTxt = new Label();
            agentTxt = new Label();
            stateBox = new ComboBox();
            prioBox = new ComboBox();
            userTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ticketNumLabel = new Label();
            titleLbl = new Label();
            notesBox = new TextBox();
            sideLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // sideLayoutPanel
            // 
            sideLayoutPanel.ColumnCount = 3;
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            sideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.5F));
            sideLayoutPanel.Controls.Add(userLbl, 1, 1);
            sideLayoutPanel.Controls.Add(agentLbl, 1, 6);
            sideLayoutPanel.Controls.Add(stateLbl, 1, 9);
            sideLayoutPanel.Controls.Add(prioLbl, 1, 12);
            sideLayoutPanel.Controls.Add(emailTxt, 1, 4);
            sideLayoutPanel.Controls.Add(agentTxt, 1, 7);
            sideLayoutPanel.Controls.Add(stateBox, 1, 10);
            sideLayoutPanel.Controls.Add(prioBox, 1, 13);
            sideLayoutPanel.Controls.Add(userTxt, 1, 2);
            sideLayoutPanel.Dock = DockStyle.Left;
            sideLayoutPanel.Location = new Point(0, 0);
            sideLayoutPanel.Name = "sideLayoutPanel";
            sideLayoutPanel.RowCount = 15;
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.125F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.125F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            sideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            sideLayoutPanel.Size = new Size(232, 720);
            sideLayoutPanel.TabIndex = 1;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Dock = DockStyle.Fill;
            userLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLbl.Location = new Point(8, 216);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(216, 45);
            userLbl.TabIndex = 1;
            userLbl.Text = "Usuario";
            userLbl.TextAlign = ContentAlignment.MiddleCenter;
            userLbl.Click += label1_Click_2;
            // 
            // agentLbl
            // 
            agentLbl.AutoSize = true;
            agentLbl.Dock = DockStyle.Fill;
            agentLbl.Font = new Font("Tahoma", 11F);
            agentLbl.Location = new Point(8, 340);
            agentLbl.Name = "agentLbl";
            agentLbl.Size = new Size(216, 45);
            agentLbl.TabIndex = 2;
            agentLbl.Text = "Agente";
            agentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stateLbl
            // 
            stateLbl.AutoSize = true;
            stateLbl.Dock = DockStyle.Fill;
            stateLbl.Font = new Font("Tahoma", 11F);
            stateLbl.Location = new Point(8, 466);
            stateLbl.Name = "stateLbl";
            stateLbl.Size = new Size(216, 45);
            stateLbl.TabIndex = 3;
            stateLbl.Text = "Estado";
            stateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prioLbl
            // 
            prioLbl.AutoSize = true;
            prioLbl.Dock = DockStyle.Fill;
            prioLbl.Font = new Font("Tahoma", 11F);
            prioLbl.Location = new Point(8, 592);
            prioLbl.Name = "prioLbl";
            prioLbl.Size = new Size(216, 45);
            prioLbl.TabIndex = 4;
            prioLbl.Text = "Prioridad";
            prioLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Dock = DockStyle.Fill;
            emailTxt.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(8, 290);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(216, 22);
            emailTxt.TabIndex = 5;
            emailTxt.Text = "#";
            emailTxt.TextAlign = ContentAlignment.MiddleCenter;
            emailTxt.Click += label1_Click_3;
            // 
            // agentTxt
            // 
            agentTxt.AutoSize = true;
            agentTxt.Dock = DockStyle.Fill;
            agentTxt.Font = new Font("Tahoma", 11F);
            agentTxt.Location = new Point(8, 385);
            agentTxt.Name = "agentTxt";
            agentTxt.Size = new Size(216, 45);
            agentTxt.TabIndex = 6;
            agentTxt.Text = "#";
            agentTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stateBox
            // 
            stateBox.Dock = DockStyle.Fill;
            stateBox.FormattingEnabled = true;
            stateBox.Location = new Point(8, 514);
            stateBox.Name = "stateBox";
            stateBox.Size = new Size(216, 28);
            stateBox.TabIndex = 7;
            // 
            // prioBox
            // 
            prioBox.Dock = DockStyle.Fill;
            prioBox.FormattingEnabled = true;
            prioBox.Location = new Point(8, 640);
            prioBox.Name = "prioBox";
            prioBox.Size = new Size(216, 28);
            prioBox.TabIndex = 8;
            // 
            // userTxt
            // 
            userTxt.AutoSize = true;
            userTxt.Dock = DockStyle.Fill;
            userTxt.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(8, 261);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(216, 22);
            userTxt.TabIndex = 9;
            userTxt.Text = "#";
            userTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Controls.Add(ticketNumLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(titleLbl, 1, 3);
            tableLayoutPanel1.Controls.Add(notesBox, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(232, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1028, 720);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ticketNumLabel
            // 
            ticketNumLabel.AutoSize = true;
            ticketNumLabel.Dock = DockStyle.Fill;
            ticketNumLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketNumLabel.Location = new Point(28, 36);
            ticketNumLabel.Name = "ticketNumLabel";
            ticketNumLabel.Size = new Size(970, 72);
            ticketNumLabel.TabIndex = 0;
            ticketNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            ticketNumLabel.Click += label1_Click_1;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(28, 144);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(970, 72);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "#";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notesBox
            // 
            notesBox.Dock = DockStyle.Fill;
            notesBox.Location = new Point(28, 345);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(970, 336);
            notesBox.TabIndex = 2;
            // 
            // TicketDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 720);
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
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel sideLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ticketNumLabel;
        private Label userLbl;
        private Label agentLbl;
        private Label stateLbl;
        private Label prioLbl;
        private Label emailTxt;
        private Label agentTxt;
        private ComboBox stateBox;
        private ComboBox prioBox;
        private Label titleLbl;
        private TextBox notesBox;
        private Label userTxt;
    }
}