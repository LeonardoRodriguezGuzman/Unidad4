using MySql.Data.MySqlClient;
using Unidad4.Pojos;

namespace Unidad4.Datos
{
    internal class DAOEmployees
    {
        public static List<clsEmployees> ObtenerListaEmpleados()
        {
            List<clsEmployees> empleados = new List<clsEmployees>();

            Conexion conexion = new Conexion();
                MySqlConnection connection = conexion.CrearConexion();
                string consulta = "SELECT e.EmployeeID as ID, CONCAT(e.FirstName,  ' ', e.LastName) as Nombre FROM Employees e";
                using (MySqlCommand command = new MySqlCommand(consulta, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string nombre = reader["Nombre"].ToString();
                            clsEmployees empleado = new clsEmployees(id, nombre);
                            empleados.Add(empleado);
                        }
                    }
                }
                conexion.CerrarConexion();
            
            
            return empleados;
        }
    }
}

