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

namespace UI.Desktop
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            this.dgvUsuario.AutoGenerateColumns = false;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
            dgvUsuario.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuario.DataSource = ul.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
           if (this.dgvUsuario.SelectedRows.Count == 0)
           {
                MessageBox.Show("Selecciona una fila","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
                int ID = ((Business.Entities.Usuario)this.dgvUsuario.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formUsuario.ShowDialog();
                this.Listar();
           }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = ((Business.Entities.Usuario)this.dgvUsuario.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
                formUsuario.ShowDialog();
                this.Listar();
            }
        }
    }
}
