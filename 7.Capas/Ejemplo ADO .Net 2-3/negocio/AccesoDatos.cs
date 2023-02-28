using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    //2.ClaseAccesoADatosCentralizado.1.Creaccion de clase para centralizar la conexión
    public class AccesoDatos
    {
        //2.ClaseAccesoADatosCentralizado.2.Declarar variable conexión, comando y lector
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //2.ClaseAccesoADatosCentralizado.6.Property public para leer el lector desde el exterior
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //2.ClaseAccesoADatosCentralizado.3.Crear constructor de conexión
        public AccesoDatos()
        {
            //creación por parametro de constructor /cadena de conexión
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            //acción contra la base de datos
            comando = new SqlCommand();
        }

        //2.ClaseAccesoADatosCentralizado.4.Crear función para setear consulta
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //2.ClaseAccesoADatosCentralizado.5.Crear funcion para ejecutar lectura
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

        //3.InsertSimple.4.Crear metodo de ejecucion sin consulta
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

        //5.InsertParámetrosDeComando.1.Método para setear parámetros
        public void setearParametro(string nombre, object valor)
        {
            //agregar parámetro con valor
            comando.Parameters.AddWithValue(nombre, valor);
        }

        //2.ClaseAccesoADatosCentralizado.7.Crear funcion de cerrar conexion
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
