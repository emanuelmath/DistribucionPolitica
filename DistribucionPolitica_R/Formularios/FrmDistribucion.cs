using DistribucionPolitica_R.Clases;
using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace DistribucionPolitica_R.Formularios
{
    public partial class FrmDistribucion : Form
    {
        Dictionary<string, int> opciones = new Dictionary<string, int>();
        public FrmDistribucion()
        {
            InitializeComponent();
            ComboBoxEntidad.Text = "Buscar por entidad...";
        }
        private void FrmDistribucion_Load(object sender, EventArgs e)
        {
            RefrescarLista();
            CargarEntidades();
            foreach(var opc in opciones)
            {
                ComboBoxEntidad.Items.Add(opc.Key);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmDistribucionAgregarEditar frmDistribucionAgregarEditar = new FrmDistribucionAgregarEditar();
            frmDistribucionAgregarEditar.ShowDialog();
            TxtDistribucion.Text = "";
            RefrescarLista();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(GrdDistribucion.Rows.Count <= 0)
            {
                MessageBox.Show("No hay distribuciones para editar.");
            }
            else
            {
                int id = Convert.ToInt32(GrdDistribucion.CurrentRow.Cells["Id"].Value);
                FrmDistribucionAgregarEditar frmEditar = new FrmDistribucionAgregarEditar(id);
                frmEditar.ShowDialog();
                RefrescarLista(TxtDistribucion.Text);
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (GrdDistribucion.Rows.Count <= 0)
            {
                MessageBox.Show("No hay distribuciones para exportar.");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(GrdDistribucion.Rows.Count > 0)
            {
                int id = Convert.ToInt32(GrdDistribucion.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show($"¿Desea eliminar la distribución con Id: {id}?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
                else
                {
                    Distribucion.EliminarDistribucion(id);
                    RefrescarLista(TxtDistribucion.Text);
                }
            }
            else
            {
                MessageBox.Show("No hay distribuciones para eliminar.");
            }
            
        }

        private void ComboBoxEntidad_Click(object sender, EventArgs e)
        {
            //No eliminar.
        }

        private void TxtDistribucion_Click(object sender, EventArgs e)
        {
            //No eliminar.
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TxtDistribucion.Text;
            int entidad = (ComboBoxEntidad.SelectedItem != null && opciones.ContainsKey(ComboBoxEntidad.SelectedItem.ToString())) ? opciones[ComboBoxEntidad.SelectedItem.ToString()] : -1;
            RefrescarLista(nombre, entidad);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDistribucion.Text = "";
            RefrescarLista();
            ComboBoxEntidad.Text = "Buscar por entidad... ";
        }

        private void GrdDistribucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
            //No eliminar.
        }

        public void RefrescarLista(string nombre = "", int entidad = -1) 
        {
            GrdDistribucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GrdDistribucion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GrdDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            GrdDistribucion.DataSource = Distribucion.MostrarDistribucion(nombre, entidad);
        }

        private string ExportarDatos()
        {
            string columsCSV = "";
            string rowsCSV = "";
            
            DataTable dt = Distribucion.MostrarDistribucion(TxtDistribucion.Text, ComboBoxEntidad.SelectedIndex == -1 ? -1 : ComboBoxEntidad.SelectedIndex + 1);
            int i = 0;
            int j = 0;
            int k = 0;

            foreach (var dc in dt.Columns)
            {
                i++;

                if(i < dt.Columns.Count)
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

        public void CargarEntidades()
        {
            DataTable entidades = Entidad.MostrarEntidadesParaDistribucion();
            
            foreach (DataRow row in entidades.Rows)
            {
                opciones.Add(row["Nombre"].ToString(), Convert.ToInt32(row["Id"]));
            }
        }
    }
}
