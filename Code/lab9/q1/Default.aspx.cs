using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    static List<String> fruits = new List<string>();
    static List<string> icecream = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("WaterMelon");
            fruits.Add("Grapes");
            icecream.Add("Vanilla");
            icecream.Add("Strawberry");
            icecream.Add("Black Current");
            icecream.Add("Butter Scotch");
            CheckBoxList1.DataSource = fruits;
            RadioButtonList1.DataSource = icecream;
            this.DataBind();
            
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string ans = "";
        for(int i=0; i<CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                ans += CheckBoxList1.Items[i].Value + " ";
            }
        }
        ans += " " + RadioButtonList1.SelectedItem.Text+" Milk Shake";
        Label1.Text = ans;
    }
}