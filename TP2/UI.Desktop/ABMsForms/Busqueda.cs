using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
            this.dgvBusqueda.AutoGenerateColumns = false;
        }

        public void ListarBusquedas()
        {
            dgvBusqueda.DataSource = GetBusquedasActivas();
        }

        private List<Business.Entities.Busqueda> GetBusquedasActivas()
        {
            List<Business.Entities.Busqueda> busquedasActivas = new List<Business.Entities.Busqueda>();
            BusquedaLogic busquedaLogic = new BusquedaLogic();
            foreach (var busqueda in busquedaLogic.GetAll())
            {
                if(busqueda.Habilitado)
                    busquedasActivas.Add(busqueda);
            }
            return busquedasActivas;

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            ListarBusquedas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarBusquedas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            BusquedaDesktop formUsuario = new BusquedaDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.ListarBusquedas();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvBusqueda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int nroBusqueda = ((Business.Entities.Busqueda)this.dgvBusqueda.SelectedRows[0].DataBoundItem).NroBusqueda;
                BusquedaDesktop formBusqueda = new (nroBusqueda, ApplicationForm.ModoForm.Modificacion);
                formBusqueda.ShowDialog();
                this.ListarBusquedas();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvBusqueda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int nroBusqueda = ((Business.Entities.Busqueda)this.dgvBusqueda.SelectedRows[0].DataBoundItem).NroBusqueda;
                BusquedaDesktop formBusqueda = new(nroBusqueda, ApplicationForm.ModoForm.Baja);
                formBusqueda.ShowDialog();
                this.ListarBusquedas();
            }

        }
    }
}
