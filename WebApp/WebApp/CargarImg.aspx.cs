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

                string titulo = txtTitulo.ToString();
                string ruta = Server.MapPath("./Imagenes/");
                txtImagen.PostedFile.SaveAs(ruta + "img_" + dia + ".jpg");

                negocio.cargar(titulo, ruta);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}