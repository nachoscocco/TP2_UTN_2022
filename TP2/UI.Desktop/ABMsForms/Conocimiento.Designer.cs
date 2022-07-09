
namespace UI.Desktop.ABMsForms
{
    partial class Conocimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conocimiento));
            this.tcConocimiento = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvConocimiento = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsConocimiento = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcConocimiento.ContentPanel.SuspendLayout();
            this.tcConocimiento.TopToolStripPanel.SuspendLayout();
            this.tcConocimiento.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConocimiento)).BeginInit();
            this.tsConocimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcConocimiento
            // 
            // 
            // tcConocimiento.ContentPanel
            // 
            this.tcConocimiento.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tcConocimiento.ContentPanel.Size = new System.Drawing.Size(349, 502);
            this.tcConocimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConocimiento.Location = new System.Drawing.Point(0, 0);
            this.tcConocimiento.Name = "tcConocimiento";
            this.tcConocimiento.Size = new System.Drawing.Size(349, 527);
            this.tcConocimiento.TabIndex = 0;
            this.tcConocimiento.Text = "toolStripContainer1";
            // 
            // tcConocimiento.TopToolStripPanel
            // 
            this.tcConocimiento.TopToolStripPanel.Controls.Add(this.tsConocimiento);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvConocimiento, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.96676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.033241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvConocimiento
            // 
            this.dgvConocimiento.AllowUserToAddRows = false;
            this.dgvConocimiento.AllowUserToDeleteRows = false;
            this.dgvConocimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConocimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.alta});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvConocimiento, 2);
            this.dgvConocimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConocimiento.Location = new System.Drawing.Point(3, 3);
            this.dgvConocimiento.MultiSelect = false;
            this.dgvConocimiento.Name = "dgvConocimiento";
            this.dgvConocimiento.ReadOnly = true;
            this.dgvConocimiento.RowTemplate.Height = 25;
            this.dgvConocimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConocimiento.Size = new System.Drawing.Size(343, 455);
            this.dgvConocimiento.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "idConocimiento";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // alta
            // 
            this.alta.DataPropertyName = "Alta";
            this.alta.HeaderText = "Disponible";
            this.alta.Name = "alta";
            this.alta.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(190, 464);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Actualizar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 464);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsConocimiento
            // 
            this.tsConocimiento.Dock = System.Windows.Forms.DockStyle.None;
            this.tsConocimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsEditar,
            this.tsEliminar});
            this.tsConocimiento.Location = new System.Drawing.Point(9, 0);
            this.tsConocimiento.Name = "tsConocimiento";
            this.tsConocimiento.Size = new System.Drawing.Size(112, 25);
            this.tsConocimiento.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsEditar.Image")));
            this.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(23, 22);
            this.tsEditar.Text = "Editar";
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // Conocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 527);
            this.Controls.Add(this.tcConocimiento);
            this.Name = "Conocimiento";
            this.Text = "Conocimientos";
            this.Load += new System.EventHandler(this.Conocimiento_Load);
            this.tcConocimiento.ContentPanel.ResumeLayout(false);
            this.tcConocimiento.TopToolStripPanel.ResumeLayout(false);
            this.tcConocimiento.TopToolStripPanel.PerformLayout();
            this.tcConocimiento.ResumeLayout(false);
            this.tcConocimiento.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConocimiento)).EndInit();
            this.tsConocimiento.ResumeLayout(false);
            this.tsConocimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcConocimiento;
        private System.Windows.Forms.DataGridView dgvConocimiento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsConocimiento;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn alta;
    }
}