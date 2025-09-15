using DistribucionPolitica_R.Formularios;
using DistribucionPolitica_R.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribucionPolitica_R
{
    public partial class FrmInterfaz : Form
    {
        public FrmInterfaz()
        {
            InitializeComponent();
        }

        private void salirMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void distribucionMenuStrip_Click(object sender, EventArgs e)
        {
            DataTable entidades = Entidad.MostrarEntidad();
            if(entidades.Rows.Count > 0)
            {
                Form frmDistribucion = new FrmDistribucion()
                {
                    MdiParent = this
                };
                frmDistribucion.Show();
            }
            else
            {
                MessageBox.Show("Agrega las entidades para poder agregar distribuciones.");
            }
        }

        private void entidadMenuStrip_Click(object sender, EventArgs e)
        {
            Form frmEntidad = new FrmEntidad()
            {
                MdiParent = this
            };
            frmEntidad.Show();
        }
    }
}
