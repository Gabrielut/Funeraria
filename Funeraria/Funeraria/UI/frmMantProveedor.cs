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
    public partial class frmMantProveedor : Form
    {
        public frmMantProveedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
