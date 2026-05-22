using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System.User_Control
{
    public partial class TicketViewControl : UserControl
    {
        public TicketViewControl(string ticketType, int ticketAmount)
        {
            InitializeComponent();
            LoadTickets();
            ImageList img = new ImageList();
            img.ImageSize = new Size(1, 32);

            allticketsView.SmallImageList = img;

            tickettypelabel.Text = ticketType;
            amntticketsLbl.Text = ticketAmount.ToString() + " tickets";
        }

        private void LoadTickets()
        {
            allticketsView.Items.Clear();

            DataTable table = DataAccess.GetTickets();
            

            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["TicketId"].ToString());
                //item.Font = new Font(allticketsView.Font, FontStyle.Regular);
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(row["Title"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                item.SubItems.Add(row["Priority"].ToString());
                //              item.SubItems.Add(row["Description"].ToString())
                item.SubItems.Add(row["UserName"].ToString());
                item.SubItems.Add(row["UserEmail"].ToString());

                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    item.SubItems[i].Font = new Font(
                        allticketsView.Font,
                        i == 2 ? FontStyle.Bold : FontStyle.Regular
                    );
                }


                string status = row["Status"].ToString().ToLower();

                if (status == "new")
                {
                    item.SubItems[2].ForeColor = Color.FromArgb(255, 170, 64);
                }
                else if (status == "open")
                {
                    item.SubItems[2].ForeColor = Color.FromArgb(220, 53, 69);
                }
                else if (status == "pending")
                {
                    item.SubItems[2].ForeColor = Color.FromArgb(0, 120, 215);
                }

                allticketsView.Items.Add(item);

            }
        }

        private void TicketViewControl_Load(object sender, EventArgs e)
        {
            
            allticketsView.Columns.Add("ID", 75);
            allticketsView.Columns.Add("Título", 450);
            allticketsView.Columns.Add("Estado", 100);
            allticketsView.Columns.Add("Prioridad", 100);
            allticketsView.Columns.Add("Nombre", 150);
            allticketsView.Columns.Add("Correo", 300);
            //allticketsView.Columns.Add("Agente", 100);
            
        }


    }
}


