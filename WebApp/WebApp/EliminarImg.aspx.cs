using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApp
{
    public partial class EliminarImg : System.Web.UI.Page
    {
        public bool eliminado = false;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            long id = long.Parse(Request.QueryString["Id"]);

            ImagenNegocio negocio = new ImagenNegocio();
            negocio.eliminarLogico(id);

            eliminado = true;
        }
    }
}