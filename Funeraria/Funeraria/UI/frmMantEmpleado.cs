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

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantEmpleado : Form
    {
        public frmMantEmpleado()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        private void frmMantEmpleado_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);

        }

        #region Mantenimientos
        public void llenarDatos()
        {
            IBLLUsuarios _BLLUsuarios = new BLLUsuarios();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDatos.DataSource = _BLLUsuarios.GetAllUsuarios();
        }
        public void llenarCombos()
        {
            IBLLSexo _BLLSexo = new BLLSexo();
            IBLLRol _BLLRol = new BLLRol();
            this.cboSexo.Items.Clear();
            this.cboRol.Items.Clear();
            foreach (Sexo item in _BLLSexo.GetAllSexo())
            {
                this.cboSexo.Items.Add(item);
            }
            foreach (Rol item in _BLLRol.GetAllRol())
            {
                this.cboRol.Items.Add(item);
            }
            this.cboSexo.SelectedIndex = 0;
            this.cboRol.SelectedIndex = 0;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                IBLLUsuarios _BllUsuario = new BLLUsuarios();
                Usuarios oUsuarios = new Usuarios();
                oUsuarios.IDUsuario = this.txtCedula.Text;
                oUsuarios.Nombre = this.txtNombre.Text;
                oUsuarios.PrimerApellido = this.txtApellido1.Text;
                oUsuarios.SegundoApellido = this.txtApellido2.Text;
                oUsuarios.Correo = this.txtCorreo.Text;
                oUsuarios.Contrasenna = this.txtContrasenna.Text;
                oUsuarios.Telefono = this.txtTelefono.Text;
                oUsuarios.Sexo = (cboSexo.SelectedItem as Sexo).IdSexo;
                oUsuarios.IdRol = (cboRol.SelectedItem as Rol).IDRol;
                oUsuarios.FechaNacimiento = dtpFechaNac.Value;
                oUsuarios.Estado = true;
                oUsuarios.Direccion = txtDireccion.Text;
                oUsuarios.Token = "";
                if (_BllUsuario.SaveUsuarios(oUsuarios) != null)
                {
                    llenarCombos();
                    llenarDatos();
                }
            }
            catch (Exception)
            {

                throw;
            }
            llenarDatos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios oUsuarios = null;
                IBLLUsuarios _BllUsuario = new BLLUsuarios();

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oUsuarios = dgvDatos.SelectedRows[0].DataBoundItem as Usuarios;
                    this.txtCedula.Text = oUsuarios.IDUsuario;
                    this.txtNombre.Text = oUsuarios.Nombre;
                    this.txtApellido1.Text = oUsuarios.PrimerApellido;
                    this.txtApellido2.Text = oUsuarios.SegundoApellido;
                    this.txtCorreo.Text = oUsuarios.Correo;
                    this.txtContrasenna.Text = oUsuarios.Contrasenna;
                    this.txtTelefono.Text = oUsuarios.Telefono;
                    (cboSexo.SelectedItem as Sexo).IdSexo = oUsuarios.Sexo;
                    (cboRol.SelectedItem as Rol).IDRol = oUsuarios.IdRol;
                    dtpFechaNac.Value = oUsuarios.FechaNacimiento;
                    this.txtDireccion.Text = oUsuarios.Direccion.ToString();

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
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios oUsuarios = null;
                IBLLUsuarios _BllUsuario = new BLLUsuarios();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oUsuarios = dgvDatos.SelectedRows[0].DataBoundItem as Usuarios;
                    if (oUsuarios != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oUsuarios.IDUsuario} {oUsuarios.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllUsuario.DaleteUsuarios(oUsuarios.IDUsuario);
                            llenarDatos();
                        } 
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
        private void CambiarEstado(MantenimientoEnum estado)
        {
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtCorreo.Text = "";
            this.txtContrasenna.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";

            this.txtCedula.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtContrasenna.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.cboSexo.SelectedIndex = 0;
            this.cboRol.SelectedIndex = 0;
            this.cboSexo.Enabled = false;
            this.cboRol.Enabled = false;
            this.dtpFechaNac.Value = DateTime.Now;
            this.dtpFechaNac.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtCedula.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtContrasenna.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.cboSexo.Enabled = true;
                    this.cboRol.Enabled = true;
                    this.dtpFechaNac.Enabled = true;
                    this.txtCedula.Focus();
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    break;
                case MantenimientoEnum.Editar:
                    this.txtCedula.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = false;
                    this.txtContrasenna.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
