using Microsoft.VisualBasic.ApplicationServices;
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
using Ticketing_System.Models;

namespace Ticketing_System
{
    public partial class TicketDetailForm : Form
    {
        private Ticket currentTicket;
        public TicketDetailForm(Ticket ticket)
        {
            InitializeComponent();
            //Se guarda el ticket seleccionado
            currentTicket = ticket;

            //Los tickets cerrados son readonly
            if(currentTicket.Status == "Closed")
            {
                notesTxt.Visible = false;
                Actualizar.Visible = false;
                stateBox.Enabled = false;
                prioBox.Enabled = false;
            }

            //Admins pueden cambiar el agente asignado al ticket
            assignAgentBox.Visible = Session.role == "Admin";
            assignAgentLbl.Visible = Session.role == "Admin";

            //Pasar los datos del ticket seleccionado al form
            ticketIdTxt.Text = ticket.Id.ToString();
            usernameTxt.Text = ticket.UserName.ToString();
            emailTxt.Text = ticket.UserEmail.ToString();
            agentTxt.Text = ticket.AssignedAgentName.ToString();
            titleLbl.Text = ticket.Title.ToString();
            ticketStatusLbl.Text = ticket.Id.ToString() + " - " + ticket.Status.ToString();
            initialNoteTxt.Text = ticket.Description.ToString();
            prioBox.SelectedIndex = ticket.Priority - 1;

            for (int i = 0; i < stateBox.Items.Count; i++)
            {
                if (stateBox.Items[i].ToString() == ticket.Status)
                    stateBox.SelectedIndex = i;
            }



            LoadHistory();
            LoadAgents();


        }

        private string GetPriorityText(int priority)
        {
            switch (priority)
            {
                case 1:
                    return "Crítico";
                case 2:
                    return "Alta";
                case 3:
                    return "Media";
                case 4:
                    return "Baja";
                default:
                    return "Sin prioridad";
            }
        }

        private void LoadHistory()
        {
            historyFlowPanel.Controls.Clear();

            //La cola de cambios hechos o notas guardadas en el ticket se llama y se muestran en un Panel
            Queue<TicketHistory> historyQueue = DataAccess.GetTicketHistoryQueue(currentTicket.Id);

            foreach (TicketHistory history in historyQueue)
            {
                Panel card = new Panel();

                card.Width = 700;
                card.Height = 85;
                card.BackColor = Color.White;
                card.Margin = new Padding(0, 0, 0, 10);

                Label headerLabel = new Label();
                headerLabel.Text = $"{history.UpdatedByName} - {history.CreatedAt:dd/MM/yyyy h:mm tt}";
                headerLabel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                headerLabel.Location = new Point(10, 10);
                headerLabel.AutoSize = true;

                Label changeLabel = new Label();
                changeLabel.Text = history.Change;
                changeLabel.Font = new Font("Segoe UI", 11, FontStyle.Regular);

                changeLabel.Location = new Point(10, 35);
                changeLabel.MaximumSize = new Size(650, 0);
                changeLabel.AutoSize = true;

                card.Controls.Add(headerLabel);
                card.Controls.Add(changeLabel);

                historyFlowPanel.Controls.Add(card);
            }
        }

        //Trar lista de agentes para reasignar ticket
        private void LoadAgents()
        {
            List<UserClass> agents = DataAccess.GetAgents();

            assignAgentBox.DataSource = agents;

            assignAgentBox.DisplayMember = "Name";

            assignAgentBox.ValueMember = "Id";

            assignAgentBox.SelectedValue = currentTicket.AssignedToUserId;
        }

        //Actualizar informacion del ticket
        private void Actualizar_Click(object sender, EventArgs e)
        {
            bool changed = currentTicket.Status != stateBox.Text || currentTicket.Priority != prioBox.SelectedIndex + 1 || currentTicket.AssignedToUserId != Convert.ToInt32(assignAgentBox.SelectedValue);
            bool noteAdded = !string.IsNullOrWhiteSpace(notesTxt.Text);

            //Guardar nota automatica al cambiar de estado
            if (currentTicket.Status != stateBox.Text)
            {
                DataAccess.AddHistory(currentTicket.Id, $"El estado se actualizo de {currentTicket.Status} a {stateBox.Text}", Session.id);
            }

            //Guardar nota automatica al cambiar de proridad
            if (currentTicket.Priority != prioBox.SelectedIndex + 1)
            {
                DataAccess.AddHistory(currentTicket.Id,$"La prioridad cambió de {GetPriorityText(currentTicket.Priority)} a {GetPriorityText(prioBox.SelectedIndex + 1)}", Session.id);
            }

            //Guardar nota automatica al cambiar de agente
            if (currentTicket.AssignedToUserId != Convert.ToInt32(assignAgentBox.SelectedValue))
            {
                DataAccess.AddHistory(
                    currentTicket.Id,
                    $"Ticket reasignado a {assignAgentBox.Text}",
                    Session.id
                );
            }

            //Si una nota manual fue agregada, se guarda en la base de datos
            if (noteAdded)
            {
                DataAccess.AddHistory(currentTicket.Id, notesTxt.Text,Session.id);
            }

            //Si hubo cambios en el estado, la prioridad, o el agente, se guarda una nota en la base de datos
            if (changed)
            {
                DataAccess.UpdateTicket(
                    currentTicket.Id,
                    stateBox.Text,
                    prioBox.SelectedIndex + 1,
                    Convert.ToInt32(assignAgentBox.SelectedValue)
                );
            }

            if (changed || noteAdded)
            {
                this.DialogResult = DialogResult.OK;
            }


            this.Close();
        }
    }
}
