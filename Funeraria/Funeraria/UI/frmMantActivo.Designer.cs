
namespace UTN.Winform.Funeraria.UI
{
    partial class frmMantActivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnSalvarActivo = new FontAwesome.Sharp.IconButton();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnGuardar2 = new FontAwesome.Sharp.IconButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnImagen = new FontAwesome.Sharp.IconButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cbBoxCantidad = new System.Windows.Forms.ComboBox();
            this.cbBoxTipoActivo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTipoActivo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dGVListadoActivos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolTNombre = new System.Windows.Forms.ToolTip(this.components);
            this.toolTGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTEditar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTNuevo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTDescripcion = new System.Windows.Forms.ToolTip(this.components);
            this.toolTTipoActivo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.toolTCerrar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTGuardar2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTCancelar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTDetalles = new System.Windows.Forms.ToolTip(this.components);
            this.toolTPrecio = new System.Windows.Forms.ToolTip(this.components);
            this.toolTCosto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTImagen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTListado = new System.Windows.Forms.ToolTip(this.components);
            this.toolTEstado = new System.Windows.Forms.ToolTip(this.components);
            this.toolTCantidad = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoActivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblTitulo);
            this.pnlMenu.Controls.Add(this.btnEditar);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnNuevo);
            this.pnlMenu.Controls.Add(this.btnSalvarActivo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlMenu.Size = new System.Drawing.Size(1352, 45);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 37;
            this.btnEditar.Location = new System.Drawing.Point(62, -1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 36;
            this.btnSalir.Location = new System.Drawing.Point(1310, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 31);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnNuevo.IconColor = System.Drawing.Color.Goldenrod;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 36;
            this.btnNuevo.Location = new System.Drawing.Point(128, -1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 45);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarActivo
            // 
            this.btnSalvarActivo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalvarActivo.FlatAppearance.BorderSize = 0;
            this.btnSalvarActivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnSalvarActivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnSalvarActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarActivo.ForeColor = System.Drawing.Color.White;
            this.btnSalvarActivo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarActivo.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalvarActivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarActivo.IconSize = 35;
            this.btnSalvarActivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarActivo.Location = new System.Drawing.Point(3, 3);
            this.btnSalvarActivo.Name = "btnSalvarActivo";
            this.btnSalvarActivo.Size = new System.Drawing.Size(56, 41);
            this.btnSalvarActivo.TabIndex = 0;
            this.btnSalvarActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarActivo.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.lblListado);
            this.pnlContenido.Controls.Add(this.pnlLinea);
            this.pnlContenido.Controls.Add(this.groupBox1);
            this.pnlContenido.Controls.Add(this.btnGuardar2);
            this.pnlContenido.Controls.Add(this.btnCancelar);
            this.pnlContenido.Controls.Add(this.dGVListadoActivos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 45);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1352, 755);
            this.pnlContenido.TabIndex = 1;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGuardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.ForeColor = System.Drawing.Color.White;
            this.btnGuardar2.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar2.IconColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar2.Location = new System.Drawing.Point(1201, 81);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar2.Size = new System.Drawing.Size(117, 46);
            this.btnGuardar2.TabIndex = 20;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar2.UseVisualStyleBackColor = false;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(894, 68);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(160, 24);
            this.txtCosto.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(894, 28);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 24);
            this.txtPrecio.TabIndex = 18;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(770, 120);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(54, 16);
            this.lblImagen.TabIndex = 17;
            this.lblImagen.Text = "Imagen";
            // 
            // btnImagen
            // 
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImagen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImagen.Location = new System.Drawing.Point(880, 115);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(62, 53);
            this.btnImagen.TabIndex = 16;
            this.btnImagen.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(770, 31);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(84, 16);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio venta";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(770, 75);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(97, 16);
            this.lblCosto.TabIndex = 14;
            this.lblCosto.Text = "Costo Unitario";
            // 
            // cbBoxCantidad
            // 
            this.cbBoxCantidad.FormattingEnabled = true;
            this.cbBoxCantidad.Location = new System.Drawing.Point(541, 67);
            this.cbBoxCantidad.Name = "cbBoxCantidad";
            this.cbBoxCantidad.Size = new System.Drawing.Size(160, 24);
            this.cbBoxCantidad.TabIndex = 13;
            // 
            // cbBoxTipoActivo
            // 
            this.cbBoxTipoActivo.FormattingEnabled = true;
            this.cbBoxTipoActivo.Location = new System.Drawing.Point(541, 26);
            this.cbBoxTipoActivo.Name = "cbBoxTipoActivo";
            this.cbBoxTipoActivo.Size = new System.Drawing.Size(160, 24);
            this.cbBoxTipoActivo.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.Goldenrod;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(1201, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(117, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(449, 76);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 16);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTipoActivo
            // 
            this.lblTipoActivo.AutoSize = true;
            this.lblTipoActivo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoActivo.Location = new System.Drawing.Point(449, 33);
            this.lblTipoActivo.Name = "lblTipoActivo";
            this.lblTipoActivo.Size = new System.Drawing.Size(36, 16);
            this.lblTipoActivo.TabIndex = 7;
            this.lblTipoActivo.Text = "Tipo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // dGVListadoActivos
            // 
            this.dGVListadoActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVListadoActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVListadoActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListadoActivos.Location = new System.Drawing.Point(63, 322);
            this.dGVListadoActivos.Name = "dGVListadoActivos";
            this.dGVListadoActivos.Size = new System.Drawing.Size(1068, 341);
            this.dGVListadoActivos.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(148, 63);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 24);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 24);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // toolTNombre
            // 
            this.toolTNombre.IsBalloon = true;
            // 
            // toolTGuardar
            // 
            this.toolTGuardar.IsBalloon = true;
            // 
            // toolTEditar
            // 
            this.toolTEditar.IsBalloon = true;
            // 
            // toolTNuevo
            // 
            this.toolTNuevo.IsBalloon = true;
            // 
            // toolTDescripcion
            // 
            this.toolTDescripcion.IsBalloon = true;
            // 
            // toolTTipoActivo
            // 
            this.toolTTipoActivo.IsBalloon = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbBoxEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtDetalles);
            this.groupBox1.Controls.Add(this.lblDetalles);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblImagen);
            this.groupBox1.Controls.Add(this.lblTipoActivo);
            this.groupBox1.Controls.Add(this.btnImagen);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cbBoxTipoActivo);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.cbBoxCantidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 208);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(597, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 19);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Ventana de Activos";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(148, 112);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(282, 24);
            this.txtDetalles.TabIndex = 20;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(9, 115);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(133, 16);
            this.lblDetalles.TabIndex = 21;
            this.lblDetalles.Text = "Detalles Adicionales";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(449, 120);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 16);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado";
            // 
            // cbBoxEstado
            // 
            this.cbBoxEstado.FormattingEnabled = true;
            this.cbBoxEstado.Location = new System.Drawing.Point(541, 115);
            this.cbBoxEstado.Name = "cbBoxEstado";
            this.cbBoxEstado.Size = new System.Drawing.Size(160, 24);
            this.cbBoxEstado.TabIndex = 23;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblListado.Location = new System.Drawing.Point(66, 278);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(220, 19);
            this.lblListado.TabIndex = 22;
            this.lblListado.Text = "Listado actualizado de Activos";
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.Black;
            this.pnlLinea.Location = new System.Drawing.Point(63, 300);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(223, 1);
            this.pnlLinea.TabIndex = 23;
            // 
            // toolTCerrar
            // 
            this.toolTCerrar.IsBalloon = true;
            // 
            // toolTGuardar2
            // 
            this.toolTGuardar2.IsBalloon = true;
            // 
            // toolTCancelar
            // 
            this.toolTCancelar.IsBalloon = true;
            // 
            // toolTDetalles
            // 
            this.toolTDetalles.IsBalloon = true;
            // 
            // toolTPrecio
            // 
            this.toolTPrecio.IsBalloon = true;
            // 
            // toolTCosto
            // 
            this.toolTCosto.IsBalloon = true;
            // 
            // toolTImagen
            // 
            this.toolTImagen.IsBalloon = true;
            // 
            // toolTListado
            // 
            this.toolTListado.IsBalloon = true;
            // 
            // toolTEstado
            // 
            this.toolTEstado.IsBalloon = true;
            // 
            // toolTCantidad
            // 
            this.toolTCantidad.IsBalloon = true;
            // 
            // frmMantActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 800);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantActivo";
            this.Text = "Ventana de Activos";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoActivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnSalvarActivo;
        private System.Windows.Forms.Panel pnlContenido;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTipoActivo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dGVListadoActivos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolTip toolTNombre;
        private System.Windows.Forms.ComboBox cbBoxTipoActivo;
        private System.Windows.Forms.ComboBox cbBoxCantidad;
        private System.Windows.Forms.ToolTip toolTGuardar;
        private System.Windows.Forms.ToolTip toolTEditar;
        private System.Windows.Forms.ToolTip toolTNuevo;
        private System.Windows.Forms.ToolTip toolTDescripcion;
        private System.Windows.Forms.ToolTip toolTTipoActivo;
        private FontAwesome.Sharp.IconButton btnGuardar2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblImagen;
        private FontAwesome.Sharp.IconButton btnImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ComboBox cbBoxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.ToolTip toolTCerrar;
        private System.Windows.Forms.ToolTip toolTGuardar2;
        private System.Windows.Forms.ToolTip toolTCancelar;
        private System.Windows.Forms.ToolTip toolTDetalles;
        private System.Windows.Forms.ToolTip toolTPrecio;
        private System.Windows.Forms.ToolTip toolTCosto;
        private System.Windows.Forms.ToolTip toolTImagen;
        private System.Windows.Forms.ToolTip toolTListado;
        private System.Windows.Forms.ToolTip toolTEstado;
        private System.Windows.Forms.ToolTip toolTCantidad;
    }
}