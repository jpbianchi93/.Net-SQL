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
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Xml.Linq;

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
                datos.setearConsulta("select D.Id, D.IdEstilo, D.IdTipoEdicion, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Tipo from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Tipo = new TipoEdicion();
                    aux.Tipo.Id = (int)datos.Lector["IdTipoEdicion"];
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
                dato.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlimagenTapa, IdEstilo, IdTipoEdicion) values ('" + nuevo.Titulo + "', '" + nuevo.FechaLanzamiento + "', '" + nuevo.CantidadCanciones + "', @urlImagenTapa, @IdEstilo, @IdTipoEdicion)");
                dato.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
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

        public void Modificar(Discos disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo , FechaLanzamiento = @fecha, CantidadCanciones = @cantidad, UrlImagenTapa = @url, IdEstilo = @idEstilo, IdTipoEdicion = @idTipo where Id = @id");
                datos.setearParametro("@titulo", disco.Titulo);
                datos.setearParametro("@fecha", disco.FechaLanzamiento);
                datos.setearParametro("@cantidad", disco.CantidadCanciones);
                datos.setearParametro("@url", disco.UrlImagenTapa);
                datos.setearParametro("@idEstilo", disco.Estilo.Id);
                datos.setearParametro("@idTipo", disco.Tipo.Id);
                datos.setearParametro("@id", disco.Id);

                datos.ejecutarAccion();
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
        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from discos where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Discos> Filtrar(string campo, string criterio, string filtro)
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select D.Id, D.IdEstilo, D.IdTipoEdicion, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Tipo from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ";
                if (campo == "Cantidad de canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "D.CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "D.CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "D.CantidadCanciones = " + filtro;
                            break;
                    }
                }
                else if (campo == "Títutlo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "D.Titulo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "D.Titulo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "D.Titulo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo == "Estilo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "E.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "E.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "E.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "T.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "T.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "T.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Tipo = new TipoEdicion();
                    aux.Tipo.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
