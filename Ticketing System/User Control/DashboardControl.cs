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

namespace Ticketing_System.User_Control
{
    //Dashboard
    public partial class DashboardControl : UserControl
    {
        
        public DashboardControl()
        {
            InitializeComponent();
            //Se obtienen los 3 recientes tickets en general, y los asignados al usuario
            List<Ticket> recentAssigned = DataAccess.GetRecentAssignedTickets();
            List<Ticket> recentAll = DataAccess.GetRecentTickets();

            welcomeLbl.Text = "BIENVENIDO, " + Session.name.ToUpper();

            //Se muestra la cantidad de tickets abiertos, criticos, y asignados al usuario
            openTxt.ReadOnly = true;
            openTxt.SelectionColor = Color.Black;
            openTxt.AppendText(DataAccess.CountAllOpenTickets().ToString() + " Tickets");
            openTxt.SelectionColor = Color.FromArgb(255, 170, 64);
            openTxt.AppendText(" ABIERTOS");

            criticalTxt.ReadOnly = true;
            criticalTxt.SelectionColor = Color.Black;
            criticalTxt.AppendText(DataAccess.CountAllCriticalTickets().ToString() + " Tickets");
            criticalTxt.SelectionColor = Color.FromArgb(220, 53, 69);
            criticalTxt.AppendText(" CRÍTICOS");

            assignedTxt.ReadOnly = true;
            assignedTxt.SelectionColor = Color.Black;
            assignedTxt.AppendText(DataAccess.CountAllAssignedTickets().ToString() + " Tickets");
            assignedTxt.SelectionColor = Color.FromArgb(40, 167, 69);
            assignedTxt.AppendText(" ASIGNADOS");


            allticketsPanel.Controls.Clear();
            foreach (Ticket ticket in recentAll)
            {
                Label lbl = new Label();

                lbl.AutoSize = true;
                lbl.Text = $"#{ticket.Id} - {ticket.Title} - {ticket.CreatedAt:dd/MM/yyyy}";
                lbl.Padding = new Padding(5);

                allticketsPanel.Controls.Add(lbl);
            }

            assignedticketsPanel.Controls.Clear();
            foreach(Ticket ticket in recentAssigned)
            {
                Label lbl = new Label();

                lbl.AutoSize = true;
                lbl.Text = $"#{ticket.Id} - {ticket.Title} - {ticket.CreatedAt:dd/MM/yyyy}";
                lbl.Padding = new Padding(5);

                assignedticketsPanel.Controls.Add(lbl);
            }
            
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }


    }
}
