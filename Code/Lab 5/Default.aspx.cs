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
            DropDownList1.Items.Add("Select an Item");
            DropDownList1.Items.Add("Bugatti");
            DropDownList1.Items.Add("Lamborgini");
            DropDownList1.Items.Add("Maruti");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string url = "Default2.aspx?";
        url += "company=" + Server.UrlEncode(DropDownList1.SelectedItem.Text)+"&";
        url += "model=" + Server.UrlEncode(TextBox1.Text);
        Response.Redirect(url);
    }
}