namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.tlUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbConfirmarClave = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.tlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlUsuario
            // 
            this.tlUsuario.ColumnCount = 4;
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88732F));
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.11268F));
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tlUsuario.Controls.Add(this.lbID, 0, 0);
            this.tlUsuario.Controls.Add(this.lbNombre, 0, 1);
            this.tlUsuario.Controls.Add(this.lbEmail, 0, 2);
            this.tlUsuario.Controls.Add(this.lbClave, 0, 3);
            this.tlUsuario.Controls.Add(this.lbApellido, 2, 1);
            this.tlUsuario.Controls.Add(this.lbUsuario, 2, 2);
            this.tlUsuario.Controls.Add(this.lbConfirmarClave, 2, 3);
            this.tlUsuario.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlUsuario.Controls.Add(this.btnAceptar, 2, 4);
            this.tlUsuario.Controls.Add(this.btnCancelar, 3, 4);
            this.tlUsuario.Controls.Add(this.txtNombre, 1, 1);
            this.tlUsuario.Controls.Add(this.txtEmail, 1, 2);
            this.tlUsuario.Controls.Add(this.txtClave, 1, 3);
            this.tlUsuario.Controls.Add(this.txtID, 1, 0);
            this.tlUsuario.Controls.Add(this.txtApellido, 3, 1);
            this.tlUsuario.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlUsuario.Controls.Add(this.txtUsuario, 3, 2);
            this.tlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlUsuario.Name = "tlUsuario";
            this.tlUsuario.RowCount = 5;
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlUsuario.Size = new System.Drawing.Size(605, 165);
            this.tlUsuario.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 15);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(3, 32);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 64);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(3, 97);
            this.lbClave.Name = "lbClave";
            this.lbClave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbClave.Size = new System.Drawing.Size(36, 15);
            this.lbClave.TabIndex = 3;
            this.lbClave.Text = "Clave";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(284, 32);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(51, 15);
            this.lbApellido.TabIndex = 5;
            this.lbApellido.Text = "Apellido";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(284, 64);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(47, 15);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbConfirmarClave
            // 
            this.lbConfirmarClave.AutoSize = true;
            this.lbConfirmarClave.Location = new System.Drawing.Point(284, 97);
            this.lbConfirmarClave.Name = "lbConfirmarClave";
            this.lbConfirmarClave.Size = new System.Drawing.Size(64, 30);
            this.lbConfirmarClave.TabIndex = 7;
            this.lbConfirmarClave.Text = "Confirmar Clave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(284, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(81, 19);
            this.chkHabilitado.TabIndex = 8;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(284, 130);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(373, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(67, 100);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(175, 23);
            this.txtClave.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(373, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 23);
            this.txtApellido.TabIndex = 16;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(373, 100);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(204, 23);
            this.txtConfirmarClave.TabIndex = 18;
            this.txtConfirmarClave.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(373, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 23);
            this.txtUsuario.TabIndex = 17;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 165);
            this.Controls.Add(this.tlUsuario);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.tlUsuario.ResumeLayout(false);
            this.tlUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlUsuario;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbConfirmarClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}