
namespace UI.Desktop
{
    partial class Main
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
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnBusquedas = new System.Windows.Forms.Button();
            this.btnConocimientos = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 2;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.Controls.Add(this.btnUsuarios, 0, 0);
            this.tlMain.Controls.Add(this.btnBusquedas, 1, 0);
            this.tlMain.Controls.Add(this.btnConocimientos, 0, 1);
            this.tlMain.Controls.Add(this.btnEspecialidad, 1, 1);
            this.tlMain.Controls.Add(this.btnSalir, 1, 2);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 3;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.Size = new System.Drawing.Size(502, 148);
            this.tlMain.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Location = new System.Drawing.Point(3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(245, 50);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnBusquedas
            // 
            this.btnBusquedas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedas.Location = new System.Drawing.Point(254, 3);
            this.btnBusquedas.Name = "btnBusquedas";
            this.btnBusquedas.Size = new System.Drawing.Size(245, 50);
            this.btnBusquedas.TabIndex = 1;
            this.btnBusquedas.Text = "Busquedas";
            this.btnBusquedas.UseVisualStyleBackColor = true;
            this.btnBusquedas.Click += new System.EventHandler(this.btnBusquedas_Click);
            // 
            // btnConocimientos
            // 
            this.btnConocimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConocimientos.Location = new System.Drawing.Point(3, 59);
            this.btnConocimientos.Name = "btnConocimientos";
            this.btnConocimientos.Size = new System.Drawing.Size(245, 48);
            this.btnConocimientos.TabIndex = 2;
            this.btnConocimientos.Text = "Conocimientos";
            this.btnConocimientos.UseVisualStyleBackColor = true;
            this.btnConocimientos.Click += new System.EventHandler(this.btnConocimientos_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEspecialidad.Location = new System.Drawing.Point(254, 59);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(245, 48);
            this.btnEspecialidad.TabIndex = 3;
            this.btnEspecialidad.Text = "Especialidades";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(424, 113);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 148);
            this.Controls.Add(this.tlMain);
            this.Name = "Main";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnBusquedas;
        private System.Windows.Forms.Button btnConocimientos;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnSalir;
    }
}