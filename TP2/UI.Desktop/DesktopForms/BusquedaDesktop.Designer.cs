namespace UI.Desktop
{
    partial class BusquedaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNroBusqueda = new System.Windows.Forms.Label();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.tbNroBusqueda = new System.Windows.Forms.TextBox();
            this.tbFechaDesde = new System.Windows.Forms.TextBox();
            this.tbFechaHas = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDetalleAmpliado = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDetalleAmpliado = new System.Windows.Forms.TextBox();
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.22535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.77465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.lbNroBusqueda, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbFechaDesde, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbFechaHasta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNroBusqueda, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbFechaDesde, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbFechaHas, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDetalleAmpliado, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDetalleAmpliado, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkTipo, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbNroBusqueda
            // 
            this.lbNroBusqueda.AutoSize = true;
            this.lbNroBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNroBusqueda.Location = new System.Drawing.Point(3, 0);
            this.lbNroBusqueda.Name = "lbNroBusqueda";
            this.lbNroBusqueda.Size = new System.Drawing.Size(75, 35);
            this.lbNroBusqueda.TabIndex = 0;
            this.lbNroBusqueda.Text = "Nro Busqueda";
            this.lbNroBusqueda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNroBusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.Location = new System.Drawing.Point(280, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(85, 23);
            this.lbFechaDesde.TabIndex = 4;
            this.lbFechaDesde.Text = "Fecha Desde";
            this.lbFechaDesde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbFechaDesde.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.Location = new System.Drawing.Point(280, 35);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(85, 23);
            this.lbFechaHasta.TabIndex = 5;
            this.lbFechaHasta.Text = "Fecha Hasta";
            this.lbFechaHasta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbFechaHasta.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkHabilitado.Location = new System.Drawing.Point(280, 76);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(85, 36);
            this.chkHabilitado.TabIndex = 6;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbNroBusqueda
            // 
            this.tbNroBusqueda.Location = new System.Drawing.Point(84, 3);
            this.tbNroBusqueda.Name = "tbNroBusqueda";
            this.tbNroBusqueda.ReadOnly = true;
            this.tbNroBusqueda.Size = new System.Drawing.Size(190, 23);
            this.tbNroBusqueda.TabIndex = 7;
            // 
            // tbFechaDesde
            // 
            this.tbFechaDesde.Location = new System.Drawing.Point(371, 3);
            this.tbFechaDesde.Name = "tbFechaDesde";
            this.tbFechaDesde.ReadOnly = true;
            this.tbFechaDesde.Size = new System.Drawing.Size(124, 23);
            this.tbFechaDesde.TabIndex = 11;
            // 
            // tbFechaHas
            // 
            this.tbFechaHas.Location = new System.Drawing.Point(371, 38);
            this.tbFechaHas.Name = "tbFechaHas";
            this.tbFechaHas.ReadOnly = true;
            this.tbFechaHas.Size = new System.Drawing.Size(124, 23);
            this.tbFechaHas.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(280, 157);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 157);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.Location = new System.Drawing.Point(3, 35);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 23);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDetalleAmpliado
            // 
            this.lbDetalleAmpliado.Location = new System.Drawing.Point(3, 73);
            this.lbDetalleAmpliado.Name = "lbDetalleAmpliado";
            this.lbDetalleAmpliado.Size = new System.Drawing.Size(75, 39);
            this.lbDetalleAmpliado.TabIndex = 3;
            this.lbDetalleAmpliado.Text = "Detalle Ampliado";
            this.lbDetalleAmpliado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(84, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 23);
            this.tbNombre.TabIndex = 9;
            // 
            // tbDetalleAmpliado
            // 
            this.tbDetalleAmpliado.Location = new System.Drawing.Point(84, 76);
            this.tbDetalleAmpliado.Name = "tbDetalleAmpliado";
            this.tbDetalleAmpliado.Size = new System.Drawing.Size(190, 23);
            this.tbDetalleAmpliado.TabIndex = 10;
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Checked = true;
            this.chkTipo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTipo.Location = new System.Drawing.Point(280, 118);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(49, 19);
            this.chkTipo.TabIndex = 15;
            this.chkTipo.Text = "Tipo";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // BusquedaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusquedaDesktop";
            this.Text = "BusquedaDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbNroBusqueda;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDetalleAmpliado;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox tbNroBusqueda;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDetalleAmpliado;
        private System.Windows.Forms.TextBox tbFechaDesde;
        private System.Windows.Forms.TextBox tbFechaHas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkTipo;
    }
}