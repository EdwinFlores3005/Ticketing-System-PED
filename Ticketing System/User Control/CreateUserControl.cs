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

namespace Ticketing_System.User_Control
{
    public partial class CreateUserControl : UserControl
    {
            public CreateUserControl()
            {
                InitializeComponent();
            }

            //Al crear usuario, se confirma que ningun campo este vacio y que las entradas sean validas
            //Se agrega el usuario a la DB, y se resetea el form
            private void createUserBtn_Click(object sender,EventArgs e)
            {
                string name = nameTxtBox.Text.Trim();
                string email = emailTxtBox.Text.Trim();
                string password = passwordTxtBox.Text.Trim();
                string role = RoleBox.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Todos los campos son obligatorios");

                    return;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Correo inválido");

                    return;
                }

                if (RoleBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un rol");

                    return;
                }

                DataAccess.AddUser(name, email, password, role);
                MessageBox.Show("Usuario creado correctamente");
                nameTxtBox.Text = "";
                emailTxtBox.Text = "";
                passwordTxtBox.Text = "";
                RoleBox.SelectedIndex = -1;

        }
    
    }
}
