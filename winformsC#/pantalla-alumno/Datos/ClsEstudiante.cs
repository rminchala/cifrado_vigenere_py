using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// añadir librerias de base de datos
using System.Data;
using System.Data.SqlClient;
//añadir la carpeta donde estan las clases de las pantallas
using practica_al.Pantallas;
using MiLibreria;            // usar libreria creada donde están algunas sentencias sql

namespace practica_al.Datos
{
   
    class ClsEstudiante
    {
        private Conexiondb con = new Conexiondb();  // instanciar a la clase donde está definida el path conexion a la base de datos
        private SqlCommand cmd = new SqlCommand();  // ejecutar comandos sql
        private SqlDataReader leerFila;                   //leer filas de la bad sql

        private int id_student;
        private string last_name;
        private string middle_name;
        private string first_name;
        private string gender;

        //atributos que son de tipo publico

        public int _id_student
        {
            get { return id_student; }
            set { id_student = value; }
        }
        public string _last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string _middle_name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }
        public string _first_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string _gender
        {
            get { return gender; }
            set { gender = value; }
        }
        //esta propiedad sirve para obtener el valor del procedimiento para la validacion de registros repetidos
        public int Found   //propiedad autogenerada
        {
            get; set;
        }
        // INSERTAR DATOS A LA BD SQLSERVER EN LA TABLA ESTUDIANTE USANDO UN STORE PROCEDURE
        // el método debe ser públco para poder ser accesado desde cualquier otra clase
        public int InsertStudent()
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "spInsertaEstudiante";
            cmd.CommandType = CommandType.StoredProcedure;  //especificamos que la cadena de comando es un storeprocedure
            cmd.Parameters.AddWithValue("@last_name", last_name);
            cmd.Parameters.AddWithValue("@middle_name", middle_name);
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@gender", gender);
            //******** proceso de validación de registros que no ingresen duplicados **************
            SqlParameter Found = new SqlParameter("@search", SqlDbType.Int);  //definimos el parámetro del stored procedure @search
            Found.Direction = ParameterDirection.Output;   //definimos el parametro de salida Found
            cmd.Parameters.Add(Found);                     //se envia el parametro de salida 
            //*************************************************************************************
            cmd.ExecuteNonQuery();
            int existe = Found.Value.GetHashCode(); // el parametro Found lo cambiamos a entero
            cmd.Parameters.Clear();   //limpieza de las variables parámetros.
            return existe;
        }
        public void EditStudent()
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "spUpdateStudent";  //llamar al store procedure que actualice la tabla estudiante
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@last_name", last_name);
            cmd.Parameters.AddWithValue("@middle_name",middle_name);
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@student_id", id_student); //codigo del estudiante
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public DataTable ListStudent()
        {
            DataTable TablaDatos = new DataTable();
            cmd.Connection = con.AbrirConexion();
            //cmd.CommandText = "spListStudente";  // no se utiliza ésta instruccion ya que no se usa un store procedure en sqlserver
            //cmd.CommandText = "select student_id CODIGO, last_name 'APELL.PATERNO', middle_name 'APELL.MATERNO',first_name NOMBRE,gender GENERO,created_on 'FECH.INGRESO',updated_on 'FECH.ACTUALIZA' from student  order by last_name asc";
            cmd.CommandText = ClsDefinitions.SqlQueryList;  //esta es el query definido en MiLibreria Class1.cs
            cmd.CommandType = CommandType.Text;
            leerFila = cmd.ExecuteReader();
            TablaDatos.Load(leerFila);
            leerFila.Close();
            con.cerrarConexion();
            return TablaDatos;
        }   
        
        public DataTable SearchStudent(string searchcode) //consulta de estudiantes mediante el codigo
        {
            DataTable dt = new DataTable();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = ClsDefinitions.SqlQuerySearchCE + searchcode;  //realizamos la búsqueda con este query
            cmd.CommandType = CommandType.Text;
            leerFila = cmd.ExecuteReader();
            dt.Load(leerFila);
            leerFila.Close();
            con.cerrarConexion();
            return dt;
        }
    }

    
    //se define esta clase codigoEstudiante como si fuera a definir una variabla global llamada valor pero dentro de una clase para
    //poder pasar valores entre formularios usando la variable valor
    public class codigoEstudiante
    {
        static public int valor;
    }
   
}
