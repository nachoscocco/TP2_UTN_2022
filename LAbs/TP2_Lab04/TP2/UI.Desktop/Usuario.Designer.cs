
namespace UI.Desktop
{
    partial class Usuario
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
            this.tcUsuario = new System.Windows.Forms.ToolStripContainer();
            this.tlUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.tsUsuario = new System.Windows.Forms.ToolStrip();
            this.dvgUsuario = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tcUsuario.ContentPanel.SuspendLayout();
            this.tcUsuario.TopToolStripPanel.SuspendLayout();
            this.tcUsuario.SuspendLayout();
            this.tlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsuario
            // 
            // 
            // tcUsuario.tcUsuario
            // 
            this.tcUsuario.ContentPanel.Controls.Add(this.tlUsuario);
            this.tcUsuario.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuario.Location = new System.Drawing.Point(0, 0);
            this.tcUsuario.Name = "tcUsuario";
            this.tcUsuario.Size = new System.Drawing.Size(800, 450);
            this.tcUsuario.TabIndex = 0;
            this.tcUsuario.Text = "toolStripContainer1";
            // 
            // tcUsuario.tsUsuario
            // 
            this.tcUsuario.TopToolStripPanel.Controls.Add(this.tsUsuario);
            // 
            // tlUsuario
            // 
            this.tlUsuario.ColumnCount = 2;
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuario.Controls.Add(this.dvgUsuario, 0, 0);
            this.tlUsuario.Controls.Add(this.btnActualizar, 0, 1);
            this.tlUsuario.Controls.Add(this.btnSalir, 1, 1);
            this.tlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlUsuario.Name = "tlUsuario";
            this.tlUsuario.RowCount = 2;
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuario.Size = new System.Drawing.Size(800, 425);
            this.tlUsuario.TabIndex = 0;
            // 
            // tsUsuario
            // 
            this.tsUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuario.Location = new System.Drawing.Point(3, 0);
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(111, 25);
            this.tsUsuario.TabIndex = 0;
            // 
            // dvgUsuario
            // 
            this.dvgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlUsuario.SetColumnSpan(this.dvgUsuario, 2);
            this.dvgUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgUsuario.Location = new System.Drawing.Point(3, 3);
            this.dvgUsuario.Name = "dvgUsuario";
            this.dvgUsuario.RowTemplate.Height = 25;
            this.dvgUsuario.Size = new System.Drawing.Size(794, 390);
            this.dvgUsuario.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcUsuario.ContentPanel.ResumeLayout(false);
            this.tcUsuario.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuario.TopToolStripPanel.PerformLayout();
            this.tcUsuario.ResumeLayout(false);
            this.tcUsuario.PerformLayout();
            this.tlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuario;
        private System.Windows.Forms.TableLayoutPanel tlUsuario;
        private System.Windows.Forms.DataGridView dvgUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsUsuario;
    }
}