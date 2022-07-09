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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public Business.Entities.Especialidad EspecialidadActual { get; set; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public EspecialidadDesktop(int IdEspecialidad, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic espLogic = new EspecialidadLogic();
            EspecialidadActual = espLogic.GetOne(IdEspecialidad);
            MapearDeDatos();

        }
        public void SetModeValue(ModoForm modo)
        {
            if (modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (modo == ModoForm.Alta || modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearDeDatos()
        {
            this.txtNombre.Text = this.EspecialidadActual.NombreEspecialidad;
            this.txtID.Text = this.EspecialidadActual.IdEspecialidad.ToString();
            this.chkAlta.Checked = this.EspecialidadActual.Alta;
            SetModeValue(Modo);
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    EspecialidadActual = new Business.Entities.Especialidad();
                    this.EspecialidadActual.NombreEspecialidad = this.txtNombre.Text;
                    this.EspecialidadActual.Alta = this.chkAlta.Checked;
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    EspecialidadActual = new Business.Entities.Especialidad();
                    this.EspecialidadActual.NombreEspecialidad = this.txtNombre.Text;
                    this.EspecialidadActual.IdEspecialidad = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.Alta = this.chkAlta.Checked;
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.EspecialidadActual.State = BusinessEntity.States.Deleted;
                    break;
            }
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
            String[] controles = { txtNombre.Text };
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic esp = new EspecialidadLogic();
            esp.Save(EspecialidadActual);
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
