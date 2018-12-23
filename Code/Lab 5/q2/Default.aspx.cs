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
            DropDownList1.Items.Add("Select a Subject");
            DropDownList1.Items.Add("Physics");
            DropDownList1.Items.Add("Maths");
            DropDownList1.Items.Add("Chemistry");
            Session["counter"] = null;
            Session["info"] = null;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["info"] = TextBox1.Text+" "+TextBox2.Text+" "+DropDownList1.SelectedItem.ToString();
        Response.Redirect("Default2.aspx");

    }
}