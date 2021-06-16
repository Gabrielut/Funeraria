﻿using System;
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
    public partial class frmMantPaquete : Form
    {
        public frmMantPaquete()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Mantenimeintos
        private void frmMantPaquete_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        public void llenarDatos()
        {
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            List<PaqueteDTO> lista = _BLLPaquete.GetAllPaquete();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDatos.DataSource = lista;
        }
        public void llenarCombos()
        {
            IBLLTipoPaquete _BLLTipoPaquete = new BLLTipoPaquete();

            this.cboestado.Items.Clear();
            this.cboTipoPaquete.Items.Clear();
            foreach (TipoPaquete item in _BLLTipoPaquete.GetAllTipoPaquete())
            {
                this.cboTipoPaquete.Items.Add(item);
            }
            this.cboestado.Items.Add("Activo");
            this.cboestado.Items.Add("Inactivo");
            this.cboestado.SelectedIndex = 0;
            this.cboTipoPaquete.SelectedIndex = 0;
        }
        private void CambiarEstado(MantenimientoEnum estado)
        {
            IBLLProveedores _BllProveedor = new BLLProveedores();
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "";
            this.cboestado.SelectedIndex = 0;
            this.cboTipoPaquete.SelectedIndex = 0;

            this.txtId.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.cboestado.Enabled = false;
            this.cboTipoPaquete.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Text = _BllProveedor.GetNextNumeroActivo().ToString();
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboestado.Enabled = true;
                    this.cboTipoPaquete.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboestado.Enabled = true;
                    this.cboTipoPaquete.Enabled = true;
                    this.txtNombre.Focus();
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                IBLLPaquete _BllPaquete = new BLLPaquete();
                Paquete oPaquete = new Paquete();
                oPaquete.IdPaquete = int.Parse(this.txtId.Text);
                oPaquete.Nombre = this.txtNombre.Text;
                oPaquete.Descripcion = this.txtDescripcion.Text;
                oPaquete.Precio = (float.Parse(this.txtPrecio.Text));
                oPaquete.Cantidad = (int)this.txtCantidad.Value;
                oPaquete.IdTipoPaquete = (cboTipoPaquete.SelectedItem as TipoPaquete).IdTipoPaquete;
                if (cboestado.SelectedIndex == 0)
                {
                    oPaquete.Estado = true;
                }
                else
                {
                    oPaquete.Estado = false;
                }
                if (_BllPaquete.SavePaquete(oPaquete) != null)
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PaqueteDTO oPaqueteDTO = null;
                IBLLPaquete _BllPaquete = new BLLPaquete();

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oPaqueteDTO = dgvDatos.SelectedRows[0].DataBoundItem as PaqueteDTO;
                    this.txtId.Text = oPaqueteDTO.IdPaquete.ToString();
                    this.txtNombre.Text = oPaqueteDTO.Nombre;
                    this.txtDescripcion.Text = oPaqueteDTO.Descripcion;
                    this.txtPrecio.Text = oPaqueteDTO.Precio.ToString();
                    this.txtCantidad.Value = oPaqueteDTO.Cantidad;
                    this.cboestado.SelectedIndex = cboestado.FindString(oPaqueteDTO.Estado.ToString());
                    this.cboTipoPaquete.SelectedIndex = cboTipoPaquete.FindString(oPaqueteDTO.Paquete.ToString());
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PaqueteDTO oPaqueteDTO = null;
                IBLLPaquete _BllPaquete = new BLLPaquete();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oPaqueteDTO = dgvDatos.SelectedRows[0].DataBoundItem as PaqueteDTO;
                    if (oPaqueteDTO != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oPaqueteDTO.IdPaquete} {oPaqueteDTO.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllPaquete.DaletePaquete(oPaqueteDTO.IdPaquete);
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
        #endregion
    }
}
