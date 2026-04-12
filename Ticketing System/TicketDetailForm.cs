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
    public partial class TicketDetailForm : Form
    {
        private int ticketID;
        public TicketDetailForm(int id)
        {
            InitializeComponent();
            ticketID = id;
            ticketNumLabel.Text = "Ticket #" + ticketID;
            DataAccess.LoadTicket(id, titleLbl, userTxt, emailTxt, agentTxt, stateBox, prioBox, notesBox);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
