
namespace UTN.Winform.Funeraria.UI
{
    partial class frmCotizacion
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
            this.btnEditarCotizacion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnSalvarCotizacion = new FontAwesome.Sharp.IconButton();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnEditarCotizacion);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnSalvarCotizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnEditarCotizacion
            // 
            this.btnEditarCotizacion.FlatAppearance.BorderSize = 0;
            this.btnEditarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCotizacion.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCotizacion.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEditarCotizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCotizacion.IconSize = 36;
            this.btnEditarCotizacion.Location = new System.Drawing.Point(77, 0);
            this.btnEditarCotizacion.Name = "btnEditarCotizacion";
            this.btnEditarCotizacion.Size = new System.Drawing.Size(60, 55);
            this.btnEditarCotizacion.TabIndex = 3;
            this.btnEditarCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 36;
            this.btnSalir.Location = new System.Drawing.Point(1283, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnNuevo.IconColor = System.Drawing.Color.Goldenrod;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 36;
            this.btnNuevo.Location = new System.Drawing.Point(143, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 45);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCotizacion
            // 
            this.btnSalvarCotizacion.FlatAppearance.BorderSize = 0;
            this.btnSalvarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCotizacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarCotizacion.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalvarCotizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarCotizacion.IconSize = 36;
            this.btnSalvarCotizacion.Location = new System.Drawing.Point(23, 6);
            this.btnSalvarCotizacion.Name = "btnSalvarCotizacion";
            this.btnSalvarCotizacion.Size = new System.Drawing.Size(48, 45);
            this.btnSalvarCotizacion.TabIndex = 0;
            this.btnSalvarCotizacion.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.checkedListBox3);
            this.pnlContenido.Controls.Add(this.checkedListBox2);
            this.pnlContenido.Controls.Add(this.checkedListBox1);
            this.pnlContenido.Controls.Add(this.listBox1);
            this.pnlContenido.Controls.Add(this.groupBox1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 51);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1336, 665);
            this.pnlContenido.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(590, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 21);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Cotizaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(57, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(485, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 173);
            this.listBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(798, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 34);
            this.checkedListBox1.TabIndex = 2;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(798, 105);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 34);
            this.checkedListBox2.TabIndex = 3;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(798, 160);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 34);
            this.checkedListBox3.TabIndex = 4;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 716);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCotizacion";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditarCotizacion;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnSalvarCotizacion;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}