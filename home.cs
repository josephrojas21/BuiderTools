using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderTools
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnCalcularObra_Click(object sender, EventArgs e)
        {
            Calcular_Obra form = new Calcular_Obra();
            form.Show();
        }

        private void lblAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnMisObras_Click(object sender, EventArgs e)
        {
            Lista_Obras form = new Lista_Obras();
            form.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda form = new Ayuda();
            form.Show();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            home form = new home();
            form.Close();
        }
    }
}
