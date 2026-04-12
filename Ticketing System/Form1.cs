using System.Data;

namespace Ticketing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();

            
        }

        private void LoadTickets()
        {
            AllTicketView.Items.Clear();

            DataTable table = DataAccess.GetTickets();

            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["TicketId"].ToString());

                item.SubItems.Add(row["Title"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                item.SubItems.Add(row["Priority"].ToString());
//              item.SubItems.Add(row["Description"].ToString())
                item.SubItems.Add(row["UserName"].ToString());
                item.SubItems.Add(row["UserEmail"].ToString());

                AllTicketView.Items.Add(item);
            }
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
           LoadTickets();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTickets();
            AllTicketView.Columns.Add("ID", 50);
            AllTicketView.Columns.Add("Título", 250);
            AllTicketView.Columns.Add("Estado", 100);
            AllTicketView.Columns.Add("Prioridad", 80);
            AllTicketView.Columns.Add("Nombre", 80);
            AllTicketView.Columns.Add("Correo", 150);
            //En vez de correo sera fecha
        }

        private void AllTicketView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllTicketView.SelectedItems.Count > 0)
            {
                var selectedItem = AllTicketView.SelectedItems[0];

                int ticketId = int.Parse(AllTicketView.SelectedItems[0].Text);
                //string ticketId = selectedItem.SubItems[3].Text;

                Form TicketDetail = new TicketDetailForm(ticketId);
                TicketDetail.Show();
                
            }
        }
    }
}
