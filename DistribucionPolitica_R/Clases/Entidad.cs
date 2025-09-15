using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DistribucionPolitica_R.Clases
{
    public class Entidad
    {
        public int ID { get; set; }
        public int Inactivo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } = "";

        public static DataTable MostrarEntidad(string nombre = "")
        {
            string consulta = "";
            if (String.IsNullOrEmpty(nombre.Trim()))
            {
                consulta = "SELECT ID, Nombre, dbo.RepresentarBooleano(Inactivo) AS Inactivo, Descripcion FROM Entidad";
                return ConexionSQL.Select(consulta);
            }
            else
            {
                consulta = $"SELECT ID, Nombre, dbo.RepresentarBooleano(Inactivo) AS Inactivo, Descripcion FROM Entidad WHERE Nombre LIKE '%{nombre}%'";
                return ConexionSQL.Select(consulta);
            }
            
        }

        public static DataTable MostrarEntidadesParaDistribucion(int id = -1)
        {
            string consulta = "";

            if (id <= -1)
            {
                consulta = "SELECT ID, Nombre FROM Entidad";
            }
            else if (id == 0)
            {
                consulta = "SELECT ID, Nombre FROM Entidad";
            }
            else
            {
                consulta = $"SELECT ID, Nombre FROM Entidad WHERE ID = {id - 1}";
            }
             
            return ConexionSQL.Select(consulta);
        }

        public static DataTable MostrarEntidadEditar(int id)
        {
            string consulta = $@"SELECT Nombre, Descripcion, Inactivo FROM Entidad WHERE ID = {id}";
            return ConexionSQL.Select(consulta);
        }

        public int InsertarEntidad()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string consulta = $@"INSERT INTO Entidad(Nombre, Inactivo, Descripcion)
                                VALUES (@Nombre, @Inactivo, @Descripcion)";

            parameters.Add(new SqlParameter("@Nombre", Nombre));
            parameters.Add(new SqlParameter("@Inactivo", Inactivo));
            parameters.Add(new SqlParameter("@Descripcion", Descripcion));

            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }

        public int ActualizarEntidad()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string consulta = $@"UPDATE Entidad
                                SET Nombre = @Nombre, Inactivo = @Inactivo, Descripcion = @Descripcion
                                WHERE Id = @Id";

            parameters.Add(new SqlParameter("@ID", ID));
            parameters.Add(new SqlParameter("@Nombre", Nombre));
            parameters.Add(new SqlParameter("@Inactivo", Inactivo));
            parameters.Add(new SqlParameter("@Descripcion", Descripcion));


            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }

        public static int EliminarEntidad(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string consulta = $@"DELETE FROM Entidad
                                WHERE Id = @Id";
                                //DBCC CHECKIDENT('Entidad', RESEED, {id - 1}); ";

            parameters.Add(new SqlParameter("@Id", id));

            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }
        
    }
}
