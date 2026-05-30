using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_System.Data;

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
            //Obtener datos para crear el ticket
            string email = emailTxtBox.Text.Trim();

            string title = titleTxtBox.Text.Trim();

            string description = descTxtBox.Text.Trim();

            string status = statusBox.Text;

            // VALIDAR TEXTBOXES
            if (
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(description)
            )
            {
                MessageBox.Show(
                    "Todos los campos son obligatorios",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // VALIDAR COMBOBOXES
            if (
                prioBox.SelectedIndex == -1 ||
                statusBox.SelectedIndex == -1
            )
            {
                MessageBox.Show(
                    "Debes seleccionar prioridad y estado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // VALIDAR EMAIL
            if (!email.Contains("@"))
            {
                MessageBox.Show(
                    "Correo inválido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int priority = prioBox.SelectedIndex + 1;

            //Agregar el ticket a la base de datos
            DataAccess.AddTicket(
                title,
                description,
                email,
                priority,
                status
            );

            MessageBox.Show(
                "Ticket creado correctamente"
            );

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
        

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
