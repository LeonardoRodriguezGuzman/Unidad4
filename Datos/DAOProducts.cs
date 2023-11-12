using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad4.Pojos;

namespace Unidad4.Datos
{
    internal class DAOProducts
    {
        public static clsProducts ObtenerProducto(int id)
        { 
            Conexion conexion = new Conexion();
            MySqlConnection connection = conexion.CrearConexion();
            string consulta = "SELECT p.productid, p.productname, p.unitprice FROM products p WHERE p.productid = @id";
            clsProducts producto = null;
            using (MySqlCommand command = new MySqlCommand(consulta, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int productID = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        double unitPrice = reader.GetDouble(2);
                        string numero = unitPrice.ToString("F2");
                        unitPrice = double.Parse(numero);
                        conexion.CerrarConexion();
                        producto = new clsProducts(productID, productName, unitPrice);
                    }
                }
            }
            conexion.CerrarConexion();
            return producto;
        }
    }
}
