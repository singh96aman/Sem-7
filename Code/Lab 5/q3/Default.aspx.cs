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
            DropDownList1.Items.Add("Muli");
            DropDownList1.Items.Add("Gajar");
            DropDownList1.Items.Add("Karela");
            DropDownList1.Items.Add("Aloo");
            if (Session["cart"] != null)
                Label1.Text = (string)Session["cart"];
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["cart"] == null)
            Session["cart"] = DropDownList1.SelectedItem.Text;
        else
            Session["cart"] = (string)Session["cart"] + " " + DropDownList1.SelectedItem.Text;

        Label1.Text = (string)Session["cart"];
    }
}