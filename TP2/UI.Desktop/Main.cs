using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario formUsuario = new Usuario();
            formUsuario.ShowDialog();
        }

        private void btnBusquedas_Click(object sender, EventArgs e)
        {
            new Busqueda().ShowDialog();
        }

        private void btnConocimientos_Click(object sender, EventArgs e)
        {
            ABMsForms.Conocimiento formConocimiento = new ABMsForms.Conocimiento();
            formConocimiento.ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad formEspecialidad = new Especialidad();
            formEspecialidad.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
