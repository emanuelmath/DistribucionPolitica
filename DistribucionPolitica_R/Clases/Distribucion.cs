//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribucionPolitica_R.Clases
{
    /// <summary>
    /// Clase de la tabla Distribución, posee sus atributos y métodos correspondientes para realizar operaciones SQL.
    /// </summary>
    public class Distribucion
    {
        public int Id { get; set; }
        public int Inactivo { get; set; }
        public int Entidad {  get; set; }
        public int? EntidadSuperior { get; set; } = null;
        public int? DistribucionSuperior { get; set; } = null;
        public string Nombre { get; set; }
        public int Capital { get; set; }
        public int Cabecera { get; set; }
        public DateTime? Fundacion { get; set; }
        public decimal? Superficie { get; set; }
        public long Poblacion { get; set; }
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Obtiene todos los datos de la tabla Distribución, según 2 filtros opcionales (<paramref name="nombre"/>, <paramref name="entidadId"/>), buscará con ellos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="entidadId"></param>
        /// <returns>Tabla Distribución según los parámetros.</returns>
        public static DataTable MostrarDistribucion(string nombre = "", int entidadId = -1)
        {
            string consulta = "";
            if (String.IsNullOrEmpty(nombre.Trim()) && entidadId == -1)
            {
                consulta = @"SELECT [ID]
                            ,[EntidadTexto] AS [Entidad]
                            ,[EntidadSuperiorTexto] AS [Entidad Superior]
                            ,[DistribucionSuperiorTexto] AS [Distribución Superior]
                            ,[Nombre]
                            ,[CapitalTexto] AS [Ciudad Capital]
                            ,[CabeceraTexto] AS [Cabecera Departamental]
                FROM [DistribucionPolitica].[dbo].[DistribucionView]";
            }
            else if(!String.IsNullOrEmpty(nombre.Trim()) && entidadId == -1)
            {
                consulta = $@"SELECT [ID]
                            ,[EntidadTexto] AS [Entidad]
                            ,[EntidadSuperiorTexto] AS [Entidad Superior]
                            ,[DistribucionSuperiorTexto] AS [Distribución Superior]
                            ,[Nombre]
                            ,[CapitalTexto] AS [Ciudad Capital]
                            ,[CabeceraTexto] AS [Cabecera Departamental]
                FROM [DistribucionPolitica].[dbo].[DistribucionView]
                WHERE [Nombre] LIKE '%{nombre}%'";
            }
            else if (String.IsNullOrEmpty(nombre.Trim()) && entidadId != -1)
            {
                consulta = $@"SELECT [ID]
                            ,[EntidadTexto] AS [Entidad]
                            ,[EntidadSuperiorTexto] AS [Entidad Superior]
                            ,[DistribucionSuperiorTexto] AS [Distribución Superior]
                            ,[Nombre]
                            ,[CapitalTexto] AS [Ciudad Capital]
                            ,[CabeceraTexto] AS [Cabecera Departamental]
                FROM [DistribucionPolitica].[dbo].[DistribucionView]
                WHERE [Entidad] = {entidadId}";
            }
            else
            {
                consulta = $@"SELECT [ID]
                            ,[EntidadTexto] AS [Entidad]
                            ,[EntidadSuperiorTexto] AS [Entidad Superior]
                            ,[DistribucionSuperiorTexto] AS [Distribución Superior]
                            ,[Nombre]
                            ,[CapitalTexto] AS [Ciudad Capital]
                            ,[CabeceraTexto] AS [Cabecera Departamental]
                FROM [DistribucionPolitica].[dbo].[DistribucionView]
                WHERE [Nombre] LIKE '%{nombre}%' AND [Entidad] = {entidadId}";
            }


                return ConexionSQL.Select(consulta);

        }

        /// <summary>
        /// Obtiene los datos de un ID existente de la Tabla Distribución, para poder editarlos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Datos de la tabla Distribución con el ID correspondido.</returns>
        public static DataTable MostrarDistribucionEditar(int id)
        {
            string consulta = $@"SELECT *
                FROM Distribucion
                WHERE ID = {id}";

            return ConexionSQL.Select(consulta);
        }

        public int InsertarDistribucion()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string consulta = $@"
                INSERT INTO Distribucion (Inactivo, Entidad, EntidadSuperior, DistribucionSuperior, Nombre, Capital, Cabecera, Fundacion, Superficie, Poblacion, CodigoPostal)
                VALUES (@Inactivo, @Entidad, @EntidadSuperior, @DistribucionSuperior, @Nombre, @Capital, @Cabecera, @Fundacion, @Superficie, @Poblacion, @CodigoPostal)";

            
            parameters.Add(new SqlParameter("@Inactivo", Inactivo));
            parameters.Add(new SqlParameter("@Entidad", Entidad));
            parameters.Add(new SqlParameter("@EntidadSuperior", (EntidadSuperior.HasValue ? (object)EntidadSuperior.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@DistribucionSuperior", (DistribucionSuperior.HasValue ? (object)DistribucionSuperior.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Nombre", Nombre));
            parameters.Add(new SqlParameter("@Capital", Capital));
            parameters.Add(new SqlParameter("@Cabecera", Cabecera));
            parameters.Add(new SqlParameter("@Fundacion", (Fundacion.HasValue ? (object)Fundacion.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Superficie", (Superficie.HasValue ? (object)Superficie.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Poblacion", Poblacion));
            parameters.Add(new SqlParameter("@CodigoPostal", CodigoPostal));


            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }

        public static DataTable MostrarDistribucionesSuperiores(int id)
        {
            string consulta = $@"SELECT ID, Nombre
                FROM Distribucion
                WHERE Entidad = {id-1}";

            return ConexionSQL.Select(consulta);
        }
        public int ActualizarDistribucion()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string consulta = $@"
                UPDATE Distribucion 
                SET Nombre = @Nombre, CodigoPostal = @CodigoPostal, Entidad = @Entidad, 
                EntidadSuperior = @EntidadSuperior, DistribucionSuperior = @DistribucionSuperior, Inactivo = @Inactivo,
                Superficie = @Superficie, Poblacion = @Poblacion,
                Fundacion = @Fundacion, Capital = @Capital,
                Cabecera = @Cabecera
                WHERE ID = @Id";

            parameters.Add(new SqlParameter("@Nombre", Nombre));
            parameters.Add(new SqlParameter("@CodigoPostal", CodigoPostal));
            parameters.Add(new SqlParameter("@Entidad", Entidad));
            parameters.Add(new SqlParameter("@EntidadSuperior", (EntidadSuperior.HasValue ? (object)EntidadSuperior.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@DistribucionSuperior", (DistribucionSuperior.HasValue ? (object)DistribucionSuperior.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Inactivo", Inactivo));
            parameters.Add(new SqlParameter("@Superficie", (Superficie.HasValue ? (object)Superficie.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Fundacion", (Fundacion.HasValue ? (object)Fundacion.Value : DBNull.Value)));
            parameters.Add(new SqlParameter("@Poblacion", Poblacion));
            parameters.Add(new SqlParameter("@Capital", Capital));
            parameters.Add(new SqlParameter("@Cabecera", Cabecera));
            parameters.Add(new SqlParameter("Id", Id));


            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }

        public static int EliminarDistribucion(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();   
            string consulta = $@"DELETE 
                                 FROM Distribucion
                                 WHERE ID = @Id";
            //DBCC CHECKIDENT ('Distribucion', RESEED, {id-1});";
            parameters.Add(new SqlParameter("@Id", id));
            
            return ConexionSQL.InsertarActualizarBorrar(consulta, parameters);
        }

        public void FiltrarDistribucion()
        {
            //Luego ver si borro
        }
    }
}
