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
            label1 = new Label();
            emailTxtBox = new TextBox();
            label2 = new Label();
            titleTxtBox = new TextBox();
            label3 = new Label();
            prioBox = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            descTxtBox = new TextBox();
            createBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 35);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "Correo Electrónico";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxtBox.Location = new Point(269, 32);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(249, 28);
            emailTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 87);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // titleTxtBox
            // 
            titleTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTxtBox.Location = new Point(269, 84);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(249, 28);
            titleTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 146);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 4;
            label3.Text = "Prioridad";
            // 
            // prioBox
            // 
            prioBox.FormattingEnabled = true;
            prioBox.Items.AddRange(new object[] { "Crítico", "Alta", "Media", "Baja" });
            prioBox.Location = new Point(269, 146);
            prioBox.Name = "prioBox";
            prioBox.Size = new Size(249, 28);
            prioBox.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 196);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 6;
            label4.Text = "Notas";
            // 
            // descTxtBox
            // 
            descTxtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descTxtBox.Location = new Point(92, 220);
            descTxtBox.Multiline = true;
            descTxtBox.Name = "descTxtBox";
            descTxtBox.Size = new Size(908, 360);
            descTxtBox.TabIndex = 7;
            // 
            // createBtn
            // 
            createBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(364, 607);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(154, 29);
            createBtn.TabIndex = 8;
            createBtn.Text = "Crear Ticket";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(524, 607);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(154, 29);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // NewTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 677);
            Controls.Add(cancelBtn);
            Controls.Add(createBtn);
            Controls.Add(descTxtBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(prioBox);
            Controls.Add(label3);
            Controls.Add(titleTxtBox);
            Controls.Add(label2);
            Controls.Add(emailTxtBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTxtBox;
        private Label label2;
        private TextBox titleTxtBox;
        private Label label3;
        private ComboBox prioBox;
        private Button button1;
        private Label label4;
        private TextBox descTxtBox;
        private Button createBtn;
        private Button cancelBtn;
    }
}