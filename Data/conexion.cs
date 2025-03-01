using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApicacionRay
{
    public class conexion
    {
        //private
        //public static string connectionString = "Server=(local);Database=TIENDA_SHURIKEN_DB_COMICS;Integrated Security=True;";
        public static string connectionString = "Server=.;Database=TIENDA_SHURIKEN_DB;Integrated Security=True;";

        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                throw;
            }
        }
        #region CARGAR PRODUCTOS

        public static List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();

            using (SqlConnection connection = Conectar())
            {
                string query = "SELECT DISTINCT CATEGORIA FROM PRODUCTO";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoria = reader.GetString(0);
                            categorias.Add(categoria);
                        }
                    }
                }
            }

            return categorias;
        }

        public static List<string> ObtenerEditoriales()
        {
            List<string> editoriales = new List<string>();

            using (SqlConnection connection = Conectar())
            {
                string query = "SELECT DISTINCT EDITORIAL FROM PRODUCTO";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string editorial = reader.GetString(0);
                            editoriales.Add(editorial);
                        }
                    }
                }
            }

            return editoriales;
        }
        #endregion
    }
}
