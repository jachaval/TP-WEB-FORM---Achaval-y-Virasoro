using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace AplicacionaWeb
{
    public partial class _Default : Page
    {
        public List<Articulo> lista;
        //public List<Articulo> listaseleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar();
                Session.Add("listadoProductos", lista);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
        //private void Agregar(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string id = Request.QueryString["id"];
        //        Articulo seleccionado = lista.Find(x => x.CodigoArticulo == id);
        //        listaseleccionado.Add(seleccionado);
        //        Session.Add("listacarrito", listaseleccionado);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Redirect("Error.aspx");
        //    }
        //}
    }
}