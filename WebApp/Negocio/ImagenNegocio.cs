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
        public List<Imagen> listar(bool activo = true)
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

        public void cargar(string titulo, string directorio)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("cargar");
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

    }
}
