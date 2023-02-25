using dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ElementoNegocio
    {
        //2.ClaseAccesoADatosCentralizado.8.Crear el elemento negocio
        public List<Elemento> listar()
        {
            //lista que va a devolver
            List<Elemento>lista= new List<Elemento>();
            //2.ClaseAccesoADatosCentralizado.8.1.Declarar acceso a datos
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //2.ClaseAccesoADatosCentralizado.8.2.Setear la consulta a realizar
                datos.setearConsulta("select Id, Descripcion from ELEMENTOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //2.ClaseAccesoADatosCentralizado.8.3.Cerrar conector
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
