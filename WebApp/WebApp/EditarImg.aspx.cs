using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApp
{
    public partial class EditarImg : System.Web.UI.Page
    {
        Imagen imagen = new Imagen();
        protected void Page_Load(object sender, EventArgs e)
        {
            long id = long.Parse(Request.QueryString["Id"]);
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                imagen = negocio.cargarImagen(id);
                imgImagen.ImageUrl = "./Imagenes/" + imagen.Directorio;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            string titulo = imagen.Titulo;

            if (txtTitulo.Text != "")
                titulo = txtTitulo.Text;
            
            try
            {
                negocio.modificarImagen(imagen.Id, titulo);
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}