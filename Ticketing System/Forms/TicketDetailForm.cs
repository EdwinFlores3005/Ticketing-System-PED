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
            currentTicket = ticket;

            if(currentTicket.Status == "Closed")
            {
                notesTxt.Visible = false;
                Actualizar.Visible = false;
                stateBox.Enabled = false;
                prioBox.Enabled = false;
            }

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

        private void Actualizar_Click(object sender, EventArgs e)
        {
            bool changed = currentTicket.Status != stateBox.Text || currentTicket.Priority != prioBox.SelectedIndex + 1;
            bool noteAdded = !string.IsNullOrWhiteSpace(notesTxt.Text);

            if (currentTicket.Status != stateBox.Text)
            {
                DataAccess.AddHistory(currentTicket.Id, $"El estado se actualizo de {currentTicket.Status} a {stateBox.Text}", Session.id);
            }

            if (currentTicket.Priority != prioBox.SelectedIndex + 1)
            {
                DataAccess.AddHistory(currentTicket.Id,$"La prioridad cambió de {GetPriorityText(currentTicket.Priority)} a {GetPriorityText(prioBox.SelectedIndex + 1)}", Session.id);
            }

            if (noteAdded)
            {
                DataAccess.AddHistory(currentTicket.Id, notesTxt.Text,Session.id);
            }

            if (changed)
            {
                DataAccess.UpdateTicket(
                    currentTicket.Id,
                    stateBox.Text,
                    prioBox.SelectedIndex + 1
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
