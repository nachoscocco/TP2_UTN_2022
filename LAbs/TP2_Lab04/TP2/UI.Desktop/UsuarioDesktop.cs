using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {

        public Business.Entities.Usuario UsuarioActual { get; set; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public UsuarioDesktop(int IdUsuario, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic usrLogic = new UsuarioLogic();
            UsuarioActual = usrLogic.GetOne(IdUsuario);
            MapearDeDatos();

        }
        public void SetModeValue( ModoForm modo) 
        {
            if (modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (modo == ModoForm.Alta || modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearDeDatos()
        {
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            SetModeValue(Modo);

        }

        public override void MapearADatos()
        {
            switch(Modo)
            {
                case ModoForm.Alta:
                    UsuarioActual = new Business.Entities.Usuario();
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    UsuarioActual = new Business.Entities.Usuario();
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
            }
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //public override bool Validar()
        //{
        //    if (txtApellido.Text.Equals(String.Empty) || txtNombre.Text.Equals(String.Empty) ||
        //        txtClave.Text.Equals(String.Empty) || txtEmail.Text.Equals(String.Empty) ||
        //        txtConfirmarClave.Text.Equals(String.Empty) || txtUsuario.Text.Equals(String.Empty))
        //        return false;
        //    else if (txtClave.Text.Equals(txtConfirmarClave.Text))
        //        return false;
        //    else if (txtClave.Text.Length() < 8 || )
        //        }
        public override bool Validar()
        {
            String[] controles = { txtNombre.Text, txtEmail.Text, txtClave.Text, txtApellido.Text, txtUsuario.Text, txtConfirmarClave.Text };
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("Contraseña Invalida", "Las contaseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!email_bien_escrito(txtEmail.Text))
            {
                Notificar("Email Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "^[^@]+@[^@]+.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usr = new UsuarioLogic();
            usr.Save(UsuarioActual);
            // Ver notas de laboratorio 4 punto 18;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
