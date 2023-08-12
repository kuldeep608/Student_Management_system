using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Reg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S5FK018\MSSQL1;Initial Catalog=ussdata;Integrated Security=True");
    SqlDataReader dr;
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_insert_Click(object sender, EventArgs e)
    {
        con.Open();
        string s = "insert into Student(StudentId,Sname,Age,UserId,Pwd,Cpwd,Emailid,Address1) values(@StudentId,@Sname,@Age,@UserId,@Pwd,@Cpwd,@Emailid,@Address1)";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@StudentId", txt_sid.Text);
        cmd.Parameters.AddWithValue("@Sname", txt_sname.Text);
        cmd.Parameters.AddWithValue("@Age", txt_age.Text);
        cmd.Parameters.AddWithValue("@UserId", txt_userid.Text);
        cmd.Parameters.AddWithValue("@Pwd", txt_pwd.Text);
        cmd.Parameters.AddWithValue("@Cpwd", txt_cpwd.Text);
        cmd.Parameters.AddWithValue("@Emailid", txt_emailid.Text);
        cmd.Parameters.AddWithValue("@Address1", txt_address.Text);
        cmd.ExecuteNonQuery();
        Response.Write("Deta Inserted Successfully...");
        con.Close();
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        con.Open();
        string s = "Update Student set Sname=@Sname,Age=@Age,UserId=@UserId,Pwd=@Pwd,Cpwd=@Cpwd,Emailid=v,Address1=@Address1 where StudentId=@StudentId";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@StudentId", txt_sid.Text);
        cmd.Parameters.AddWithValue("@Sname", txt_sname.Text);
        cmd.Parameters.AddWithValue("@Age", txt_age.Text);
        cmd.Parameters.AddWithValue("@UserId", txt_userid.Text);
        cmd.Parameters.AddWithValue("@Pwd", txt_pwd.Text);
        cmd.Parameters.AddWithValue("@Cpwd", txt_cpwd.Text);
        cmd.Parameters.AddWithValue("@Emailid", txt_emailid.Text);
        cmd.Parameters.AddWithValue("@Address1", txt_address.Text);
        cmd.ExecuteNonQuery();
        Response.Write("Data Updated Successfully...");
        con.Close();
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        con.Open();
        string s = "delete from Student  where StudentId=@StudentId";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@StudentId", txt_sid.Text);
        cmd.Parameters.AddWithValue("@Sname", txt_sname.Text);
        cmd.Parameters.AddWithValue("@Age", txt_age.Text);
        cmd.Parameters.AddWithValue("@UserId", txt_userid.Text);
        cmd.Parameters.AddWithValue("@Pwd", txt_pwd.Text);
        cmd.Parameters.AddWithValue("@Cpwd", txt_cpwd.Text);
        cmd.Parameters.AddWithValue("@Emailid", txt_emailid.Text);
        cmd.Parameters.AddWithValue("@Address1", txt_address.Text);
        cmd.ExecuteNonQuery();
        Response.Write("Data Deleted Successfully...");
        con.Close();
    }
}