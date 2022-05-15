using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef15_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                lblBericht.Text = $"Hallo {txtNaam.Text}";
        }

        protected void btnVerstuur_Click(object sender, EventArgs e)
        {

        }
    }
}