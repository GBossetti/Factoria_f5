using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoBD;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarImagen(bool activo = true)
        {
            List<Imagen> listaImagen = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("listar");
                datos.setearParametro("@estado", activo);
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (long)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Directorio = (string)datos.Lector["Directorio"];

                    listaImagen.Add(aux);
                }

                return listaImagen;
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

        public void guardarImagen(string titulo, string directorio)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("guardar");
                datos.setearParametro("@Titulo", titulo);
                datos.setearParametro("@Directorio", directorio);
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

        public void eliminarLogico(long id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("eliminarLogico");
                datos.setearParametro("@Id", id);
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

        public Imagen cargarImagen(long id)
        {
            Imagen imagen = new Imagen();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("cargar");
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    imagen.Titulo = (string)datos.Lector["Titulo"];
                    imagen.Directorio = (string)datos.Lector["Directorio"];
                    imagen.Id = id;
                }

                return imagen;
                
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

        public void modificarImagen(long id, string titulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("modificar");
                datos.setearParametro("@Id", id);
                datos.setearParametro("@Titulo", titulo);
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
    
        public void restaurarImagen(long id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("restaurar");
                datos.setearParametro("@Id", id);
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

        
    }
}
