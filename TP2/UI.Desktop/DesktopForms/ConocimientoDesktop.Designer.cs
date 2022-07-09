
namespace UI.Desktop.DesktopForms
{
    partial class ConocimientoDesktop
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
            this.tlConocimiento = new System.Windows.Forms.TableLayoutPanel();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbAlta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.tlConocimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlConocimiento
            // 
            this.tlConocimiento.ColumnCount = 3;
            this.tlConocimiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.53488F));
            this.tlConocimiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.46512F));
            this.tlConocimiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlConocimiento.Controls.Add(this.lbID, 0, 0);
            this.tlConocimiento.Controls.Add(this.lbNombre, 0, 1);
            this.tlConocimiento.Controls.Add(this.lbAlta, 0, 2);
            this.tlConocimiento.Controls.Add(this.btnAceptar, 1, 3);
            this.tlConocimiento.Controls.Add(this.btnSalir, 2, 3);
            this.tlConocimiento.Controls.Add(this.txtID, 1, 0);
            this.tlConocimiento.Controls.Add(this.txtNombre, 1, 1);
            this.tlConocimiento.Controls.Add(this.chkAlta, 1, 2);
            this.tlConocimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlConocimiento.Location = new System.Drawing.Point(0, 0);
            this.tlConocimiento.Name = "tlConocimiento";
            this.tlConocimiento.RowCount = 4;
            this.tlConocimiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tlConocimiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tlConocimiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlConocimiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlConocimiento.Size = new System.Drawing.Size(569, 122);
            this.tlConocimiento.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(65, 29);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombre.Location = new System.Drawing.Point(3, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 32);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbAlta
            // 
            this.lbAlta.AutoSize = true;
            this.lbAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAlta.Location = new System.Drawing.Point(3, 61);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(65, 33);
            this.lbAlta.TabIndex = 2;
            this.lbAlta.Text = "Disponible";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(412, 97);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 22);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(493, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 22);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.Location = new System.Drawing.Point(210, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(140, 23);
            this.txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Location = new System.Drawing.Point(210, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // chkAlta
            // 
            this.chkAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chkAlta.AutoSize = true;
            this.chkAlta.Location = new System.Drawing.Point(240, 64);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(81, 27);
            this.chkAlta.TabIndex = 7;
            this.chkAlta.Text = "Habilitado";
            this.chkAlta.UseVisualStyleBackColor = true;
            // 
            // ConocimientoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 122);
            this.Controls.Add(this.tlConocimiento);
            this.Name = "ConocimientoDesktop";
            this.Text = "ConocimientoDesktop";
            this.Load += new System.EventHandler(this.ConocimientoDesktop_Load);
            this.tlConocimiento.ResumeLayout(false);
            this.tlConocimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlConocimiento;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbAlta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkAlta;
    }
}