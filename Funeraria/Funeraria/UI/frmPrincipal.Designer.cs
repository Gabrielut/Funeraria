namespace UTN.Winform.Funeraria.UI
{
    partial class frmPrincipal
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

            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picBoxLogo = new FontAwesome.Sharp.IconPictureBox();
            this.btnMantenimientos = new FontAwesome.Sharp.IconButton();
            this.pnlMantenimientos = new System.Windows.Forms.Panel();
            this.btnMantActivos = new System.Windows.Forms.Button();
            this.btnMantProveedores = new System.Windows.Forms.Button();
            this.btnMantClientes = new System.Windows.Forms.Button();
            this.btnMantPaquetes = new System.Windows.Forms.Button();
            this.btnMantEmpleados = new System.Windows.Forms.Button();
            this.btnMenuHerramientas = new FontAwesome.Sharp.IconButton();
            this.pnlHerramientas = new System.Windows.Forms.Panel();
            this.btnCotizaciones = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnRptActivos = new System.Windows.Forms.Button();
            this.btnRptProveedores = new System.Windows.Forms.Button();
            this.btnRptClientes = new System.Windows.Forms.Button();
            this.btnRptPaquetes = new System.Windows.Forms.Button();
            this.btnRptEmpleados = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlMantenimientos.SuspendLayout();
            this.pnlHerramientas.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlContenedor.SuspendLayout();

            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(541, 712);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 11);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnMaximizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 52);
            this.panel2.TabIndex = 2;

            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(1262, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 31);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.Location = new System.Drawing.Point(1222, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 27);
            this.btnMaximizar.TabIndex = 19;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(1191, 13);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 28);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.pnlMenu.Controls.Add(this.iconButton1);
            this.pnlMenu.Controls.Add(this.pnlReportes);
            this.pnlMenu.Controls.Add(this.iconButton2);
            this.pnlMenu.Controls.Add(this.pnlHerramientas);
            this.pnlMenu.Controls.Add(this.btnMenuHerramientas);
            this.pnlMenu.Controls.Add(this.pnlMantenimientos);
            this.pnlMenu.Controls.Add(this.btnMantenimientos);
            this.pnlMenu.Controls.Add(this.picBoxLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 52);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(256, 741);
            this.pnlMenu.TabIndex = 3;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picBoxLogo.IconChar = FontAwesome.Sharp.IconChar.Poo;
            this.picBoxLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.picBoxLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picBoxLogo.IconSize = 64;
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(256, 64);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.btnMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientos.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnMantenimientos.IconColor = System.Drawing.Color.White;
            this.btnMantenimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientos.IconSize = 45;
            this.btnMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(256, 48);
            this.btnMantenimientos.TabIndex = 1;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMantenimientos.UseVisualStyleBackColor = false;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMenuMantenimientos_Click);
            // 
            // pnlMantenimientos
            // 
            this.pnlMantenimientos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMantenimientos.Controls.Add(this.btnMantEmpleados);
            this.pnlMantenimientos.Controls.Add(this.btnMantPaquetes);
            this.pnlMantenimientos.Controls.Add(this.btnMantClientes);
            this.pnlMantenimientos.Controls.Add(this.btnMantProveedores);
            this.pnlMantenimientos.Controls.Add(this.btnMantActivos);
            this.pnlMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMantenimientos.Location = new System.Drawing.Point(0, 48);
            this.pnlMantenimientos.Name = "pnlMantenimientos";
            this.pnlMantenimientos.Size = new System.Drawing.Size(256, 201);
            this.pnlMantenimientos.TabIndex = 2;
            // 
            // btnMantActivos
            // 
            this.btnMantActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMantActivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantActivos.FlatAppearance.BorderSize = 0;
            this.btnMantActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMantActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMantActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantActivos.ForeColor = System.Drawing.Color.White;
            this.btnMantActivos.Location = new System.Drawing.Point(0, 0);
            this.btnMantActivos.Name = "btnMantActivos";
            this.btnMantActivos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantActivos.Size = new System.Drawing.Size(256, 40);
            this.btnMantActivos.TabIndex = 0;
            this.btnMantActivos.Text = "Activos";
            this.btnMantActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantActivos.UseVisualStyleBackColor = false;
            // 
            // btnMantProveedores
            // 
            this.btnMantProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMantProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantProveedores.FlatAppearance.BorderSize = 0;
            this.btnMantProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMantProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMantProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantProveedores.ForeColor = System.Drawing.Color.White;
            this.btnMantProveedores.Location = new System.Drawing.Point(0, 40);
            this.btnMantProveedores.Name = "btnMantProveedores";
            this.btnMantProveedores.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantProveedores.Size = new System.Drawing.Size(256, 40);
            this.btnMantProveedores.TabIndex = 1;
            this.btnMantProveedores.Text = "Proveedores";
            this.btnMantProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantProveedores.UseVisualStyleBackColor = false;
            // 
            // btnMantClientes
            // 
            this.btnMantClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMantClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantClientes.FlatAppearance.BorderSize = 0;
            this.btnMantClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMantClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMantClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantClientes.ForeColor = System.Drawing.Color.White;
            this.btnMantClientes.Location = new System.Drawing.Point(0, 80);
            this.btnMantClientes.Name = "btnMantClientes";
            this.btnMantClientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantClientes.Size = new System.Drawing.Size(256, 40);
            this.btnMantClientes.TabIndex = 2;
            this.btnMantClientes.Text = "Clientes";
            this.btnMantClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantClientes.UseVisualStyleBackColor = false;
            // 
            // btnMantPaquetes
            // 
            this.btnMantPaquetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMantPaquetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantPaquetes.FlatAppearance.BorderSize = 0;
            this.btnMantPaquetes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMantPaquetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMantPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantPaquetes.ForeColor = System.Drawing.Color.White;
            this.btnMantPaquetes.Location = new System.Drawing.Point(0, 120);
            this.btnMantPaquetes.Name = "btnMantPaquetes";
            this.btnMantPaquetes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantPaquetes.Size = new System.Drawing.Size(256, 40);
            this.btnMantPaquetes.TabIndex = 3;
            this.btnMantPaquetes.Text = "Paquetes";
            this.btnMantPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantPaquetes.UseVisualStyleBackColor = false;
            // 
            // btnMantEmpleados
            // 
            this.btnMantEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMantEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantEmpleados.FlatAppearance.BorderSize = 0;
            this.btnMantEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMantEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnMantEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnMantEmpleados.Location = new System.Drawing.Point(0, 160);
            this.btnMantEmpleados.Name = "btnMantEmpleados";
            this.btnMantEmpleados.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantEmpleados.Size = new System.Drawing.Size(256, 41);
            this.btnMantEmpleados.TabIndex = 4;
            this.btnMantEmpleados.Text = "Empleados";
            this.btnMantEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnMenuHerramientas
            // 
            this.btnMenuHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.btnMenuHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuHerramientas.FlatAppearance.BorderSize = 0;
            this.btnMenuHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHerramientas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHerramientas.ForeColor = System.Drawing.Color.White;
            this.btnMenuHerramientas.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnMenuHerramientas.IconColor = System.Drawing.Color.White;
            this.btnMenuHerramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuHerramientas.IconSize = 45;
            this.btnMenuHerramientas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuHerramientas.Location = new System.Drawing.Point(0, 249);
            this.btnMenuHerramientas.Name = "btnMenuHerramientas";
            this.btnMenuHerramientas.Size = new System.Drawing.Size(256, 48);
            this.btnMenuHerramientas.TabIndex = 3;
            this.btnMenuHerramientas.Text = "Herramientas";
            this.btnMenuHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenuHerramientas.UseVisualStyleBackColor = false;
            this.btnMenuHerramientas.Click += new System.EventHandler(this.btnMenuHerramientas_Click);
            // 
            // pnlHerramientas
            // 
            this.pnlHerramientas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHerramientas.Controls.Add(this.btnCotizaciones);
            this.pnlHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHerramientas.Location = new System.Drawing.Point(0, 297);
            this.pnlHerramientas.Name = "pnlHerramientas";
            this.pnlHerramientas.Size = new System.Drawing.Size(256, 43);
            this.pnlHerramientas.TabIndex = 4;
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCotizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCotizaciones.FlatAppearance.BorderSize = 0;
            this.btnCotizaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnCotizaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizaciones.ForeColor = System.Drawing.Color.White;
            this.btnCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCotizaciones.Size = new System.Drawing.Size(256, 43);
            this.btnCotizaciones.TabIndex = 0;
            this.btnCotizaciones.Text = "Cotizaciones";
            this.btnCotizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizaciones.UseVisualStyleBackColor = false;
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 45;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(0, 340);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(256, 48);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Reportes";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.btnMenuReportes_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlReportes.Controls.Add(this.btnRptEmpleados);
            this.pnlReportes.Controls.Add(this.btnRptPaquetes);
            this.pnlReportes.Controls.Add(this.btnRptClientes);
            this.pnlReportes.Controls.Add(this.btnRptProveedores);
            this.pnlReportes.Controls.Add(this.btnRptActivos);
            this.pnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportes.Location = new System.Drawing.Point(0, 388);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(256, 201);
            this.pnlReportes.TabIndex = 6;
            // 
            // btnRptActivos
            // 
            this.btnRptActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnRptActivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRptActivos.FlatAppearance.BorderSize = 0;
            this.btnRptActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnRptActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnRptActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptActivos.ForeColor = System.Drawing.Color.White;
            this.btnRptActivos.Location = new System.Drawing.Point(0, 0);
            this.btnRptActivos.Name = "btnRptActivos";
            this.btnRptActivos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptActivos.Size = new System.Drawing.Size(256, 45);
            this.btnRptActivos.TabIndex = 0;
            this.btnRptActivos.Text = "Activos";
            this.btnRptActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptActivos.UseVisualStyleBackColor = false;
            // 
            // btnRptProveedores
            // 
            this.btnRptProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnRptProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRptProveedores.FlatAppearance.BorderSize = 0;
            this.btnRptProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnRptProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnRptProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptProveedores.ForeColor = System.Drawing.Color.White;
            this.btnRptProveedores.Location = new System.Drawing.Point(0, 45);
            this.btnRptProveedores.Name = "btnRptProveedores";
            this.btnRptProveedores.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptProveedores.Size = new System.Drawing.Size(256, 40);
            this.btnRptProveedores.TabIndex = 1;
            this.btnRptProveedores.Text = "Proveedores";
            this.btnRptProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptProveedores.UseVisualStyleBackColor = false;
            // 
            // btnRptClientes
            // 
            this.btnRptClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnRptClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRptClientes.FlatAppearance.BorderSize = 0;
            this.btnRptClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnRptClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnRptClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptClientes.ForeColor = System.Drawing.Color.White;
            this.btnRptClientes.Location = new System.Drawing.Point(0, 85);
            this.btnRptClientes.Name = "btnRptClientes";
            this.btnRptClientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptClientes.Size = new System.Drawing.Size(256, 40);
            this.btnRptClientes.TabIndex = 2;
            this.btnRptClientes.Text = "Clientes";
            this.btnRptClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptClientes.UseVisualStyleBackColor = false;
            // 
            // btnRptPaquetes
            // 
            this.btnRptPaquetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnRptPaquetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRptPaquetes.FlatAppearance.BorderSize = 0;
            this.btnRptPaquetes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnRptPaquetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnRptPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptPaquetes.ForeColor = System.Drawing.Color.White;
            this.btnRptPaquetes.Location = new System.Drawing.Point(0, 125);
            this.btnRptPaquetes.Name = "btnRptPaquetes";
            this.btnRptPaquetes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptPaquetes.Size = new System.Drawing.Size(256, 40);
            this.btnRptPaquetes.TabIndex = 3;
            this.btnRptPaquetes.Text = "Paquetes";
            this.btnRptPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptPaquetes.UseVisualStyleBackColor = false;
            // 
            // btnRptEmpleados
            // 
            this.btnRptEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnRptEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRptEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRptEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnRptEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnRptEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnRptEmpleados.Location = new System.Drawing.Point(0, 165);
            this.btnRptEmpleados.Name = "btnRptEmpleados";
            this.btnRptEmpleados.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptEmpleados.Size = new System.Drawing.Size(256, 36);
            this.btnRptEmpleados.TabIndex = 4;
            this.btnRptEmpleados.Text = "Empleados";
            this.btnRptEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptEmpleados.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 589);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(256, 48);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Ayuda";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlContenedor.Controls.Add(this.pnlFormularios);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Controls.Add(this.panel2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1297, 793);
            this.pnlContenedor.TabIndex = 5;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(256, 52);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(1041, 741);
            this.pnlFormularios.TabIndex = 4;

            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
                               // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnMenuMantenimientos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 3;
            //            
       

            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;

            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1297, 793);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;


            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel2.ResumeLayout(false);

            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlMantenimientos.ResumeLayout(false);
            this.pnlHerramientas.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);

            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnRptEmpleados;
        private System.Windows.Forms.Button btnRptPaquetes;
        private System.Windows.Forms.Button btnRptClientes;
        private System.Windows.Forms.Button btnRptProveedores;
        private System.Windows.Forms.Button btnRptActivos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel pnlHerramientas;
        private System.Windows.Forms.Button btnCotizaciones;
        private FontAwesome.Sharp.IconButton btnMenuHerramientas;
        private System.Windows.Forms.Panel pnlMantenimientos;
        private System.Windows.Forms.Button btnMantEmpleados;
        private System.Windows.Forms.Button btnMantPaquetes;
        private System.Windows.Forms.Button btnMantClientes;
        private System.Windows.Forms.Button btnMantProveedores;
        private System.Windows.Forms.Button btnMantActivos;
        private FontAwesome.Sharp.IconButton btnMantenimientos;
        private FontAwesome.Sharp.IconPictureBox picBoxLogo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlFormularios;

    }
}