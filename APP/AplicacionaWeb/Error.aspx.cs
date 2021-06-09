using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionaWeb
{
    public partial class Error : System.Web.UI.Page
    {
        public static string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            error = (String)Session["Exception"];
            lblError.Text = error;  
        }
    }
}