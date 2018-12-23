using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label2.Text = "First Login";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text == "admin" && TextBox2.Text ==  "pass")

          
    }
}