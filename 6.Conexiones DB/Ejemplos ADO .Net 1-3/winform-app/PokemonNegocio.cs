using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.LescturaDB.2.a.Libreria para declarar objetos de conexión
using System.Data.SqlClient;

namespace winform_app
{
    //1.LescturaDB.2.CrearConexionDB
    class PokemonNegocio
    {
        //Clase que permite crear los métodos de acceso a datos de pókemon
        //Devuelve lista de Pokemons
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            //1.LescturaDB.2.b.Conexion Comando Lector
            //Objeto de conexión
            SqlConnection conexion = new SqlConnection();
            //Objeto de acciones
            SqlCommand comando = new SqlCommand();
            //Resultado de la lectura DB
            SqlDataReader lector;

            try
            {
                //1.LescturaDB.2.c.Configurar cadena de conexion
                //Cadena de conexión         servidor(local)       base de datos        cómo conectarse   
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                //Realizar acción      lectura
                comando.CommandType = System.Data.CommandType.Text;
                //Consulta SQL Server
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D  where E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                //Ejecutar comando en esta conexión
                comando.Connection = conexion;

                //1.LescturaDB.2.d.Abre conexión y Realiza lectura, ya esta el objeto en variable, todavia no hay selección
                conexion.Open();
                lector = comando.ExecuteReader();

                //1.LescturaDB.2.d.Lee el lector en caso de que devuelva true
                while (lector.Read())
                {
                    //Crear pokemon auxiliar para cargar datos del registro
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0); //GetInt32 == Int
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //2.ImagenDesdeDB.2.Cargar datos de Imagen
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    //3.DatosRelacionadosDB.2.Cargar datos de tipo Elemento. tirar esa linea de comando para que la referencia Tipo no de nula.
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    //Agrega ese pokemon a la lista
                    lista.Add(aux);
                }

                //1.LescturaDB.2.e.Cierra la conexión y devuelve la lista
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
