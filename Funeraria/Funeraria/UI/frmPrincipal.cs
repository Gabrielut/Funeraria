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
            disenhoMenu();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        #region CambiarTamanhoVentana

        //Constructor
        public void FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnlContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }



        #endregion


        private void disenhoMenu()
        {
            pnlMantenimientos.Visible = false;
            pnlReportes.Visible = false;
            pnlHerramientas.Visible = false;           
        }

        public void esconderSubMenu() {

            if (pnlMantenimientos.Visible == true)
            {
                pnlMantenimientos.Visible = false;

            }
            if (pnlReportes.Visible == true)
            {
                pnlReportes.Visible = false;
            }
            if (pnlHerramientas.Visible == true)
            {
                pnlHerramientas.Visible = false;
            }
            

        }

        public void mostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == true)
            {
                esconderSubMenu();
                subMenu.Visible = false;
            }
            else
            {
                subMenu.Visible = true;
            }

        
        }

        #region menuMantenimientos
        private void btnMenuMantenimientos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMantenimientos);
        }

        private void btnMantActivos_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnMantClientes_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnMantProveedores_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnMantPaquetes_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnMantEmpleados_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }




        #endregion

        #region menuHerramientas

        private void btnMenuHerramientas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlHerramientas);
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
            abrirForumalario<frmCotizacion>();
        }





        #endregion

        #region menuReportes

        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlReportes);
        }

        private void btnRptPaquetes_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnRptActivos_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnRptClientes_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }

        private void btnRptProveedores_Click(object sender, EventArgs e)
        {
            //code
            esconderSubMenu();
        }







        #endregion

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #region abrirFormularios

        private void abrirForumalario<miForm>() where miForm : Form, new() {

            Form formulario;
            formulario = pnlFormularios.Controls.OfType<miForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new miForm();
                formulario.TopLevel = false;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else {
                formulario.BringToFront();
                
            }
            
          
        }

        #endregion



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
