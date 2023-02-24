using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApp
{
    public partial class CargarImg : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenNegocio negocio = new ImagenNegocio();
                string dia = DateTime.Now.ToString("yyyyMMddHHmmss");

                string titulo = txtTitulo.Text;
                string ruta = Server.MapPath("./Imagenes/");
                string archivo = "img_" + dia + ".jpg";
                txtImagen.PostedFile.SaveAs(ruta + archivo);

                negocio.guardarImagen(titulo, archivo);

                Response.Redirect("Default.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}