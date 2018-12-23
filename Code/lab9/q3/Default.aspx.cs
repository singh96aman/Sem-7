using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static Dictionary<Int32, String> state = new Dictionary<int, string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            state.Add(1, "Uttar Pradesh");
            state.Add(2, "Maharashtra");
            DropDownList1.DataSource = state;
            DropDownList1.DataTextField = "Value";
            DropDownList1.DataValueField = "Key";
            this.DataBind();
        }
    }
}