using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            
        }

        public void esconderSubMenu() {

            if (pnlMantenimientos.Visible == true)
            {
                pnlMantenimientos.Visible = false;
            }
            //if (pnlReportes.Visible == true) 
            //{
            //    pnlReportes.Visible = false;
            //}
            //if (pnlHerramientas.Visible == true)
            //{
            //    pnlHerramientas.Visible = false;
            //}
        }

        public void mostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        
        }

        #region menuMantenimientos



        private void btnMenuMantenimientos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMantenimientos);
        }

        private void btnMenuEmpleados_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnMenuPaquetes_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnMenuProveedores_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnMenuActivos_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        #endregion


        #region menuHerramientas

        //private void btnMenuHerramientas_Click(object sender, EventArgs e)
        //{
        //    mostrarSubMenu(pnlHerramientas);
           
        //}

        private void btnMenuCotizaciones_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        #endregion


        #region menuReportes

        //private void btnMenuReportes_Click(object sender, EventArgs e)
        //{
        //    mostrarSubMenu(pnlReportes);
        //}

        private void btnRptActivos_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnRptPaquetes_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }

        private void btnRptProveedores_Click(object sender, EventArgs e)
        {
            // Show the form
            esconderSubMenu();
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuMantenimientos_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMantenimientos);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
