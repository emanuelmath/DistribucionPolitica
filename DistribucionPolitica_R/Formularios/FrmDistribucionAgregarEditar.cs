using DistribucionPolitica_R.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribucionPolitica_R.Formularios
{
    public partial class FrmDistribucionAgregarEditar : Form
    {
        int idGlobal = 0;
        private Dictionary<string, int> opciones = new Dictionary<string, int>();
        private Dictionary<string, int> opcionesEntidadSuperior = new Dictionary<string, int>();
        private Dictionary<string, int> opcionesDistribucionSuperior = new Dictionary<string, int>();
        public FrmDistribucionAgregarEditar(int id = 0)
        {
            InitializeComponent();

            if (id > 0)
            {
                idGlobal = id;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (idGlobal <= 0)
            {
                if (String.IsNullOrEmpty(TxtNombre.Text.Trim()) || String.IsNullOrEmpty(TxtCodigo.Text.Trim())
                    || ComboBoxEntidad.ValueMember == null)
                {
                    MessageBox.Show("Debe ingresar un nombre para la distribución, una entidad y un código postal.");
                }
                else
                {
                    try
                    {
                        if ((int)(ComboBoxEntidad.SelectedValue) == 1)
                        {

                            Distribucion distribucion = new Distribucion()
                            {
                                Nombre = TxtNombre.Text,
                                Entidad = (int)(ComboBoxEntidad.SelectedValue),
                                Inactivo = AplicarValorCheckBox(CheckBoxInactivo),
                                Cabecera = AplicarValorCheckBox(CheckBoxCabecera),
                                Capital = AplicarValorCheckBox(CheckBoxCapital),
                                CodigoPostal = TxtCodigo.Text,
                                Fundacion = DateTimeFecha.Value,
                                Superficie = NumSuperficie.Value,
                                Poblacion = Convert.ToInt64(NumPoblacion.Value)

                            };
                            distribucion.InsertarDistribucion();


                            MessageBox.Show("Distribución agregada." + ComboBoxEntidad.SelectedValue);

                            this.Close();


                        }
                        else
                        {
                            Distribucion distribucion = new Distribucion()
                            {
                                Nombre = TxtNombre.Text,
                                Entidad = (int)(ComboBoxEntidad.SelectedValue),//(int)AplicarValorComboBox(ComboBoxEntidad),
                                EntidadSuperior = AplicarValorComboBox(ComboBoxEntidadSuperior),
                                DistribucionSuperior = AplicarValorComboBox(ComboBoxDistribucionSuperior),
                                Inactivo = AplicarValorCheckBox(CheckBoxInactivo),
                                Cabecera = AplicarValorCheckBox(CheckBoxCabecera),
                                Capital = AplicarValorCheckBox(CheckBoxCapital),
                                CodigoPostal = TxtCodigo.Text,
                                Fundacion = DateTimeFecha.Value,
                                Superficie = NumSuperficie.Value,
                                Poblacion = Convert.ToInt64(NumPoblacion.Value)

                            };
                            distribucion.InsertarDistribucion();


                            MessageBox.Show("Distribución agregada.");

                            this.Close();
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No puedes dejar Entidad vacía.");
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(TxtNombre.Text.Trim()) || String.IsNullOrEmpty(TxtCodigo.Text.Trim())
                    || ComboBoxEntidad.ValueMember == null)
                {
                    MessageBox.Show("Debe ingresar un nombre para la distribución, una entidad y un código postal.");
                }
                else
                {
                    try
                    {
                        Distribucion distribucion = new Distribucion()
                        {
                            Id = idGlobal,
                            Nombre = TxtNombre.Text,
                            Inactivo = AplicarValorCheckBox(CheckBoxInactivo),
                            Cabecera = AplicarValorCheckBox(CheckBoxCabecera),
                            Capital = AplicarValorCheckBox(CheckBoxCapital),
                            Entidad = (int)(ComboBoxEntidad.SelectedValue),//(int)AplicarValorComboBox(ComboBoxEntidad),
                            EntidadSuperior = AplicarValorComboBox(ComboBoxEntidadSuperior),
                            DistribucionSuperior = AplicarValorComboBox(ComboBoxDistribucionSuperior),
                            CodigoPostal = TxtCodigo.Text,
                            Fundacion = DateTimeFecha.Value,
                            Superficie = NumSuperficie.Value,
                            Poblacion = Convert.ToInt64(NumPoblacion.Value)

                        };
                        distribucion.ActualizarDistribucion();
                        MessageBox.Show("Distribución editada.");
                        this.Close();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No puedes dejar Entidad vacía.");
                    }
                }

            }
            
        }

        public int? AplicarValorComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
            {
                return null;
            }

            if (int.TryParse(comboBox.SelectedValue.ToString(), out int valorComboBox))
            {
                return valorComboBox == 0 ? (int?)null : valorComboBox;
            }

            return null;
        }


        public int AplicarValorCheckBox(CheckBox checkBox) 
        {
            if (!checkBox.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public bool AplicarValorIntACheckBox(int valor)
        {
            if (valor == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
             
        }


        public void ObtenerValoresDistribucion(int id = 0)
        {
            if (id > 0)
            {
                idGlobal = id;
                DataTable dt = Distribucion.MostrarDistribucionEditar(idGlobal);

                foreach (DataRow dr in dt.Rows)
                {
                    TxtNombre.Text = dr["Nombre"].ToString();
                    CheckBoxInactivo.Checked = AplicarValorIntACheckBox(Convert.ToInt32(dr["Inactivo"]));
                    CheckBoxCabecera.Checked = AplicarValorIntACheckBox(Convert.ToInt32(dr["Cabecera"]));
                    CheckBoxCapital.Checked = AplicarValorIntACheckBox(Convert.ToInt32(dr["Capital"]));
                    ComboBoxEntidad.SelectedValue = ComboBoxEntidad.SelectedValue = Convert.ToInt32(dr["Entidad"]);
                    if (dr["EntidadSuperior"] != DBNull.Value)
                    { 
                        CargarEntidadesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));

                        ComboBoxEntidadSuperior.DataSource = new BindingSource(opcionesEntidadSuperior, null);
                        ComboBoxEntidadSuperior.DisplayMember = "Key";
                        ComboBoxEntidadSuperior.ValueMember = "Value";

                        ComboBoxEntidadSuperior.SelectedValue = Convert.ToInt32(dr["EntidadSuperior"]);
                    }

                    if (dr["DistribucionSuperior"] != DBNull.Value)
                    {
                        CargarDistribucionesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));

                        ComboBoxDistribucionSuperior.DisplayMember = "Key";
                        ComboBoxDistribucionSuperior.ValueMember = "Value";
                        ComboBoxDistribucionSuperior.DataSource = new BindingSource(opcionesDistribucionSuperior, null);


                        ComboBoxDistribucionSuperior.SelectedValue = Convert.ToInt32(dr["DistribucionSuperior"]);
                    }

                    TxtCodigo.Text = dr["CodigoPostal"].ToString();
                    DateTimeFecha.Value = Convert.ToDateTime(dr["Fundacion"]);
                    NumPoblacion.Value = Convert.ToInt32(dr["Poblacion"]);
                    NumSuperficie.Value = Convert.ToDecimal(dr["Superficie"]);
                }
            }
        }

        public void CargarEntidades()
        {
            opciones.Clear();
            DataTable entidades = Entidad.MostrarEntidadesParaDistribucion();

            if (entidades.Rows.Count <= 0)
            {
                opciones.Add("Sin Entidades...", 0);
                return;
            }

            foreach (DataRow row in entidades.Rows)
            {
                opciones.Add(row["Nombre"].ToString(), Convert.ToInt32(row["Id"]));
            }
        }


        public void CargarEntidadesSuperiores(int id)
        {
            opcionesEntidadSuperior.Clear();
            DataTable entidades = Entidad.MostrarEntidadesParaDistribucion(id);

            if (entidades.Rows.Count <= 0)
            {
                opcionesEntidadSuperior.Add("Sin Entidades Superiores...", 0);
                return;
            }

            foreach (DataRow row in entidades.Rows)
            {
                opcionesEntidadSuperior.Add(row["Nombre"].ToString(), Convert.ToInt32(row["Id"]));
            }
        }


        public void CargarDistribucionesSuperiores(int id)
        {
            opcionesDistribucionSuperior.Clear();
            DataTable distribuciones = Distribucion.MostrarDistribucionesSuperiores(id);

            if (distribuciones.Rows.Count <= 0)
            {
                opcionesDistribucionSuperior.Add("Sin Distribuciones Superiores...", 0);
                return;
            }

            foreach (DataRow row in distribuciones.Rows)
            {
                if (!opcionesDistribucionSuperior.ContainsKey(row["Nombre"].ToString())) 
                { 
                    opcionesDistribucionSuperior.Add(row["Nombre"].ToString(), Convert.ToInt32(row["Id"])); 
                } 
                else 
                { 
                    opcionesDistribucionSuperior.Add($"{row["Nombre"]} ({row["Id"]})", Convert.ToInt32(row["Id"])); 
                }
            }
        }

        private void FrmDistribucionAgregarEditar_Load(object sender, EventArgs e)
        {
            ComboBoxEntidad.DisplayMember = "Key";
            ComboBoxEntidad.ValueMember = "Value";
            ComboBoxEntidadSuperior.DisplayMember = "Key";
            ComboBoxEntidadSuperior.ValueMember = "Value";
            ComboBoxDistribucionSuperior.DisplayMember = "Key";
            ComboBoxDistribucionSuperior.ValueMember = "Value";
            
            
            
            CargarEntidades();
            CargarEntidadesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));
            CargarDistribucionesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));

            ComboBoxEntidad.DataSource = new BindingSource(opciones, null);
            ComboBoxEntidadSuperior.DataSource = new BindingSource(opcionesEntidadSuperior, null);
            ComboBoxDistribucionSuperior.DataSource = new BindingSource(opcionesDistribucionSuperior, null);


            if (idGlobal > 0)
            {
                ObtenerValoresDistribucion(idGlobal);
            }

        }

        private void ComboBoxEntidad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ComboBoxEntidad.SelectedValue) != 1) // Corresponde a país.
            {
                ComboBoxEntidadSuperior.DisplayMember = "Key";
                ComboBoxEntidadSuperior.ValueMember = "Value";
                ComboBoxDistribucionSuperior.DisplayMember = "Key";
                ComboBoxDistribucionSuperior.ValueMember = "Value";
                CargarEntidadesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));
                CargarDistribucionesSuperiores(Convert.ToInt32(ComboBoxEntidad.SelectedValue));
                ComboBoxEntidadSuperior.DataSource = new BindingSource(opcionesEntidadSuperior, null);
                ComboBoxDistribucionSuperior.DataSource = new BindingSource(opcionesDistribucionSuperior, null);
                ComboBoxEntidadSuperior.Enabled = true;
                ComboBoxDistribucionSuperior.Enabled = true;
            }
            else
            {

                ComboBoxEntidadSuperior.Enabled = false;
                ComboBoxDistribucionSuperior.Enabled = false;
                ComboBoxEntidadSuperior.Text = "País es la máxima entidad de distribución política.";
                ComboBoxDistribucionSuperior.Text = "País es la máxima distribución política.";
            }
        }
    }
}
