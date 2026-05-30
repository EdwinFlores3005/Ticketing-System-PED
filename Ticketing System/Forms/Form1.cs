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
        private TicketViewControl currentTicketView;
        Color currentBorderColor = Color.Gray;
        public MainMenu()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
            logoutBtn.Text = Session.name;
            LoadDashboard();

            switch (Session.confirmRole(Session.role)) //Funciones que solo los Admins pueden ver
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

        //Esquinas redondeadas
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

        private void LoadDashboard()
        {
            maincontainerPanel.Controls.Clear();
            DashboardControl dashboardControl = new DashboardControl();
            dashboardControl.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(dashboardControl);
        }

        //Uso de tooltip al hacer hover sobre el menu
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

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton(addTcktBtn, 30);
            RoundButton(logoutBtn, 30);
        }

        //Agregar un nuevo ticket
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

        //Efecto hover para el boton de 'Nuevo Ticket'
        private void addTcktBtn_MouseEnter(object sender, EventArgs e)
        {
            addTcktBtn.ForeColor = Color.White;
        }

        private void addTcktBtn_MouseLeave(object sender, EventArgs e)
        {
            addTcktBtn.ForeColor = Color.FromArgb(40, 40, 40);
        }

        //Mostrar opción de 'Cerrar Sesión' al hacer click 
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

        //Cerrar sesión
        private void cerrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.id = 0;
            Session.name = "";
            Session.email = "";
            Session.role = "";
            Application.Restart();
        }

        //Boton de Home. Primer pantalla al cargar el programa.
        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        //Mostrar todos los tickets abiertos asignados al usuario
        private void openticketsBtn_Click(object sender, EventArgs e)
        {
            currentTicketView = new TicketViewControl("mine");
            maincontainerPanel.Controls.Clear();
            currentTicketView.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(currentTicketView);
        }

        //Mostrar los tickets cerrados
        private void closedicketsBtn_Click(object sender, EventArgs e)
        {
            currentTicketView = new TicketViewControl("closed");
            maincontainerPanel.Controls.Clear();
            currentTicketView.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(currentTicketView);
        }

        //Mostrar los tickets abiertos sin importar usuario
        private void allticketsBtn_Click(object sender, EventArgs e)
        {
            currentTicketView = new TicketViewControl("all");
            maincontainerPanel.Controls.Clear();
            currentTicketView.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(currentTicketView);
        }

        //Cargar form para crear un nuevo usuario. Solo disponible para Admins
        private void createUsersBtn_Click(object sender, EventArgs e)
        {
            CreateUserControl newUser = new CreateUserControl();
            maincontainerPanel.Controls.Clear();
            newUser.Dock = DockStyle.Fill;
            maincontainerPanel.Controls.Add(newUser);
        }

        //Buscar tickets
        private void srchTcktBtn_Click(object sender, EventArgs e)
        {
            if (currentTicketView != null)
            {
                currentTicketView.SearchTicket(searchBox.Text);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text)
   )
            {
                currentTicketView?.ResetSearch();
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                srchTcktBtn_Click((object)sender, e);
            }
        }

        //Decoración del botón de busqueda de ticket
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


    }
}
