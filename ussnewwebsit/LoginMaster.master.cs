using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class LoginMaster : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S5FK018\MSSQL1;Initial Catalog=ussdata;Integrated Security=True");
    SqlDataReader dr;
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string s = "select * from Student where UserId=@UserId and pwd=@pwd";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@UserId", txt_userid.Text);
        cmd.Parameters.AddWithValue("@pwd", txt_pwd.Text);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Response.Redirect("Welcome.Aspx");
        }
        else
        {
            RequiredFieldValidator1.IsValid = false;
            RequiredFieldValidator2.IsValid = false;
        }
    }
}
