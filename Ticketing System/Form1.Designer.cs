namespace Ticketing_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AllTicketsView = new DataGridView();
            addTcktBtn = new Button();
            srchTcktBtn = new Button();
            textBox1 = new TextBox();
            refreshBtn = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)AllTicketsView).BeginInit();
            SuspendLayout();
            // 
            // AllTicketsView
            // 
            AllTicketsView.AllowUserToAddRows = false;
            AllTicketsView.AllowUserToDeleteRows = false;
            AllTicketsView.BackgroundColor = SystemColors.Control;
            AllTicketsView.BorderStyle = BorderStyle.None;
            AllTicketsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllTicketsView.GridColor = Color.Black;
            AllTicketsView.Location = new Point(13, 94);
            AllTicketsView.Name = "AllTicketsView";
            AllTicketsView.ReadOnly = true;
            AllTicketsView.RowHeadersWidth = 51;
            AllTicketsView.Size = new Size(406, 442);
            AllTicketsView.TabIndex = 0;
            // 
            // addTcktBtn
            // 
            addTcktBtn.BackColor = SystemColors.Control;
            addTcktBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTcktBtn.Location = new Point(13, 32);
            addTcktBtn.Name = "addTcktBtn";
            addTcktBtn.Size = new Size(156, 28);
            addTcktBtn.TabIndex = 1;
            addTcktBtn.Text = "Agregar Ticket";
            addTcktBtn.UseVisualStyleBackColor = false;
            addTcktBtn.Click += addTcktBtn_Click;
            // 
            // srchTcktBtn
            // 
            srchTcktBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            srchTcktBtn.Image = (Image)resources.GetObject("srchTcktBtn.Image");
            srchTcktBtn.Location = new Point(450, 32);
            srchTcktBtn.Name = "srchTcktBtn";
            srchTcktBtn.Size = new Size(41, 28);
            srchTcktBtn.TabIndex = 2;
            srchTcktBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(220, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar";
            textBox1.Size = new Size(224, 28);
            textBox1.TabIndex = 4;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = SystemColors.Control;
            refreshBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Image = (Image)resources.GetObject("refreshBtn.Image");
            refreshBtn.Location = new Point(173, 32);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(41, 28);
            refreshBtn.TabIndex = 5;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(503, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(436, 426);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 572);
            Controls.Add(listView1);
            Controls.Add(refreshBtn);
            Controls.Add(textBox1);
            Controls.Add(srchTcktBtn);
            Controls.Add(addTcktBtn);
            Controls.Add(AllTicketsView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket System";
            ((System.ComponentModel.ISupportInitialize)AllTicketsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AllTicketsView;
        private Button addTcktBtn;
        private Button srchTcktBtn;
        private TextBox textBox1;
        private Button refreshBtn;
        private ListView listView1;
    }
}
