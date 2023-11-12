using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad4.Pojos;

namespace Unidad4.Datos
{
    internal class DAOCustomers
    {
        public static List<clsCustomers> ObternerListaCustomers()
        {
            List<clsCustomers> customers= new List<clsCustomers>();

            Conexion conexion = new Conexion();
            MySqlConnection connection = conexion.CrearConexion();
            string consulta = "SELECT c.CustomerID as ID, CONCAT(c.CompanyName) as Nombre FROM Customers c";
            using (MySqlCommand command = new MySqlCommand(consulta, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();    
                        string nombre = reader["Nombre"].ToString();
                        clsCustomers customer = new clsCustomers(id, nombre);
                        customers.Add(customer);
                    }
                }
            }
            conexion.CerrarConexion();


            return customers;
        }
    }
}
