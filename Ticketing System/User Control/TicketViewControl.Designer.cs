namespace Ticketing_System.User_Control
{
    partial class TicketViewControl
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
            allticketsView = new ListView();
            tickettypelabel = new Label();
            allTicketsNumber = new Label();
            sortbyLbl = new Label();
            sortbyBox = new ComboBox();
            statuschangestrip = new StatusStrip();
            statusLbl = new ToolStripStatusLabel();
            statuschangestrip.SuspendLayout();
            SuspendLayout();
            // 
            // allticketsView
            // 
            allticketsView.BackColor = Color.White;
            allticketsView.BorderStyle = BorderStyle.None;
            allticketsView.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allticketsView.FullRowSelect = true;
            allticketsView.Location = new Point(0, 96);
            allticketsView.MultiSelect = false;
            allticketsView.Name = "allticketsView";
            allticketsView.Size = new Size(1528, 728);
            allticketsView.TabIndex = 0;
            allticketsView.UseCompatibleStateImageBehavior = false;
            allticketsView.View = View.Details;
            allticketsView.ItemActivate += allticketsView_ItemActivate;
            // 
            // tickettypelabel
            // 
            tickettypelabel.AutoSize = true;
            tickettypelabel.BackColor = Color.White;
            tickettypelabel.FlatStyle = FlatStyle.Flat;
            tickettypelabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tickettypelabel.Location = new Point(0, 8);
            tickettypelabel.Name = "tickettypelabel";
            tickettypelabel.Size = new Size(21, 24);
            tickettypelabel.TabIndex = 1;
            tickettypelabel.Text = "#";
            // 
            // allTicketsNumber
            // 
            allTicketsNumber.AutoSize = true;
            allTicketsNumber.BackColor = Color.White;
            allTicketsNumber.FlatStyle = FlatStyle.Flat;
            allTicketsNumber.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allTicketsNumber.Location = new Point(0, 56);
            allTicketsNumber.Name = "allTicketsNumber";
            allTicketsNumber.Size = new Size(18, 19);
            allTicketsNumber.TabIndex = 2;
            allTicketsNumber.Text = "#";
            // 
            // sortbyLbl
            // 
            sortbyLbl.Anchor = AnchorStyles.None;
            sortbyLbl.AutoSize = true;
            sortbyLbl.BackColor = Color.White;
            sortbyLbl.FlatStyle = FlatStyle.Flat;
            sortbyLbl.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortbyLbl.Location = new Point(1256, 48);
            sortbyLbl.Name = "sortbyLbl";
            sortbyLbl.Padding = new Padding(4);
            sortbyLbl.Size = new Size(120, 27);
            sortbyLbl.TabIndex = 3;
            sortbyLbl.Text = "Ordenar por:";
            // 
            // sortbyBox
            // 
            sortbyBox.Anchor = AnchorStyles.None;
            sortbyBox.BackColor = SystemColors.Window;
            sortbyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortbyBox.FlatStyle = FlatStyle.Flat;
            sortbyBox.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortbyBox.FormattingEnabled = true;
            sortbyBox.Items.AddRange(new object[] { "Default", "Prioridad", "Fecha", "Estado" });
            sortbyBox.Location = new Point(1376, 48);
            sortbyBox.Name = "sortbyBox";
            sortbyBox.Size = new Size(151, 27);
            sortbyBox.TabIndex = 4;
            sortbyBox.SelectedIndexChanged += sortbyBox_SelectedIndexChanged;
            // 
            // statuschangestrip
            // 
            statuschangestrip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statuschangestrip.ImageScalingSize = new Size(20, 20);
            statuschangestrip.Items.AddRange(new ToolStripItem[] { statusLbl });
            statuschangestrip.Location = new Point(0, 814);
            statuschangestrip.Name = "statuschangestrip";
            statuschangestrip.Size = new Size(1528, 26);
            statuschangestrip.TabIndex = 5;
            statuschangestrip.Visible = false;
            // 
            // statusLbl
            // 
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(151, 20);
            statusLbl.Text = "toolStripStatusLabel1";
            statusLbl.Visible = false;
            // 
            // TicketViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(statuschangestrip);
            Controls.Add(sortbyBox);
            Controls.Add(sortbyLbl);
            Controls.Add(allTicketsNumber);
            Controls.Add(tickettypelabel);
            Controls.Add(allticketsView);
            Name = "TicketViewControl";
            Size = new Size(1528, 840);
            statuschangestrip.ResumeLayout(false);
            statuschangestrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView allticketsView;
        private Label tickettypelabel;
        private Label allTicketsNumber;
        private Label sortbyLbl;
        private ComboBox sortbyBox;
        private StatusStrip statuschangestrip;
        private ToolStripStatusLabel statusLbl;
    }
}
