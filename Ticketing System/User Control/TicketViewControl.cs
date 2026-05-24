using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ticketing_System.Data;
using Ticketing_System.Models;

namespace Ticketing_System.User_Control
{
    public partial class TicketViewControl : UserControl
    {
        private string currentTicketType;

        public TicketViewControl(string ticketType)
        {
            InitializeComponent();

            currentTicketType = ticketType;

            ImageList img = new ImageList();
            img.ImageSize = new Size(1, 32);

            allticketsView.SmallImageList = img;

            SetupColumns();

            LoadTickets();
        }

        private void SetupColumns()
        {
            allticketsView.Columns.Clear();
            allticketsView.Columns.Add("ID", 88);
            allticketsView.Columns.Add("Título", 400);
            allticketsView.Columns.Add("Estado", 120);
            allticketsView.Columns.Add("Fecha", 140);
            allticketsView.Columns.Add("Prioridad", 120);
            allticketsView.Columns.Add("Creado Por", 170);
            allticketsView.Columns.Add("Correo", 295);
            allticketsView.Columns.Add("Asignado A", 195);
        }

        private void LoadTickets()
        {
            allticketsView.Items.Clear();

            List<Ticket> tickets = new List<Ticket>();

            if (currentTicketType == "all")
            {
                tickettypelabel.Text = "Todos los tickets";
                tickets = DataAccess.GetTickets("");
            }
            else if (currentTicketType == "mine")
            {
                tickettypelabel.Text = "Mis tickets";
                tickets = DataAccess.GetTickets("WHERE T.AssignedToUserId = @userId");
            }
            else if (currentTicketType == "closed")
            {
                tickettypelabel.Text = "Tickets cerrados";
                tickets = DataAccess.GetTickets("WHERE T.Status = 'Closed'");
            }

            allTicketsNumber.Text = tickets.Count + " tickets";

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());

                item.UseItemStyleForSubItems = false;
                item.SubItems.Add(ticket.Title);
                item.SubItems.Add(ticket.Status);
                item.SubItems.Add(ticket.CreatedAt.ToString("dd/MM/yyyy"));
                item.SubItems.Add(GetPriorityText(ticket.Priority));
                item.SubItems.Add(ticket.UserName);
                item.SubItems.Add(ticket.UserEmail);
                item.SubItems.Add(ticket.AssignedAgentName);
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    item.SubItems[i].Font = new Font(
                        allticketsView.Font,
                        i == 2
                            ? FontStyle.Bold
                            : FontStyle.Regular
                    );
                }

                string status = ticket.Status.ToLower();

                if (status == "new")
                {
                    item.SubItems[2].ForeColor =
                        Color.FromArgb(255, 170, 64);
                }
                else if (status == "open")
                {
                    item.SubItems[2].ForeColor =
                        Color.FromArgb(220, 53, 69);
                }
                else if (status == "pending")
                {
                    item.SubItems[2].ForeColor =
                        Color.FromArgb(0, 120, 215);
                }
                else if (status == "closed")
                {
                    item.SubItems[2].ForeColor =
                        Color.FromArgb(40, 167, 69);
                }

                allticketsView.Items.Add(item);
            }
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
    }
}

