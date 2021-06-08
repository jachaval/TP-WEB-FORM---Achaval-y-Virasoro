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
        public List<Articulo> listaFiltrada;
        //public List<Articulo> listaseleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (!IsPostBack)
            {
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
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string argument = ((Button)sender).CommandArgument.ToUpper();
            listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper() == argument);
            listaFiltrada = negocio.listar();


            //ArticuloNegocio negocio = new ArticuloNegocio();
            //lista = negocio.listar();
            //string buscado = txtBuscado.Text.ToUpper();
            //if (txtBuscado.Text != "")
            //{
            //        lista = lista.FindAll(
            //        X => (
            //            X.Nombre.ToUpper().Contains(buscado) ||
            //            X.CodigoArticulo.Contains(buscado)));
            //        lista = negocio.listar();
            //}
            //else
            //{
            //    lista = negocio.listar();
            //}
        }
        //private void txtFiltro_TextChanged(object sender, EventArgs e)
        //{
        //    string texto = txtFiltro.Text.ToUpper();

        //    if (txtFiltro.Text != "")
        //    {
        //        List<Articulo> listaFiltrada = listaArticulos.FindAll(
        //            X => (
        //                X.Nombre.ToUpper().Contains(texto) ||
        //                X.CodigoArticulo.Contains(texto) ||
        //                X.Descripcion.ToUpper().Contains(texto)));
        //        dgvArticulos.DataSource = null;
        //        dgvArticulos.DataSource = listaFiltrada;
        //    }
        //    else
        //    {
        //        dgvArticulos.DataSource = null;
        //        dgvArticulos.DataSource = listaArticulos;
        //    }
        //}

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