using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para declarar objetos de conexión
using System.Data.SqlClient;

namespace winform_app
{
    class PokemonNegocio
    {
        //Clase que permite crear los métodos de acceso a datos de pókemon
        //Devuelve lista de Pokemons
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            //Objeto de conexión
            SqlConnection conexion = new SqlConnection();
            //Objeto de acciones
            SqlCommand comando = new SqlCommand();
            //Resultado de la lectura DB
            SqlDataReader lector;

            try
            {
                //Cadena de conexión         servidor(local)       base de datos        cómo conectarse   
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                //Realizar acción      lectura
                comando.CommandType = System.Data.CommandType.Text;
                //Consulta SQL Server
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D  where E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                //Ejecutar comando en esta conexión
                comando.Connection = conexion;

                //Abre conexión
                conexion.Open();
                //Realiza lectura, ya esta el objeto en variable, todavia no hay selección
                lector = comando.ExecuteReader();

                //Leer el lector
                while (lector.Read())
                {
                    //Crear pokemon auxiliar para cargar datos del registro
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0); //GetInt32 == Int
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //Cargar datos de Imagen
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    //Cargar datos de otra tabla. tirar esa linea de comando para que la referencia Tipo no de nula.
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    //Agregas ese pokemon a la lista
                    lista.Add(aux);
                }

                //Cerrar la conexión
                conexion.Close();
                //Devuelve la lista
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
