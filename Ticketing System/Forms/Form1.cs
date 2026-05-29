using MaterialSkin;
using System.Data;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using Ticketing_System.Data;
using Ticketing_System.Forms;
using Ticketing_System.Models;
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

            switch (Session.confirmRole(Session.role))
            {
                case Session.Role.Tecnico:
                    createUsersBtn.Visible = false;
                    break;
                case Session.Role.Admin:
                    createUsersBtn.Visible = true;
                    break;

            }

            showToolTip(homeBtn, "Dashboard");
            showToolTip(openticketsBtn, "Mis tickets");
            showToolTip(closedicketsBtn, "Tickets cerrados");
            showToolTip(allticketsBtn, "Todos los tickets");
            showToolTip(createUsersBtn, "Crear usuarios");

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

        private void showToolTip(Button button, string phrase)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(button, phrase);
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
            //LoadTickets();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton(addTcktBtn, 30);
            RoundButton(logoutBtn, 30);
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


        private void openticketsBtn_Click(object sender, EventArgs e)
        {
            TicketViewControl getAllTickets = new TicketViewControl("mine");
            maincontainerPanel.Controls.Clear();
            getAllTickets.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(getAllTickets);
        }

        private void closedicketsBtn_Click(object sender, EventArgs e)
        {
            TicketViewControl getAllTickets = new TicketViewControl("closed");
            maincontainerPanel.Controls.Clear();
            getAllTickets.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(getAllTickets);
        }

        private void cerrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.id = 0;
            Session.name = "";
            Session.email = "";
            Session.role = "";
            Application.Restart();
        }

        private void allticketsBtn_Click(object sender, EventArgs e)
        {
            TicketViewControl getAllTickets = new TicketViewControl("all");
            maincontainerPanel.Controls.Clear();
            getAllTickets.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(getAllTickets);
        }

        private void allticketsBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void createUsersBtn_Click(object sender, EventArgs e)
        {
            CreateUserControl newUser = new CreateUserControl();
            maincontainerPanel.Controls.Clear();
            newUser.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(newUser);
        }

        private void srchTcktBtn_Click(object sender, EventArgs e)
        {
            /*if (int.TryParse(searchBox.Text,out int ticketId))
            {
                if (
                    ticketDictionary.ContainsKey(ticketId)
                )
                {
                    Ticket foundTicket =
                        ticketDictionary[ticketId];

                    List<Ticket> result =
                        new List<Ticket>();

                    result.Add(foundTicket);

                    DisplayTickets(result);
                }
                else
                {
                    MessageBox.Show(
                        "Ticket no encontrado"
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Ingresa un ID válido"
                );
            }*/
        }
    }
}
