﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
