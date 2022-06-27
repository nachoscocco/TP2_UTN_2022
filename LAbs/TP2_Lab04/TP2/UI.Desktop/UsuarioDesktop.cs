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


        public UsuarioDesktop(int IdUsuario, ModoForm modo)
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
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
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
    }
}
