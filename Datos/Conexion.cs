using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4.Datos
{
    internal class Conexion
    {
        MySqlConnection conexion;
        string cadenaConexion;
        public Conexion()
        {

        }
        public MySqlConnection CrearConexion()
        {
            cadenaConexion = "Server=127.0.0.1;Database=northwind;User Id=root;Password=}x8P5pfqb0c}_Fg;";
            conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexion");
                return null;
            }
        }
        public void CerrarConexion()
        {
            if (conexion != null)
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }
        }

        
    }
}
