using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["info"] != null)
            Label1.Text = (string)Session["info"];
        if (!IsPostBack)
        {
            Label2.Text = 1.ToString() ;
            Session["counter"] = 1;
        }
        else
        {
            int val = Convert.ToInt32(Session["counter"]);
            val++;
            Label2.Text = val.ToString();
            Session["counter"] = val.ToString();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}