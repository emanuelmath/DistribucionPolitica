using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace DistribucionPolitica_R.Clases
{
    public class ConexionSQL
    {
        static readonly string cadenaDeConexion = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString; 

        /// <summary>
        /// Conecta a la Base de Datos especificada, y con la <paramref name="consulta"/> obtiene todos los datos de la tabla que se le especifique.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>Una tabla con el Select especificado en la <paramref name="consulta"/>.</returns>
        public static DataTable Select(string consulta)
        {
            DataTable tabla = new DataTable();
            
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falló la conexión: " + ex.ToString());
            }
           
            return tabla;
        }

        /// <summary>
        /// Inserta, Actualiza o Elimina en la tabla de la Base de Datos, que se le especifique en la <paramref name="consulta"/>.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>Número de filas afectadas por la <paramref name="consulta"/>.</returns>
        public static int InsertarActualizarBorrar(string consulta, List<SqlParameter> parameters = null)
        {
            int filasAfectadas = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        if (parameters != null) 
                        { 
                            comando.Parameters.AddRange(parameters.ToArray()); //Agrega los parámetros al comando si no son vacíos.
                        }
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falló la consulta: " + ex.ToString());
            };

            return filasAfectadas;
        }
    }
}
