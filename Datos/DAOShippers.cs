using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad4.Pojos;

namespace Unidad4.Datos
{
    internal class DAOShippers
    {
        public static List<clsShippers> ObtenerListaShippers()
        {
            List<clsShippers> shippers= new List<clsShippers>();

            Conexion conexion = new Conexion();
            MySqlConnection connection = conexion.CrearConexion();
            string consulta = "SELECT s.ShipperID as ID, CONCAT(s.CompanyName) as Nombre FROM Shippers s";
            using (MySqlCommand command = new MySqlCommand(consulta, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string nombre = reader["Nombre"].ToString();
                        clsShippers shipper = new clsShippers(id, nombre);
                        shippers.Add(shipper);
                    }
                }
            }
            conexion.CerrarConexion();


            return shippers;
        }
    }
}
