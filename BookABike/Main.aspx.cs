using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace BookABike
{
    public partial class Main : System.Web.UI.Page
    {
        //Cathryn
        static bool doNothinTest;
        static string staffStatus = "";
        static SqlConnection connectDB;
        static SqlCommand commandDB;
        static string constrDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UsersDB.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            up1.Attributes.CssStyle.Add("width", "40%");

            HttpCookie cookie = Request.Cookies["login"];

            if (cookie == null)
            {
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                Button1.Enabled = true;
            }
            else if(int.Parse(cookie["count"]) > 2)
            {
                HyperLink1.Visible = true;
            }
            else if (int.Parse(cookie["count"]) >= 5)
            {
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                Button1.Enabled = false;
            }
            else
            {
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                Button1.Enabled = true;
            }

        }

        
        protected void Timer1_Tick(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e) //Login Button
        {
            string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox3.Text.Trim(), "SHA1");
            
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nedua\Desktop\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM UserTable WHERE Client_ID=@Client_ID AND Client_Password=@Client_Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Client_ID", TextBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Client_Password", hashresult);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    HttpCookie cookie = Request.Cookies["login"];
                    if (cookie == null)
                    {
                        cookie = new HttpCookie("login");
                        cookie["count"] = "0";
                    }

                    cookie.Expires = DateTime.Now.AddMinutes(15);
                    Response.Cookies.Add(cookie);


                    HttpCookie cookie2 = Request.Cookies["login"];

                    cookie2["count"] = "0";
                    Response.Cookies.Add(cookie2);

                    Session["Client_ID"] = TextBox2.Text.Trim();
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    
                    HttpCookie cookie = Request.Cookies["login"];
                    if (cookie == null)
                    {
                        cookie = new HttpCookie("login");
                        cookie["count"] = "0";
                    }
                    if (cookie["count"] == "3")
                    {
                        HyperLink1.Visible = true;
                    }
                    if (int.Parse(cookie["count"]) >= 5)
                    {
                        TextBox2.Enabled = false;
                        TextBox3.Enabled = false;
                        Button1.Enabled = false;
                        string script2 = "alert(\"You have entered the username and password incorrectly, more than five times! Login Has been disabled for 15 Minutes!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                    }
                    int val = int.Parse(cookie["count"]);
                    int val2 = val + 1;
                    cookie["count"] = "" + val2;
                    
                    cookie.Expires = DateTime.Now.AddMinutes(15);
                    Response.Cookies.Add(cookie);

                    string script = "alert(\"Username and Password does not match\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                sqlCon.Close();
            }
        }

        protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("BikeStations.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStaff.Checked)
            {
                staffStatus = "STAFF";
            }            
            else if (rdbAdmin.Checked)
            {
                staffStatus = "ADMIN";
            }
        }

        protected void btnStaffLogin_Click(object sender, EventArgs e)
        {
        }
        protected void test1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string staffEmail, staffPass, staffEmailDB, staffPassDB, checkAdmin;
            bool credentials = false;
            if (staffStatus == "ADMIN"||staffStatus=="STAFF")
            {                
                staffEmail = HiddenField1.Value.Trim();
                staffPass = HiddenField2.Value.Trim();
                string connectionDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UsersDB.mdf;Integrated Security=True";
                string query = "SELECT * FROM Staff";
                SqlConnection sqlCon = new SqlConnection(connectionDB);
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                /////////////////////Hasing password
                MD5CryptoServiceProvider sh = new MD5CryptoServiceProvider();
                UTF32Encoding utf8 = new UTF32Encoding();
                string hashPassStaff = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(staffPass)));
                ////////////////////
                while (dataReader.Read())
                {
                    staffEmailDB = dataReader.GetValue(5).ToString();
                    staffEmailDB.Trim();
                    staffPassDB = dataReader.GetValue(7).ToString();
                    staffPassDB.Trim();
                    if (staffEmailDB == staffEmail)
                    {
                        if (hashPassStaff == staffPassDB)
                        {
                            if (rdbAdmin.Checked)
                            {
                                checkAdmin = dataReader.GetValue(8).ToString();
                                checkAdmin.Trim();
                                if (checkAdmin == "True")
                                {
                                    credentials = true;
                                }
                                else
                                {
                                    Response.Write("<script>alert('You are not an admin, try again!')</script>");
                                }
                            }
                            else
                            {
                                credentials = true;
                            }
                        }
                    }
                }
                sqlCon.Close();
                
                if (credentials)
                {
                    Response.Redirect("~/AdminStaff.aspx?isAdmin="+staffStatus);
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please select if you are a admin or staff!')</script>");
            }
        }

        protected void txtStaffPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}