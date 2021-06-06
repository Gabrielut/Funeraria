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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            llenarCombos();
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
            // selecciona la primer opcion
            this.cboSexo.SelectedIndex = 0;
            this.cboRol.SelectedIndex = 0;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
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
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLUsuarios _bLLUsuarios = new BLLUsuarios();

            List<Usuarios> lista = _bLLUsuarios.GetUsuariosByFilter(txtBusqueda.Text);
            foreach (Usuarios item in lista)
            {

                MessageBox.Show(item.ToString());
            }
                


        }
    }
}
