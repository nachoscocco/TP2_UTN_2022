namespace UI.Desktop
{
    partial class Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.tcBusqueda = new System.Windows.Forms.ToolStripContainer();
            this.tlBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.NroBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleAmpliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsBusqueda = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcBusqueda.ContentPanel.SuspendLayout();
            this.tcBusqueda.TopToolStripPanel.SuspendLayout();
            this.tcBusqueda.SuspendLayout();
            this.tlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.tsBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBusqueda
            // 
            // 
            // tcBusqueda.ContentPanel
            // 
            this.tcBusqueda.ContentPanel.Controls.Add(this.tlBusqueda);
            this.tcBusqueda.ContentPanel.Size = new System.Drawing.Size(948, 534);
            this.tcBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tcBusqueda.Name = "tcBusqueda";
            this.tcBusqueda.Size = new System.Drawing.Size(948, 559);
            this.tcBusqueda.TabIndex = 0;
            this.tcBusqueda.Text = "toolStripContainer1";
            // 
            // tcBusqueda.TopToolStripPanel
            // 
            this.tcBusqueda.TopToolStripPanel.Controls.Add(this.tsBusqueda);
            // 
            // tlBusqueda
            // 
            this.tlBusqueda.ColumnCount = 2;
            this.tlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlBusqueda.Controls.Add(this.btnSalir, 1, 1);
            this.tlBusqueda.Controls.Add(this.dgvBusqueda, 0, 0);
            this.tlBusqueda.Controls.Add(this.btnActualizar, 0, 1);
            this.tlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tlBusqueda.Name = "tlBusqueda";
            this.tlBusqueda.RowCount = 2;
            this.tlBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBusqueda.Size = new System.Drawing.Size(948, 534);
            this.tlBusqueda.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(870, 508);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroBusqueda,
            this.Nombre,
            this.DetalleAmpliado,
            this.FechaDesde,
            this.FechaHasta,
            this.Tipo,
            this.Habilitado});
            this.tlBusqueda.SetColumnSpan(this.dgvBusqueda, 2);
            this.dgvBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusqueda.Location = new System.Drawing.Point(3, 3);
            this.dgvBusqueda.MultiSelect = false;
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowTemplate.Height = 25;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(942, 499);
            this.dgvBusqueda.TabIndex = 0;
            // 
            // NroBusqueda
            // 
            this.NroBusqueda.DataPropertyName = "NroBusqueda";
            this.NroBusqueda.Frozen = true;
            this.NroBusqueda.HeaderText = "Nro Busqueda";
            this.NroBusqueda.Name = "NroBusqueda";
            this.NroBusqueda.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DetalleAmpliado
            // 
            this.DetalleAmpliado.DataPropertyName = "DetalleAmpliado";
            this.DetalleAmpliado.Frozen = true;
            this.DetalleAmpliado.HeaderText = "Detalle Ampliado";
            this.DetalleAmpliado.Name = "DetalleAmpliado";
            this.DetalleAmpliado.ReadOnly = true;
            // 
            // FechaDesde
            // 
            this.FechaDesde.DataPropertyName = "FechaDesde";
            this.FechaDesde.Frozen = true;
            this.FechaDesde.HeaderText = "Fecha Desde";
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ReadOnly = true;
            // 
            // FechaHasta
            // 
            this.FechaHasta.DataPropertyName = "FechaHasta";
            this.FechaHasta.Frozen = true;
            this.FechaHasta.HeaderText = "Fecha Hasta";
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.Frozen = true;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Habilitado
            // 
            this.Habilitado.DataPropertyName = "Habilitado";
            this.Habilitado.Frozen = true;
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            this.Habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(789, 508);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tsBusqueda
            // 
            this.tsBusqueda.Dock = System.Windows.Forms.DockStyle.None;
            this.tsBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsBusqueda.Location = new System.Drawing.Point(3, 0);
            this.tsBusqueda.Name = "tsBusqueda";
            this.tsBusqueda.Size = new System.Drawing.Size(81, 25);
            this.tsBusqueda.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Agregar";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(23, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.tcBusqueda);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.tcBusqueda.ContentPanel.ResumeLayout(false);
            this.tcBusqueda.TopToolStripPanel.ResumeLayout(false);
            this.tcBusqueda.TopToolStripPanel.PerformLayout();
            this.tcBusqueda.ResumeLayout(false);
            this.tcBusqueda.PerformLayout();
            this.tlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.tsBusqueda.ResumeLayout(false);
            this.tsBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcBusqueda;
        private System.Windows.Forms.TableLayoutPanel tlBusqueda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.ToolStrip tsBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleAmpliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}