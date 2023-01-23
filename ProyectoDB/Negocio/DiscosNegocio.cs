using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using dominio;
using Negocio;
using System.Data;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Tipo from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Tipo = new TipoEdicion();
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                    lista.Add(aux);
                }
                
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Agregar(Discos nuevo)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion) values ('" + nuevo.Titulo + "', '" + nuevo.FechaLanzamiento + "', '" + nuevo.CantidadCanciones + "', @IdEstilo, @IdTipoEdicion)");
                dato.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                dato.setearParametro("@IdTipoEdicion", nuevo.Tipo.Id);
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
    }
}
