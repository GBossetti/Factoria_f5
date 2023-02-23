using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoBD;

namespace Negocio
{
    class ImagenNegocio
    {
        public List<Imagen> listar(bool activo = true)
        {
            List<Imagen> listaImagen = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("listarActivas");
                datos.setearParametro("@estado", activo);
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (long)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Directorio = (string)datos.Lector["Directorio"];
                }

                return listaImagen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
