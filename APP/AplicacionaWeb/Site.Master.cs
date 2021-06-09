﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionaWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cant = (string)Session["cantidadArticulos"];
            lblCantidad.Text = cant;
            if(cant == "")
            {
                cant = "0";
                lblCantidad.Text = cant; 
            }
        }
    }
}