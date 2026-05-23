using MaterialSkin;
using System.Data;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using Ticketing_System.Data;
using Ticketing_System.Forms;
using Ticketing_System.User_Control;

namespace Ticketing_System
{
    public partial class MainMenu : Form
    {
        Color currentBorderColor = Color.Gray;
        public MainMenu()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
            logoutBtn.Text = Session.name;


        }

        //Round Corners
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        /*private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }*/

        //Active Button
        private void ActivateButton(Button btn)
        {
            Button currentButton;
            currentButton = btn;
            if (currentButton != null)
            {
                currentButton.BackColor = Color.White;
                currentButton.ForeColor = Color.Black;
            }

            btn.BackColor = Color.FromArgb(230, 245, 243);
            btn.ForeColor = Color.Teal;
        }

        //Panel Search Paint


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

            //ActivateButton(addTcktBtn);
        }

        //Este se puede quedar asi, tiene que cambiar a allticketsview dentro del usercontrol
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
            RoundButton(addTcktBtn, 30);
            RoundButton(logoutBtn, 30);
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

        private void addTcktBtn_MouseEnter(object sender, EventArgs e)
        {
            addTcktBtn.ForeColor = Color.White;
        }

        private void addTcktBtn_MouseLeave(object sender, EventArgs e)
        {
            addTcktBtn.ForeColor = Color.FromArgb(40, 40, 40);
        }

        private void searchBox_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            panelSearch.Invalidate();
            currentBorderColor = Color.DarkSlateGray;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            currentBorderColor = Color.Gray;
            panelSearch.Invalidate();
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(
               e.Graphics,
               panelSearch.ClientRectangle,
               currentBorderColor,
               ButtonBorderStyle.Solid);


        }

        private void refreshBtn_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(logoutBtn, 0, logoutBtn.Height);
        }

        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.ForeColor = Color.White;
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            logoutBtn.ForeColor = Color.FromArgb(40, 40, 40);
        }

        private void allticketsBtn_Click(object sender, EventArgs e)
        {
            TicketViewControl getAllTickets = new TicketViewControl("Todos los tickets", DataAccess.CountAllTickets());
            maincontainerPanel.Controls.Clear();
            getAllTickets.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(getAllTickets);

        }

        private void closedicketsBtn_Click(object sender, EventArgs e)
        {
            maincontainerPanel.Controls.Clear();
        }

        private void cerrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.id = 0;
            Session.name = "";
            Session.email = "";
            Session.role = "";
            Application.Restart();
        }
    }
}
