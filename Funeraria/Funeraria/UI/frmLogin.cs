using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                IBLLUsuarios _BLLUsuarios = new BLLUsuarios();
                List<Usuarios> lista = _BLLUsuarios.GetAllUsuarios();

                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                   // errorUsuario.SetError(txtUsuario, "Usuario requerido");
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                   // errorContrasena.SetError(txtContrasena, "Contraseñá requerida");
                    this.txtContrasena.Focus();
                    return;
                }
                foreach (Usuarios item in lista)
                {
                    if (item.Correo.Equals(this.txtUsuario.Text, StringComparison.CurrentCultureIgnoreCase) && item.Contrasenna.Equals(this.txtContrasena.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        MessageBox.Show("Aqui ingresa al menu principal");

                    }
                 
                }
            }
            catch (Exception er)
            {
                
                throw;
            }
        }
    }
}
