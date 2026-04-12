namespace Ticketing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();

            AllTicketsView.DataSource = DataAccess.GetTickets();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTcktBtn_Click(object sender, EventArgs e)
        {
            Form NewTicket = new NewTicketForm();
            NewTicket.Show();

            if (NewTicket.DialogResult == DialogResult.OK)
            {
                NewTicket.Close();
            }
            if (NewTicket.DialogResult == DialogResult.Cancel)
                NewTicket.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            AllTicketsView.DataSource = DataAccess.GetTickets();
            
        }
    }
}
