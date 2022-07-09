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

namespace UI.Desktop.DesktopForms
{
    public partial class ConocimientoDesktop : ApplicationForm
    {
        public ConocimientoDesktop()
        {
            InitializeComponent();
        }

        private void ConocimientoDesktop_Load(object sender, EventArgs e)
        {

        }

        public Business.Entities.Conocimiento ConocimientoActual { get; set; }
        public ConocimientoDesktop(ModoForm modo) : this()
        {
                Modo = modo;
        }


            public ConocimientoDesktop(int IdConocimiento, ModoForm modo) : this()
        {
                Modo = modo;
                ConocimientoLogic cnoLogic = new ConocimientoLogic();
                ConocimientoActual = cnoLogic.GetOne(IdConocimiento);
                MapearDeDatos();

            }
            public void SetModeValue(ModoForm modo)
            {
            if (modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (modo == ModoForm.Alta || modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (modo == ModoForm.Baja) { this.btnAceptar.Text = "Eliminar"; this.txtNombre.ReadOnly = true; this.chkAlta.Enabled = false; }
            }

        public override void MapearDeDatos()
        {
            this.txtNombre.Text = this.ConocimientoActual.Nombre;
            this.txtID.Text = this.ConocimientoActual.IdConocimiento.ToString();
            this.chkAlta.Checked = this.ConocimientoActual.Alta;
            SetModeValue(Modo);

        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    ConocimientoActual = new Business.Entities.Conocimiento();
                    this.ConocimientoActual.Nombre = this.txtNombre.Text;
                    this.ConocimientoActual.Alta = this.chkAlta.Checked ;
                    this.ConocimientoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ConocimientoActual = new Business.Entities.Conocimiento();
                    this.ConocimientoActual.IdConocimiento = int.Parse(txtID.Text);
                    this.ConocimientoActual.Nombre = this.txtNombre.Text;
                    this.ConocimientoActual.Alta = this.chkAlta.Checked;
                    this.ConocimientoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.ConocimientoActual.State = BusinessEntity.States.Deleted;
                    break;
            }
        }
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
            ConocimientoLogic cno = new ConocimientoLogic();
           cno.Save(ConocimientoActual);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
