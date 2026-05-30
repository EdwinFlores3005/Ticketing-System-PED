namespace Ticketing_System.User_Control
{
    partial class DashboardControl
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
            welcomePanel = new TableLayoutPanel();
            welcomeLbl = new Label();
            ticketsViewPanel = new TableLayoutPanel();
            assignedTxt = new RichTextBox();
            criticalTxt = new RichTextBox();
            openTxt = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            assignedticketsPanel = new FlowLayoutPanel();
            allticketsPanel = new FlowLayoutPanel();
            recentLbl = new Label();
            assignedLbl = new Label();
            welcomePanel.SuspendLayout();
            ticketsViewPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomePanel
            // 
            welcomePanel.ColumnCount = 3;
            welcomePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            welcomePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            welcomePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            welcomePanel.Controls.Add(welcomeLbl, 0, 1);
            welcomePanel.Dock = DockStyle.Top;
            welcomePanel.Location = new Point(0, 0);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Padding = new Padding(3);
            welcomePanel.RowCount = 2;
            welcomePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            welcomePanel.RowStyles.Add(new RowStyle());
            welcomePanel.Size = new Size(1528, 125);
            welcomePanel.TabIndex = 0;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Dock = DockStyle.Fill;
            welcomeLbl.FlatStyle = FlatStyle.Flat;
            welcomeLbl.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.ForeColor = Color.DarkSlateGray;
            welcomeLbl.Location = new Point(6, 72);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(501, 50);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "#";
            welcomeLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ticketsViewPanel
            // 
            ticketsViewPanel.ColumnCount = 1;
            ticketsViewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ticketsViewPanel.Controls.Add(assignedTxt, 0, 5);
            ticketsViewPanel.Controls.Add(criticalTxt, 0, 3);
            ticketsViewPanel.Controls.Add(openTxt, 0, 1);
            ticketsViewPanel.Dock = DockStyle.Top;
            ticketsViewPanel.Location = new Point(0, 125);
            ticketsViewPanel.Name = "ticketsViewPanel";
            ticketsViewPanel.Padding = new Padding(3);
            ticketsViewPanel.RowCount = 6;
            ticketsViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ticketsViewPanel.RowStyles.Add(new RowStyle());
            ticketsViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ticketsViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ticketsViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ticketsViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ticketsViewPanel.Size = new Size(1528, 275);
            ticketsViewPanel.TabIndex = 1;
            // 
            // assignedTxt
            // 
            assignedTxt.BackColor = Color.White;
            assignedTxt.BorderStyle = BorderStyle.None;
            assignedTxt.Dock = DockStyle.Fill;
            assignedTxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignedTxt.Location = new Point(6, 219);
            assignedTxt.Name = "assignedTxt";
            assignedTxt.ReadOnly = true;
            assignedTxt.Size = new Size(1516, 50);
            assignedTxt.TabIndex = 6;
            assignedTxt.Text = "";
            // 
            // criticalTxt
            // 
            criticalTxt.BackColor = Color.White;
            criticalTxt.BorderStyle = BorderStyle.None;
            criticalTxt.Dock = DockStyle.Fill;
            criticalTxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criticalTxt.Location = new Point(6, 130);
            criticalTxt.Name = "criticalTxt";
            criticalTxt.ReadOnly = true;
            criticalTxt.Size = new Size(1516, 48);
            criticalTxt.TabIndex = 5;
            criticalTxt.Text = "";
            // 
            // openTxt
            // 
            openTxt.BackColor = Color.White;
            openTxt.BorderStyle = BorderStyle.None;
            openTxt.Dock = DockStyle.Fill;
            openTxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openTxt.Location = new Point(6, 42);
            openTxt.Name = "openTxt";
            openTxt.ReadOnly = true;
            openTxt.Size = new Size(1516, 47);
            openTxt.TabIndex = 4;
            openTxt.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(assignedLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(recentLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(assignedticketsPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(allticketsPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 400);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1528, 440);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // assignedticketsPanel
            // 
            assignedticketsPanel.Dock = DockStyle.Fill;
            assignedticketsPanel.FlowDirection = FlowDirection.TopDown;
            assignedticketsPanel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignedticketsPanel.Location = new Point(767, 43);
            assignedticketsPanel.Name = "assignedticketsPanel";
            assignedticketsPanel.Size = new Size(755, 428);
            assignedticketsPanel.TabIndex = 3;
            // 
            // allticketsPanel
            // 
            allticketsPanel.Dock = DockStyle.Fill;
            allticketsPanel.FlowDirection = FlowDirection.TopDown;
            allticketsPanel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allticketsPanel.Location = new Point(6, 43);
            allticketsPanel.Name = "allticketsPanel";
            allticketsPanel.Size = new Size(755, 428);
            allticketsPanel.TabIndex = 2;
            // 
            // recentLbl
            // 
            recentLbl.AutoSize = true;
            recentLbl.Dock = DockStyle.Fill;
            recentLbl.FlatStyle = FlatStyle.Flat;
            recentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recentLbl.ForeColor = Color.DarkSlateGray;
            recentLbl.Location = new Point(6, 3);
            recentLbl.Name = "recentLbl";
            recentLbl.Padding = new Padding(3);
            recentLbl.Size = new Size(755, 37);
            recentLbl.TabIndex = 4;
            recentLbl.Text = "Tickets Recientes";
            recentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // assignedLbl
            // 
            assignedLbl.AutoSize = true;
            assignedLbl.Dock = DockStyle.Fill;
            assignedLbl.FlatStyle = FlatStyle.Flat;
            assignedLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignedLbl.ForeColor = Color.DarkSlateGray;
            assignedLbl.Location = new Point(767, 3);
            assignedLbl.Name = "assignedLbl";
            assignedLbl.Padding = new Padding(3);
            assignedLbl.Size = new Size(755, 37);
            assignedLbl.TabIndex = 5;
            assignedLbl.Text = "Tickets Recientes Asignados";
            assignedLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ticketsViewPanel);
            Controls.Add(welcomePanel);
            Name = "DashboardControl";
            Size = new Size(1528, 840);
            Load += DashboardControl_Load;
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            ticketsViewPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel welcomePanel;
        private Label welcomeLbl;
        private TableLayoutPanel ticketsViewPanel;
        private RichTextBox openTxt;
        private RichTextBox assignedTxt;
        private RichTextBox criticalTxt;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel allticketsPanel;
        private FlowLayoutPanel assignedticketsPanel;
        private Label assignedLbl;
        private Label recentLbl;
    }
}
