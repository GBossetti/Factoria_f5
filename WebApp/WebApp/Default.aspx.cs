using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Imagen> listaImagen = new List<Imagen>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            listaImagen = negocio.listar();
        }
    }
}