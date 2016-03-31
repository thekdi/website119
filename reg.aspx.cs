using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reg : System.Web.UI.Page
{
    PropertyService ps = new PropertyService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
           
            Fillgrid();
        }

    }

    private void Fillgrid()
    {
        GridView1.DataSource = ps.getinfo();
        GridView1.DataBind();
       
    }

   
    protected void Button1_Click(object sender, EventArgs e)
    {
        ps.fname = txtfname.Text;
        ps.lname = txtlname.Text;
        ps.insertinfo(ps);
        Fillgrid();

    }
}