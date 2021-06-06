﻿using System;
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
        public List<Articulo> favoritos;
        protected void Page_Load(object sender, EventArgs e)
        {
            favoritos = (List<Articulo>)Session["listaFavoritos"];
            if (favoritos == null)
                favoritos = new List<Articulo>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    //if (favoritos.Find(x => x.Id.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Articulo> listadoOriginal = (List<Articulo>)Session["listadoProductos"];
                        favoritos.Add(listadoOriginal.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                    }
                }

                //Repeater
                repetidor.DataSource = favoritos;
                repetidor.DataBind();
            }
            decimal total = 0;

            Session.Add("listaFavoritos", favoritos);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> favoritos = (List<Articulo>)Session["listaFavoritos"];
            Articulo elim = favoritos.Find(x => x.Id.ToString() == argument);
            favoritos.Remove(elim);
            Session.Add("listaFavoritos", favoritos);
            repetidor.DataSource = null;
            repetidor.DataSource = favoritos;
            repetidor.DataBind();
        }

        //    try
        //    {
        //        int id = int.Parse(Request.QueryString["id"]);
        //        List<Articulo> listado = (List<Articulo>)Session["listadoProductos"];
        //        Articulo seleccionado = listado.Find(x => x.Id == id);

        //        lblSeleccionado.Text = seleccionado.Nombre;
        //        lblUrlImagen.Text = seleccionado.UrlImagen;
        //    }
        //    catch (Exception ex)
        //    {

        //        Response.Redirect("Error.aspx");

        //    }
        //}

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