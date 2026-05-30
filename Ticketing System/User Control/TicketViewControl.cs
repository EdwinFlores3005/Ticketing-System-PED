using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ticketing_System.Data;
using Ticketing_System.Models;

namespace Ticketing_System.User_Control
{
    //En este User Control se muestran todos los tickets por medio de listviews
    public partial class TicketViewControl : UserControl
    {
        private string currentTicketType;
        private List<Ticket> tickets = new List<Ticket>();
        private List<Ticket> Alltickets = new List<Ticket>();
        private Dictionary<int, Ticket> ticketDictionary = new Dictionary<int, Ticket>();

        public TicketViewControl(string ticketType)
        {
            InitializeComponent();

            currentTicketType = ticketType;

            ImageList img = new ImageList();
            img.ImageSize = new Size(1, 32);

            allticketsView.SmallImageList = img;

            SetupColumns();
            LoadTickets();
            SortOptions();
            sortbyBox.SelectedIndex = 0;
        }

        private void SetupColumns()
        {
            //Las columnas del ListView se crean
            allticketsView.Columns.Clear();
            allticketsView.Columns.Add("ID", 88, HorizontalAlignment.Center);
            allticketsView.Columns.Add("Título", 400);
            allticketsView.Columns.Add("Estado", 100, HorizontalAlignment.Center);
            allticketsView.Columns.Add("Fecha", 160, HorizontalAlignment.Center);
            allticketsView.Columns.Add("Prioridad", 120, HorizontalAlignment.Center);
            allticketsView.Columns.Add("Creado Por", 170);
            allticketsView.Columns.Add("Correo", 295);
            allticketsView.Columns.Add("Asignado A", 195, HorizontalAlignment.Left);
        }

        //La funcion LoadTickets trae desde la base de datos (DataAccess) los tickets seleccionados
        private void LoadTickets()
        {
            //Se traen todos los tickets sin importar el estado
            Alltickets = DataAccess.GetTickets("");
            ticketDictionary.Clear();

            //Todos los tickets se agregan a un diccionario
            foreach (Ticket ticket in Alltickets)
            {
                ticketDictionary[ticket.Id] = ticket;
            };

            //Traer todos los tickets abiertos, dejando de lado los cerrados
            if (currentTicketType == "all")
            {
                tickettypelabel.Text = "Todos los tickets";
                tickets = DataAccess.GetTickets("WHERE T.Status != 'Closed'");

            }
            //Tickets asignados al usuario
            else if (currentTicketType == "mine")
            {
                tickettypelabel.Text = "Mis tickets";
                tickets = DataAccess.GetTickets("WHERE T.AssignedToUserId = @userId AND T.Status != 'Closed'");
            }
            //Tickets cerrados
            else if (currentTicketType == "closed")
            {
                tickettypelabel.Text = "Tickets cerrados";
            }

            allTicketsNumber.Text = tickets.Count + " tickets";
            DisplayTickets(tickets);
        }

        //Funcion para mostrar la lista de tickets obtenida
        private void DisplayTickets(List<Ticket> tickets)
        {
            allticketsView.BeginUpdate();
            allticketsView.Items.Clear();

            //Por cada ticket se agrega un item al ListView
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());

                item.UseItemStyleForSubItems = false;
                item.SubItems.Add(ticket.Title);
                item.SubItems.Add(ticket.Status);
                item.SubItems.Add(ticket.CreatedAt.ToString("dd/MM/yyyy H:m"));
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
                //Mostrar un color distinto en la columna dependiendo del estado del ticket
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
                else if (status == "on hold")
                {
                    item.SubItems[2].ForeColor =
                        Color.DarkSlateGray;
                }

                allticketsView.Items.Add(item);
                
            }
            allticketsView.EndUpdate();
        }

        //Buscar tickets en el diccionario a traves del Search Bar con su ticket ID
        public void SearchTicket(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayTickets(tickets);
                return;
            }

            if (int.TryParse(searchText, out int ticketId))
            {
                if (ticketDictionary.ContainsKey(ticketId))
                {
                    //Si el ticket es encontrado en el diccionario se muestra en el ListView actual y el ticket es abierto
                    Ticket foundTicket = ticketDictionary[ticketId];

                    DisplayTickets(new List<Ticket>()
                        {
                    foundTicket
                        }
                    );
                    TicketDetailForm form = new TicketDetailForm(foundTicket);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ticket no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        public void ResetSearch()
        {
            DisplayTickets(tickets);
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

        private void SortOptions()
        {
            //Al momento de estar en el boton de tickets cerrados, aqui se muestran dos opciones para filtrar.
            //Se pueden mostrar todos los tickets cerrados, o los cerrados asignados al agente
            if (currentTicketType == "closed")
            {
                sortbyBox.Items.Clear();
                sortbyBox.Items.Add("Todos los tickets");
                sortbyBox.Items.Add("Mis tickets");
            }
        }

        private async void ShowStatus(string message)
        {
            //Al momento de abrir un ticket, se muestra una notificacion si hubo o no modificaciones
            statusLbl.Text = message;
            statuschangestrip.Visible = true;
            statuschangestrip.BackColor = Color.White;
            statusLbl.BackColor = Color.White;
            statusLbl.Visible = true;

            await Task.Delay(3000);

            statuschangestrip.Visible = false;
        }

        private void sortbyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentTicketType == "closed")
            {      
                //Se pueden mostrar todos los tickets cerrados, o los cerrados asignados al agente
                //Esto solo pasa al estar en la vista de tickets cerrados

                switch (sortbyBox.SelectedIndex)
                {
                    case 0:
                        tickets = DataAccess.GetTickets("WHERE T.Status = 'Closed'");
                        allTicketsNumber.Text = tickets.Count + " tickets";
                        DisplayTickets(tickets);
                        break;
                    case 1:
                        tickets = DataAccess.GetTickets("WHERE T.Status = 'Closed' AND T.AssignedToUserId = @userId");
                        allTicketsNumber.Text = tickets.Count + " tickets";
                        DisplayTickets(tickets);
                        break;

                }
            }
            else
            {
                //Filtros para ordenar tickets
                switch (sortbyBox.SelectedIndex)
                {

                    case 0: //Default
                        DisplayTickets(tickets);
                        break;
                    case 1:// Priority Queue
                        PriorityQueue<Ticket, int> ticketQueue = new PriorityQueue<Ticket, int>();
                        foreach (Ticket ticket in tickets)
                            ticketQueue.Enqueue(ticket, ticket.Priority);

                        List<Ticket> priorityList = new List<Ticket>();
                        while (ticketQueue.Count > 0)
                            priorityList.Add(ticketQueue.Dequeue());
                        DisplayTickets(priorityList);
                        break;
                    case 2: //Fecha
                        List<Ticket> sortedTickets = tickets.OrderByDescending(t => t.CreatedAt).ToList();
                        DisplayTickets(sortedTickets);
                        break;
                    case 3: //Por Status
                        List<Ticket> statusList = tickets.OrderBy(t =>
                        {
                            switch (t.Status)
                            {
                                case "New":
                                    return 1;
                                case "Open":
                                    return 2;
                                case "Pending":
                                    return 3;
                                case "On Hold":
                                    return 4;
                                case "Closed":
                                    return 5;
                                default:
                                    return 6;
                            }
                        }).ToList();
                        DisplayTickets(statusList);
                        break;

                }
            }
        }

        private void allticketsView_ItemActivate(object sender, EventArgs e)
        {
            //AL hacer doble click, se abre una nueva pestaña con la informacion del ticket
            //Esto permite poder actualizar la informacion del ticket
            ListViewItem activatedItem = allticketsView.SelectedItems[0];
            if (activatedItem != null)
            {
                int ticketID = Convert.ToInt32(activatedItem.Text);

                Ticket ticket = DataAccess.GetSelectedTicket(ticketID);

                TicketDetailForm form = new TicketDetailForm(ticket);

                if(form.ShowDialog() == DialogResult.OK)
                {
                    ShowStatus("El ticket fue actualizado correctamente");
                    LoadTickets();
                }
                else
                {
                    ShowStatus("No se realizaron cambios");
                }
                
            }
           

        }


    }
}

