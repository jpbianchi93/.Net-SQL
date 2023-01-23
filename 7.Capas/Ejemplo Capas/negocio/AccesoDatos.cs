using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    //Creaccion de clase para centralizar la conexión
    public class AccesoDatos
    {
        //declarar variable conexión
        private SqlConnection conexion;
        //declarar variable comando
        private SqlCommand comando;
        //declarar variable lector
        private SqlDataReader lector;

        //property para leer el lector desde el exterior
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //crear constructor de conexión
        public AccesoDatos()
        {
            //creación por parametro de constructor /cadena de conexión
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            //acción contra la base de datos
            comando = new SqlCommand();
        }

        //función para setear consulta
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //funcion para ejecutar lectura
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //crear metodo de ejecucion sin consulta
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //método para setear parámetros
        public void setearParametro(string nombre, object valor)
        {
            //agregar parámetro con valor
            comando.Parameters.AddWithValue(nombre, valor);
        }

        //funcion de cerrar conexion
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
