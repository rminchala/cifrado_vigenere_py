using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_al.Pantallas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ConsuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiante frmEs = new frmEstudiante();
            frmEs.MdiParent = this;
            frmEs.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();  //salir del sistema o aplicacion alumno
        }
    }
}
