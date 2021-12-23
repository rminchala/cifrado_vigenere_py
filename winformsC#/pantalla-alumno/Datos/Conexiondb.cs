using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace practica_al.Datos
{
    class Conexiondb
    {
        static private string cadenaConexion = "Server=EINSTEIN-PC;Initial Catalog=dbalumno;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection(cadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if(conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }   
}
