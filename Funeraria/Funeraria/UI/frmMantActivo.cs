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

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantActivo : Form
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


        public frmMantActivo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {
            toolTNombre.SetToolTip(txtNombre, "Por favor digite el nombre del activo a insertar");
            toolTGuardar.SetToolTip(btnSalvarActivo, "Guardar");
            toolTEditar.SetToolTip(btnEditar, "Editar el activo");
            toolTNuevo.SetToolTip(btnNuevo, "Insertar Nuevo Activo");
            toolTDescripcion.SetToolTip(txtDescripcion, "Por favor digite una Descripción para el activo");
            toolTTipoActivo.SetToolTip(cbBoxTipoActivo, "Seleccione un Tipo de Activo");
            toolTCerrar.SetToolTip(btnSalir, "Cerrar la ventana");
            toolTGuardar2.SetToolTip(btnGuardar2, "Guardar los cambios");
            toolTCancelar.SetToolTip(btnCancelar, "Borrar los datos");
            toolTCosto.SetToolTip(txtCosto, "Inserte el costo unitario en colones");
            toolTDetalles.SetToolTip(txtDetalles, "Inserte todos aquellos detalles que considere necesarios");
            toolTPrecio.SetToolTip(txtPrecio, "Inserte el precio de venta");
            toolTImagen.SetToolTip(btnImagen, "Inserte la imagen del activo");
            toolTEstado.SetToolTip(cbBoxEstado, "Activar/Desactivar");
            toolTListado.SetToolTip(dGVListadoActivos, "Listado de todos los activos guardados en la base de datos");
            toolTCantidad.SetToolTip(cbBoxCantidad, "Ingrese la cantidad de activos");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            btnGuardar2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGuardar2.Width, btnGuardar2.Height, 10, 5));
        }

        //private void btnMaximizar_Click(object sender, EventArgs e)
        //{
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        //}
    }
}
