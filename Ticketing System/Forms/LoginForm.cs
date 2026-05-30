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

namespace Ticketing_System.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Buscar credenciales en la base de datos. Si el usuario existe, se puede iniciar sesión
        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool result = DataAccess.Login(emailTxt.Text, passwordTxt.Text);
            if (result == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrecto.");
            }
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click((object)sender, e);
            }

        }

        //Mostrar contraseña
        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}
