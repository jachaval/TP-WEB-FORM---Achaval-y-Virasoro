using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;


namespace AplicacionaWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Request.QueryString["id"]);
                List<Articulo> listado = (List<Articulo>)Session["listadoProductos"];
                Articulo seleccionado = listado.Find(x => x.Id == id);

                lblSeleccionado.Text = seleccionado.Nombre;
                lblUrlImagen.Text = seleccionado.UrlImagen;
            }
            catch (Exception ex)
            {

                Response.Redirect("Error.aspx");

            }
        }

        //public static List<Articulo> carrito;
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    try {
        //        carrito = (List<Articulo>)Session["listacarrito"];
        //    }
        //    catch(Exception ex)
        //    {

        //        Response.Redirect("Error.aspx");

        //    }
        //}

    }
}