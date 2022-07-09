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

    public partial class BusquedaDesktop : ApplicationForm
    {

        public Business.Entities.Busqueda BusquedaActual { get; set; }
        private BusquedaLogic busquedaLogic;
        public BusquedaDesktop()
        {
            InitializeComponent();
        }
        public BusquedaDesktop(ModoForm modo):this()
        {
            Modo = modo;
        }
        public BusquedaDesktop(int nroBusqueda, ModoForm modo) : this()
        {
            Modo = modo;
            busquedaLogic = new BusquedaLogic();
            BusquedaActual = busquedaLogic.GetOneById(nroBusqueda);
            MapearDeDatos();
        }

        public void SetModeValue(ModoForm modo)
        {
            if (modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (modo == ModoForm.Alta || modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
                this.tbNombre.ReadOnly = true;
                this.tbNroBusqueda.ReadOnly = true;
                this.tbDetalleAmpliado.ReadOnly = true;
                this.chkHabilitado.Enabled = false;
                this.chkTipo.Enabled = false;

            };
        }

        public override void MapearDeDatos()
        {
            this.tbNombre.Text = this.BusquedaActual.Nombre;
            this.tbNroBusqueda.Text = this.BusquedaActual.NroBusqueda.ToString();
            this.chkHabilitado.Checked = this.BusquedaActual.Habilitado;
            this.chkTipo.Checked = this.BusquedaActual.Tipo;
            this.tbDetalleAmpliado.Text = this.BusquedaActual.DetalleAmpliado;
            this.tbFechaDesde.Text = this.BusquedaActual.FechaDesde.ToString();
            this.tbFechaHas.Text = this.BusquedaActual.FechaHasta.ToString();
            SetModeValue(Modo);

        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    BusquedaActual = new Business.Entities.Busqueda();
                    this.BusquedaActual.Nombre = this.tbNombre.Text;
                    this.BusquedaActual.Habilitado = this.chkHabilitado.Checked;
                    this.BusquedaActual.Tipo = this.chkTipo.Checked;
                    this.BusquedaActual.DetalleAmpliado = this.tbDetalleAmpliado.Text;
                    this.BusquedaActual.FechaDesde = DateTime.Now;
                    this.BusquedaActual.FechaHasta = DateTime.Now.AddMonths(1);
                    this.BusquedaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    BusquedaActual = new Business.Entities.Busqueda();
                    this.BusquedaActual.Nombre = this.tbNombre.Text;
                    this.BusquedaActual.NroBusqueda = int.Parse(this.tbNroBusqueda.Text);
                    this.BusquedaActual.Habilitado = this.chkHabilitado.Checked;
                    this.BusquedaActual.Tipo = this.chkTipo.Checked;
                    this.BusquedaActual.DetalleAmpliado = this.tbDetalleAmpliado.Text;
                    //this.BusquedaActual.FechaDesde = DateTime.Parse(this.tbFechaDesde.Text);
                    //this.BusquedaActual.FechaHasta = DateTime.Parse(this.tbFechaHas.Text);
                    this.BusquedaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.BusquedaActual.State = BusinessEntity.States.Deleted;
                    break;
            }
        }

        public override bool Validar()
        {
            String[] controles = { tbNombre.Text, tbDetalleAmpliado.Text };
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
            busquedaLogic = new BusquedaLogic();
            busquedaLogic.Save(BusquedaActual);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTipo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
