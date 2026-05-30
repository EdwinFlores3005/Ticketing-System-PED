namespace Ticketing_System
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addTcktBtn = new Button();
            srchTcktBtn = new Button();
            searchBox = new TextBox();
            menuPanel = new Panel();
            menuButtonsPanel = new TableLayoutPanel();
            homeBtn = new Button();
            openticketsBtn = new Button();
            closedicketsBtn = new Button();
            allticketsBtn = new Button();
            createUsersBtn = new Button();
            toolbarPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            logoutBtn = new Button();
            panelSearch = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cerrToolStripMenuItem = new ToolStripMenuItem();
            maincontainerPanel = new Panel();
            menuPanel.SuspendLayout();
            menuButtonsPanel.SuspendLayout();
            toolbarPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // addTcktBtn
            // 
            addTcktBtn.BackColor = Color.White;
            addTcktBtn.Cursor = Cursors.Hand;
            addTcktBtn.Dock = DockStyle.Fill;
            addTcktBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            addTcktBtn.FlatAppearance.BorderSize = 0;
            addTcktBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            addTcktBtn.FlatStyle = FlatStyle.Flat;
            addTcktBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTcktBtn.ForeColor = Color.FromArgb(40, 40, 40);
            addTcktBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTcktBtn.Location = new Point(32, 6);
            addTcktBtn.Name = "addTcktBtn";
            addTcktBtn.Padding = new Padding(5);
            addTcktBtn.Size = new Size(195, 52);
            addTcktBtn.TabIndex = 1;
            addTcktBtn.Text = "+ Nuevo";
            addTcktBtn.TextAlign = ContentAlignment.MiddleLeft;
            addTcktBtn.UseVisualStyleBackColor = false;
            addTcktBtn.Click += addTcktBtn_Click;
            addTcktBtn.MouseEnter += addTcktBtn_MouseEnter;
            addTcktBtn.MouseLeave += addTcktBtn_MouseLeave;
            // 
            // srchTcktBtn
            // 
            srchTcktBtn.BackColor = Color.White;
            srchTcktBtn.Cursor = Cursors.Hand;
            srchTcktBtn.FlatAppearance.BorderSize = 0;
            srchTcktBtn.FlatAppearance.MouseDownBackColor = Color.White;
            srchTcktBtn.FlatAppearance.MouseOverBackColor = Color.White;
            srchTcktBtn.FlatStyle = FlatStyle.Flat;
            srchTcktBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            srchTcktBtn.Image = Properties.Resources.search;
            srchTcktBtn.Location = new Point(8, 8);
            srchTcktBtn.Name = "srchTcktBtn";
            srchTcktBtn.Size = new Size(32, 24);
            srchTcktBtn.TabIndex = 2;
            srchTcktBtn.UseVisualStyleBackColor = false;
            srchTcktBtn.Click += srchTcktBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.None;
            searchBox.BackColor = Color.White;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Cursor = Cursors.IBeam;
            searchBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.FromArgb(40, 40, 40);
            searchBox.Location = new Point(40, 8);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Ticket ID";
            searchBox.Size = new Size(312, 20);
            searchBox.TabIndex = 4;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.Enter += searchBox_Enter;
            searchBox.KeyDown += searchBox_KeyDown;
            searchBox.Leave += searchBox_Leave;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.DarkSlateGray;
            menuPanel.Controls.Add(menuButtonsPanel);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(72, 953);
            menuPanel.TabIndex = 7;
            // 
            // menuButtonsPanel
            // 
            menuButtonsPanel.BackColor = Color.Transparent;
            menuButtonsPanel.ColumnCount = 1;
            menuButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuButtonsPanel.Controls.Add(homeBtn, 0, 1);
            menuButtonsPanel.Controls.Add(openticketsBtn, 0, 2);
            menuButtonsPanel.Controls.Add(closedicketsBtn, 0, 3);
            menuButtonsPanel.Controls.Add(allticketsBtn, 0, 4);
            menuButtonsPanel.Controls.Add(createUsersBtn, 0, 5);
            menuButtonsPanel.Location = new Point(0, 0);
            menuButtonsPanel.Name = "menuButtonsPanel";
            menuButtonsPanel.RowCount = 7;
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            menuButtonsPanel.Size = new Size(72, 552);
            menuButtonsPanel.TabIndex = 8;
            // 
            // homeBtn
            // 
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.Dock = DockStyle.Fill;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Image = Properties.Resources.home;
            homeBtn.Location = new Point(0, 78);
            homeBtn.Margin = new Padding(0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(72, 78);
            homeBtn.TabIndex = 8;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // openticketsBtn
            // 
            openticketsBtn.Cursor = Cursors.Hand;
            openticketsBtn.Dock = DockStyle.Fill;
            openticketsBtn.FlatAppearance.BorderSize = 0;
            openticketsBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            openticketsBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            openticketsBtn.FlatStyle = FlatStyle.Flat;
            openticketsBtn.Image = Properties.Resources.box;
            openticketsBtn.Location = new Point(0, 156);
            openticketsBtn.Margin = new Padding(0);
            openticketsBtn.Name = "openticketsBtn";
            openticketsBtn.Size = new Size(72, 78);
            openticketsBtn.TabIndex = 9;
            openticketsBtn.UseVisualStyleBackColor = true;
            openticketsBtn.Click += openticketsBtn_Click;
            // 
            // closedicketsBtn
            // 
            closedicketsBtn.Cursor = Cursors.Hand;
            closedicketsBtn.Dock = DockStyle.Fill;
            closedicketsBtn.FlatAppearance.BorderSize = 0;
            closedicketsBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            closedicketsBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            closedicketsBtn.FlatStyle = FlatStyle.Flat;
            closedicketsBtn.Image = Properties.Resources.folder;
            closedicketsBtn.Location = new Point(0, 234);
            closedicketsBtn.Margin = new Padding(0);
            closedicketsBtn.Name = "closedicketsBtn";
            closedicketsBtn.Size = new Size(72, 78);
            closedicketsBtn.TabIndex = 10;
            closedicketsBtn.UseVisualStyleBackColor = true;
            closedicketsBtn.Click += closedicketsBtn_Click;
            // 
            // allticketsBtn
            // 
            allticketsBtn.Cursor = Cursors.Hand;
            allticketsBtn.Dock = DockStyle.Fill;
            allticketsBtn.FlatAppearance.BorderSize = 0;
            allticketsBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            allticketsBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            allticketsBtn.FlatStyle = FlatStyle.Flat;
            allticketsBtn.Image = Properties.Resources.openfolder;
            allticketsBtn.Location = new Point(0, 312);
            allticketsBtn.Margin = new Padding(0);
            allticketsBtn.Name = "allticketsBtn";
            allticketsBtn.Size = new Size(72, 78);
            allticketsBtn.TabIndex = 11;
            allticketsBtn.UseVisualStyleBackColor = true;
            allticketsBtn.Click += allticketsBtn_Click;
            // 
            // createUsersBtn
            // 
            createUsersBtn.Cursor = Cursors.Hand;
            createUsersBtn.FlatAppearance.BorderSize = 0;
            createUsersBtn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            createUsersBtn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            createUsersBtn.FlatStyle = FlatStyle.Flat;
            createUsersBtn.Image = Properties.Resources.createUsers;
            createUsersBtn.Location = new Point(0, 390);
            createUsersBtn.Margin = new Padding(0);
            createUsersBtn.Name = "createUsersBtn";
            createUsersBtn.Size = new Size(72, 78);
            createUsersBtn.TabIndex = 12;
            createUsersBtn.UseVisualStyleBackColor = true;
            createUsersBtn.Click += createUsersBtn_Click;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.White;
            toolbarPanel.Controls.Add(tableLayoutPanel1);
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Location = new Point(72, 0);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(1580, 64);
            toolbarPanel.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.96078455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.705883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.705883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.450983F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.90196133F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.90196133F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.90196133F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5098038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.9607842F));
            tableLayoutPanel1.Controls.Add(logoutBtn, 8, 0);
            tableLayoutPanel1.Controls.Add(addTcktBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(panelSearch, 3, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1584, 64);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.None;
            logoutBtn.BackColor = Color.White;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.FromArgb(40, 40, 40);
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(1347, 6);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(5);
            logoutBtn.Size = new Size(199, 52);
            logoutBtn.TabIndex = 10;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += button2_Click;
            logoutBtn.MouseEnter += logoutBtn_MouseEnter;
            logoutBtn.MouseLeave += logoutBtn_MouseLeave;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.Controls.Add(searchBox);
            panelSearch.Controls.Add(srchTcktBtn);
            panelSearch.Location = new Point(431, 14);
            panelSearch.Margin = new Padding(0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(376, 36);
            panelSearch.TabIndex = 9;
            panelSearch.Paint += panelSearch_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cerrToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(188, 32);
            // 
            // cerrToolStripMenuItem
            // 
            cerrToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cerrToolStripMenuItem.Name = "cerrToolStripMenuItem";
            cerrToolStripMenuItem.Padding = new Padding(5, 5, 5, 1);
            cerrToolStripMenuItem.Size = new Size(197, 28);
            cerrToolStripMenuItem.Text = "Cerrar Sesión";
            cerrToolStripMenuItem.Click += cerrToolStripMenuItem_Click;
            // 
            // maincontainerPanel
            // 
            maincontainerPanel.Location = new Point(104, 88);
            maincontainerPanel.Name = "maincontainerPanel";
            maincontainerPanel.Size = new Size(1528, 840);
            maincontainerPanel.TabIndex = 9;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1652, 953);
            Controls.Add(maincontainerPanel);
            Controls.Add(toolbarPanel);
            Controls.Add(menuPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket System";
            Load += Form1_Load;
            menuPanel.ResumeLayout(false);
            menuButtonsPanel.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button addTcktBtn;
        private Button srchTcktBtn;
        private TextBox searchBox;
        private Panel menuPanel;
        private TableLayoutPanel menuButtonsPanel;
        private Button homeBtn;
        private Button openticketsBtn;
        private Button closedicketsBtn;
        private Button allticketsBtn;
        private Panel toolbarPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSearch;
        private Button logoutBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cerrToolStripMenuItem;
        private Panel maincontainerPanel;
        private Button createUsersBtn;
    }
}
