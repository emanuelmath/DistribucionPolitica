using DistribucionPolitica_R.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DistribucionPolitica_R.Formularios
{
    public partial class FrmEntidad : Form
    {
        int idGlobal = 0;
        public FrmEntidad()
        {
            InitializeComponent();
        }

        public void RefrescarLista(string nombre = "")
        {
            GrdEntidad.DataSource = Entidad.MostrarEntidad(nombre);
            GrdEntidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GrdEntidad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrdEntidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void GrdEntidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No eliminar.
        }

        private void FrmEntidad_Load(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEntidadAgregarEditar frmEntidadAgregarEditar = new FrmEntidadAgregarEditar();
            frmEntidadAgregarEditar.ShowDialog();
            TxtEntidad.Text = "";
            RefrescarLista();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (GrdEntidad.Rows.Count > 0)
            {
                idGlobal = Convert.ToInt32(GrdEntidad.CurrentRow.Cells["Id"].Value);
                FrmEntidadAgregarEditar frmEntidadAgregarEditar = new FrmEntidadAgregarEditar(idGlobal);
                frmEntidadAgregarEditar.ShowDialog();
                RefrescarLista(TxtEntidad.Text);
            }
            else
            {
                MessageBox.Show("No hay registros para editar.");
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if(GrdEntidad.Rows.Count <= 0)
            {
                MessageBox.Show("No hay datos para expotar.");
            }
            else
            {
                string exportedData = ExportarDatos();
                string path = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo CSV|*.csv";
                saveFileDialog.Title = "Guardar Archivo CSV de la Tabla";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName.Trim();
                    File.WriteAllText(path, exportedData);
                }
            }
        }

        private string ExportarDatos()
        {
            string columsCSV = "";
            string rowsCSV = "";

            DataTable dt = Entidad.MostrarEntidad();
            int i = 0;
            int j = 0;
            int k = 0;

            foreach (var dc in dt.Columns)
            {
                i++;

                if (i < dt.Columns.Count)
                {
                    columsCSV += dc.ToString() + ",";

                }
                else
                {
                    columsCSV += dc.ToString() + "\n";
                }

            }

            for (j = 0; j < dt.Rows.Count; j++)
            {
                DataRow dr = dt.Rows[j];
                k = 0;

                foreach (var dc in dt.Columns)
                {
                    k++;

                    if (k < dt.Columns.Count)
                    {
                        rowsCSV += dr[dc.ToString()].ToString() + ",";

                    }
                    else
                    {
                        rowsCSV += dr[dc.ToString()].ToString() + "\n";
                    }

                }

            }

            return columsCSV + rowsCSV;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(GrdEntidad.Rows.Count > 0)
            {
                int id = Convert.ToInt32(GrdEntidad.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show($"¿Desea eliminar la distribución con Id: {id}?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
                else
                {
                    Entidad.EliminarEntidad(id);
                    RefrescarLista(TxtEntidad.Text);
                }
            }
            else
            {
                MessageBox.Show("No hay entidades para eliminar.");
            }    
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RefrescarLista(TxtEntidad.Text);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEntidad.Text = string.Empty;
            RefrescarLista();
        }
    }
}
