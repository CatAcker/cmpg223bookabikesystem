using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace BookABike
{
    public partial class ResetPassword2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["validAcc"] == null)
            {
                string script = "alert(\"ACCESS DENIED\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Response.Redirect("Main.aspx");
                Response.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Main.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == TextBox3.Text)
            {
                string hpass = "";


                string myQuery = "UPDATE UserTable SET password = @password Where username = @username";
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                    {
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar, 250);
                        cmd.Parameters["@password"].Value = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox3.Text.Trim(), "SHA1");
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50);
                        cmd.Parameters["@username"].Value = Session["validAcc"];
                        connection.Open();

                        cmd.ExecuteScalar();
                        connection.Close();
                    }


                }

                string script = "alert(\"Password updated Successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                HttpCookie cookie = Request.Cookies["login"];

                cookie["count"] = "0";
                Response.Cookies.Add(cookie);

                Session.Abandon();
                Response.Redirect("Main.aspx");
                Response.Close();
            }

            else
            {
                string script = "alert(\"New passwords does not match!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            
        }
    }
}