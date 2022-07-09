using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;



namespace UI.Desktop.ABMsForms
{
    public partial class Conocimiento : Form
    {
        public Conocimiento()
        {
            InitializeComponent();
            this.dgvConocimiento.AutoGenerateColumns = false;
        }
        private void Conocimiento_Load(object sender, EventArgs e)
        {
            Listar();
           
        }
        public void Listar()
        {

            ConocimientoLogic cl = new ConocimientoLogic();
            this.dgvConocimiento.DataSource = cl.GetAll();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Listar();
;        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            DesktopForms.ConocimientoDesktop formConocimiento = new DesktopForms.ConocimientoDesktop();
            formConocimiento.ShowDialog();
            this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvConocimiento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = ((Business.Entities.Conocimiento)this.dgvConocimiento.SelectedRows[0].DataBoundItem).IdConocimiento;
                DesktopForms.ConocimientoDesktop formConocimiento = new DesktopForms.ConocimientoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formConocimiento.ShowDialog();
                this.Listar();
            }
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvConocimiento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = ((Business.Entities.Conocimiento)this.dgvConocimiento.SelectedRows[0].DataBoundItem).IdConocimiento;
                DesktopForms.ConocimientoDesktop formConocimiento = new DesktopForms.ConocimientoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formConocimiento.ShowDialog();
                this.Listar();
            }
        }
    }
}
