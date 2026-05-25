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
            allticketsView.Size = new Size(1528, 744);
            allticketsView.TabIndex = 0;
            allticketsView.UseCompatibleStateImageBehavior = false;
            allticketsView.View = View.Details;
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
            // TicketViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sortbyBox);
            Controls.Add(sortbyLbl);
            Controls.Add(allTicketsNumber);
            Controls.Add(tickettypelabel);
            Controls.Add(allticketsView);
            Name = "TicketViewControl";
            Size = new Size(1528, 840);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView allticketsView;
        private Label tickettypelabel;
        private Label allTicketsNumber;
        private Label sortbyLbl;
        private ComboBox sortbyBox;
    }
}
