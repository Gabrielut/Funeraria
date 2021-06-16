using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantActivo : Form
    {

       
        public frmMantActivo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region diseño
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

           int nLeft,
           int nTop,
           int nBottom,
           int nRight,
           int nWidthEllipse,
           int nHeightEllipse
           );


        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {
            toolTNombre.SetToolTip(txtNombre, "Por favor digite el nombre del activo a insertar");
            toolTGuardar.SetToolTip(btnEliminar, "Guardar");
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
            toolTEstado.SetToolTip(cbBoxEstado, "Activar/Desactivar");
            toolTListado.SetToolTip(dGVListadoActivos, "Listado de todos los activos guardados en la base de datos");

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

        #endregion

        #region Mantenimientos
        private void frmMantActivo_Load(object sender, EventArgs e)
        {
            llenarDatos();
            llenarCombos();
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        public void llenarDatos()
        {
            IBLLActivo _BLLActivo = new BLLActivo();
            List<ActivoDTO> lista = _BLLActivo.GetAllActivos();
            dGVListadoActivos.AutoGenerateColumns = false;
            dGVListadoActivos.RowTemplate.Height = 50;
            dGVListadoActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dGVListadoActivos.DataSource = lista;

        }
        public void llenarCombos()
        {
            IBLLTipoActivo _BLLTipoActivo = new BLLTipoActivo();

            this.cbBoxTipoActivo.Items.Clear();
            this.cbBoxEstado.Items.Clear();
            foreach (TipoActivo item in _BLLTipoActivo.GetAllTipoActivo())
            {
                this.cbBoxTipoActivo.Items.Add(item);
            }
            this.cbBoxEstado.Items.Add("Activo");
            this.cbBoxEstado.Items.Add("Inactivo");
            this.cbBoxEstado.SelectedIndex = 0;
            this.cbBoxTipoActivo.SelectedIndex = 0;
        }
        private void CambiarEstado(MantenimientoEnum estado)
        {
            IBLLActivo _BllActivo = new BLLActivo();
            this.txtIdActivo.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.txtDetalles.Text = "";
            this.txtCantidad.Text = "1";
            this.txtPrecio.Text = "";
            this.txtPrecio.DecimalPlaces = 2;
            this.txtCosto.Text = "";
            this.txtCosto.DecimalPlaces = 2;
            this.cbBoxTipoActivo.SelectedIndex = 0;
            this.cbBoxEstado.SelectedIndex = 0;
            this.pbImage.Image = Funeraria.Properties.Resources.download;
            this.pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            this.txtIdActivo.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtDetalles.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtCosto.Enabled = false;
            this.cbBoxTipoActivo.Enabled = false;
            this.cbBoxEstado.Enabled = false;
            this.pbImage.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtIdActivo.Text = _BllActivo.GetNextNumeroActivo().ToString();
                    this.txtIdActivo.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtDetalles.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtPrecio.DecimalPlaces = 2;
                    this.txtCosto.Enabled = true;
                    this.txtCosto.DecimalPlaces = 2;
                    this.cbBoxTipoActivo.Enabled = true;
                    this.cbBoxEstado.Enabled = true;
                    this.pbImage.Enabled = true;

                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtIdActivo.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtDetalles.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCosto.Enabled = true;
                    this.cbBoxTipoActivo.Enabled = true;
                    this.cbBoxEstado.Enabled = true;
                    this.pbImage.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }
        }
        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            btnGuardar2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGuardar2.Width, btnGuardar2.Height, 10, 5));
            try
            {
                IBLLActivo _BllActivo = new BLLActivo();
                Activo oActivo = new Activo();
                oActivo.IdActivo = int.Parse(this.txtIdActivo.Text);
                oActivo.Nombre = this.txtNombre.Text;
                oActivo.Descripcion = this.txtDescripcion.Text;
                oActivo.TipoActivo = (cbBoxTipoActivo.SelectedItem as TipoActivo).IdTipoActivo;
                oActivo.Cantidad = (int)this.txtCantidad.Value;
                oActivo.Costo = float.Parse(this.txtCosto.Text);
                oActivo.Precio = float.Parse(this.txtPrecio.Text);
                oActivo.InformacionAdicional = this.txtDetalles.Text;
                oActivo.Img = (byte[])this.pbImage.Tag;
                if (cbBoxEstado.SelectedIndex == 0)
                {
                    oActivo.Estado = true;
                }
                else
                {
                    oActivo.Estado = false;
                }
                if (_BllActivo.SaveActivo(oActivo) != null)
                {
                    llenarCombos();
                    llenarDatos();
                    CambiarEstado(MantenimientoEnum.Ninguno);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void pbImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    //ruta = opt.FileName.Trim();
                    this.pbImage.ImageLocation = opt.FileName;
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbImage.Tag = (byte[])cadenaBytes;

                }
            }
            catch (Exception er)
            {

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ActivoDTO oActivoDTO = null;
                IBLLActivo _BllActivo = new BLLActivo();

                if (this.dGVListadoActivos.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oActivoDTO = dGVListadoActivos.SelectedRows[0].DataBoundItem as ActivoDTO;
                    this.txtIdActivo.Text = oActivoDTO.IdActivo.ToString();
                    this.txtNombre.Text = oActivoDTO.Nombre;
                    this.txtDescripcion.Text = oActivoDTO.Descripcion;
                    this.cbBoxTipoActivo.SelectedIndex = cbBoxTipoActivo.FindString(oActivoDTO.TipoActivo.ToString());
                    this.txtCantidad.Value = oActivoDTO.Cantidad;
                    this.txtCosto.Text = oActivoDTO.Costo.ToString();
                    this.txtPrecio.Text = oActivoDTO.Precio.ToString();
                    this.txtDetalles.Text = oActivoDTO.InformacionAdicional.ToString();
                    this.pbImage.Image = new Bitmap(new MemoryStream(oActivoDTO.Img));
                    this.pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbImage.Tag = oActivoDTO.Img;
                    this.cbBoxEstado.SelectedIndex = cbBoxEstado.FindString(oActivoDTO.Estado.ToString());
                    
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ActivoDTO oActivo = null;
                IBLLActivo _BllActivo = new BLLActivo();
                if (this.dGVListadoActivos.SelectedRows.Count > 0)
                {
                    oActivo = dGVListadoActivos.SelectedRows[0].DataBoundItem as ActivoDTO;
                    if (oActivo != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oActivo.IdActivo} {oActivo.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllActivo.DaleteActivo(oActivo.IdActivo);
                            llenarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {

            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarEstado(MantenimientoEnum.Nuevo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarEstado(MantenimientoEnum.Ninguno);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
}
