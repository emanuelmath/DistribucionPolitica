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

namespace DistribucionPolitica_R.Formularios
{
    public partial class FrmEntidadAgregarEditar: Form
    {
        int idGlobal = 0;
        public FrmEntidadAgregarEditar(int id = 0)
        {
            InitializeComponent();
            idGlobal = id;
            RecuperarDatosEntidad();
        }

        private void FrmEntidadAgregarEditar_Load(object sender, EventArgs e)
        {
            //No eliminar.
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(idGlobal <= 0)
            {
                Entidad entidad = new Entidad
                {
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    Inactivo = CheckBoxInactivo.Checked ? 1 : 0 
                };

                entidad.InsertarEntidad();
                MessageBox.Show("Entidad agregada exitosamente.");
                this.Close();
            }
            else
            {
                Entidad entidad = new Entidad
                {
                    ID = idGlobal,
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    Inactivo = CheckBoxInactivo.Checked ? 1 : 0
                };

                entidad.ActualizarEntidad();
                MessageBox.Show("Entidad actualizada exitosamente.");
                this.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecuperarDatosEntidad()
        {
            if (idGlobal > 0)
            {
                DataTable entidadTabla = Entidad.MostrarEntidadEditar(idGlobal);
                Entidad entidad = new Entidad();

                foreach (DataRow row in entidadTabla.Rows)
                {
                    entidad.Nombre = row["Nombre"].ToString();
                    entidad.Descripcion = row["Descripcion"].ToString();
                    entidad.Inactivo = Convert.ToInt32(row["Inactivo"]);
                }
                TxtNombre.Text = entidad.Nombre;
                TxtDescripcion.Text = entidad.Descripcion;
                CheckBoxInactivo.Checked = entidad.Inactivo == 1 ? true : false;
            }
        }

    }
}
