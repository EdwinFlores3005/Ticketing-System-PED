using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string title = titleTxtBox.Text;
            int priority = prioBox.SelectedIndex + 1;
            string notes = descTxtBox.Text;

            if (!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(title) || !string.IsNullOrEmpty(notes))
            {
                DataAccess.AddTicket(title, notes, email, priority);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Los campos estan incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
