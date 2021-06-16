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
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantCliente : Form
    {
        public frmMantCliente()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

      

        //public void llenarCombos()
        //{
            

        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                IBLLCliente _BllCliente = new BLLCLiente();

                Cliente oCliente = new Cliente();

                oCliente.IdCliente = int.Parse(this.txtId.Text);
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.PrimerApellido = this.txtApellido1.Text;
                oCliente.SegundoApellido = this.txtApellido2.Text;             
                oCliente.Correo = this.txtCorreo.Text;
                oCliente.Telefono = this.txtTelefono.Text;        
                oCliente.Sexo = (int)this.cBoxSexo.SelectedIndex;
                oCliente.Direccion = this.rTxtDireccion.Text;

                oCliente = _BllCliente.SaveCliente(oCliente);

                if (oCliente != null)
                {
                    this.CargarDatos();                              
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CargarDatos()
        {
            IBLLCliente _BllCliente = new BLLCLiente();
                    

            CambiarEstado(MantenimientoEnum.Ninguno);

            dtGVListadoClientes.AutoGenerateColumns = false;
            dtGVListadoClientes.RowTemplate.Height = 50;
            dtGVListadoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtGVListadoClientes.DataSource = _BllCliente.GetAllCliente();

            IBLLSexo _BLLSexo = new BLLSexo();
            this.cBoxSexo.Items.Clear();

            foreach (Sexo item in _BLLSexo.GetAllSexo())
            {
                this.cBoxSexo.Items.Add(item);
            }

            this.cBoxSexo.SelectedIndex = 0;


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



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = null;
            try
            {
                if (this.dtGVListadoClientes.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    CambiarEstado(MantenimientoEnum.Editar);
                    //Extraer el DTO seleccionado
                    oCliente = this.dtGVListadoClientes.SelectedRows[0].DataBoundItem as Cliente;

                    this.txtId.Text = oCliente.IdCliente.ToString();
                    this.txtNombre.Text = oCliente.Nombre.ToString();
                    this.txtApellido1.Text = oCliente.PrimerApellido.ToString();
                    this.txtApellido2.Text = oCliente.SegundoApellido.ToString();
                    this.txtCorreo.Text = oCliente.Correo.ToString();
                    this.txtTelefono.Text = oCliente.Telefono.ToString();

                    if (oCliente.Sexo == 0)
                    {

                        this.cBoxSexo.SelectedIndex = cBoxSexo.FindString("Masculino");
                    }
                    else {
                        this.cBoxSexo.SelectedIndex = cBoxSexo.FindString("Femenino");
                    }
                  //  this.cBoxSexo.SelectedIndex = cBoxSexo.FindString(oCliente.Sexo.ToString());
                    this.rTxtDireccion.Text = oCliente.Direccion.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro a editar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
              

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            IBLLCliente _BllCliente = new BLLCLiente();
            try
            {
                //ClienteDTO oCliente = null;

                CambiarEstado(MantenimientoEnum.Borrar);
                if (this.dtGVListadoClientes.SelectedRows.Count > 0)
                {
                    Cliente oCliente = dtGVListadoClientes.SelectedRows[0].DataBoundItem as Cliente;
                    if (oCliente != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.IdCliente} {oCliente.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllCliente.DeleteCliente(oCliente.IdCliente);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch (Exception er)
            {

            }
        }


        private void CambiarEstado(MantenimientoEnum estado)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtCorreo.Text = "";
            this.txtTelefono.Text = "";
            this.rTxtDireccion.Text = "";
            this.cBoxSexo.SelectedIndex = -1;


            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.rTxtDireccion.Enabled = true;
                    this.cBoxSexo.Enabled = true;
                    break;
                case MantenimientoEnum.Editar:
                    this.txtId.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.rTxtDireccion.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }


        }

        private void frmMantCliente_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoFunerariaVirgenAngelesDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.proyectoFunerariaVirgenAngelesDataSet.Cliente);
            CargarDatos();

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
    }
}
