using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            
            int nLeft,
            int nTop,
            int nBottom,
            int nRight,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public frmLogin()
        {
            InitializeComponent();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Settings.Default.Login = "sa";
            //Settings.Default.Password = "123456";
            StringBuilder conexion = new StringBuilder();
            this.txtUsuario.Text = "sa";
            this.txtContrasena.Text = "123456";

            try
            {


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(this.txtUsuario.Text.Trim(), this.txtContrasena.Text.Trim())))
                {
                    // Si esto da error es porque el usuario no existe! 
                }

                MessageBox.Show("Creo que funciona jaja");
            }
            catch (Exception er)
            {
                
                throw;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 5, 5));
            btnRegistrarse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegistrarse.Width, btnRegistrarse.Height, 5, 5));
            pnlLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlLogin.Width, pnlLogin.Height, 20, 25));
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
