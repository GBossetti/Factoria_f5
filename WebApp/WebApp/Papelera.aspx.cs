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
    public partial class Papelera : System.Web.UI.Page
    {
        long id;
        Imagen aux = new Imagen();
        ImagenNegocio negocioAux = new ImagenNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Imagen imagen = new Imagen();
                    ImagenNegocio negocio = new ImagenNegocio();
                    dgvPapelera.DataSource = negocio.listarImagen(false);
                    dgvPapelera.DataBind();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void dgvPapelera_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = dgvPapelera.SelectedRow.Cells[1].Text;
            id = long.Parse(dgvPapelera.SelectedDataKey.Value.ToString());

            if (IsPostBack)
            {
                try
                {
                    aux = negocioAux.cargarImagen(id);
                    lblTitulo.Text = aux.Titulo;
                    imgImagen.ImageUrl = "./Imagenes/" + aux.Directorio;
                    Session.Add("Id", id);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        protected void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                id = long.Parse(Session["Id"].ToString());
                negocioAux.restaurarImagen(id);
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}