using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;



namespace BookABike
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            string sql = "DELETE FROM Client WHERE Client_Email = '" + Session["registerClient"].ToString() + "'";

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter adap = new SqlDataAdapter();

            adap.DeleteCommand = new SqlCommand(sql, conn);
            adap.DeleteCommand.ExecuteNonQuery();

            comm.Dispose();
            conn.Close();

            Response.Redirect("~/Main.aspx");
            Response.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label5.Text = "";
            if (Page.IsValid)
            {
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
                string sql = "SELECT * FROM UserTable";

                string username = txtFirstName.Text;
                string email = txtEmail.Text;

                int umatch = 0;
                int ematch = 0;

                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    if ("" + dataReader.GetValue(0) == email)
                    {
                        ematch++;
                    }

                    if ("" + dataReader.GetValue(1) == username)
                    {
                        umatch++;
                    }
                }

                dataReader.Close();
                comm.Dispose();
                conn.Close();

                if (umatch != 0)
                {
                    Label5.Text = "Username is already taken !";
                    Label5.Visible = true;
                }

                if (ematch != 0)
                {
                    Label5.Text = ".............Email is already in use !.............";
                    Label5.Visible = true;
                }

                if (umatch != 0 && ematch != 0)
                {
                    Label5.Text = "Email and Username is already in use !";
                }

                if (umatch == 0 && ematch == 0)
                {

                    bool isStudent = false;

                    if (CheckBox1.Checked == true)
                    {
                        isStudent = true;
                        CheckBox2.Checked = false;
                    }

                    if (CheckBox2.Checked == true)
                    {
                        isStudent = false;
                        CheckBox1.Checked = false;
                    }


                    string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
                    string insert_query = "INSERT INTO Client VALUES (@Client_FirstName, @Client_LastName, @Client_ContactNumber, @Client_Email, @Is_Student, @Client_Password)";

                    SqlConnection conn2 = new SqlConnection(constr);
                    conn2.Open();
                    SqlCommand comm2 = new SqlCommand(insert_query, conn2);

                    comm2.Parameters.AddWithValue("@Client_FirstName", "" + txtFirstName.Text);
                    comm2.Parameters.AddWithValue("@Client_LastName", "" + txtLastName.Text);
                    comm2.Parameters.AddWithValue("@Client_ContactNumber", "" +txtContactNumber.Text);
                    comm2.Parameters.AddWithValue("@Client_Email", "" + txtEmail.Text);
                    comm2.Parameters.AddWithValue("@Is_Student", isStudent);//Hoe add mend dit in die DB
                    comm2.Parameters.AddWithValue("@Client_Password", ""  + hashresult);


                    comm2.ExecuteNonQuery();

                    string script = "alert(\"Register Success\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    comm2.Dispose();
                    conn2.Close();

                    RequiredFieldValidator1.Enabled = false;
                    RequiredFieldValidator2.Enabled = false;
                    RequiredFieldValidator5.Enabled = false;
                    RequiredFieldValidator6.Enabled = false;
                    RequiredFieldValidator7.Enabled = false;

                    //Label6.Visible = true;
                    //DropDownList1.Visible = true;
                    //Label7.Visible = true;
                    //TextBox4.Visible = true;
                    //Button3.Visible = true;
                    //Button4.Visible = true;

                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtContactNumber.Enabled = false;
                    txtEmail.Enabled = false;
                    CheckBox1.Enabled = false;
                    CheckBox2.Enabled = false;
                    txtPassword.Enabled = false;
                    txtEmail.Enabled = false;
                    Button1.Enabled = false;
                    Button2.Enabled = false;

                    Session["registerClient"] = txtFirstName.Text;

                    //ClientScript.RegisterClientScriptBlock(this.GetType(), "", "window.onload=function(){window.scrollTo(0,document.body.scrollHeight)};", true);

                }
            }
        }
    

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(DropDownList1.SelectedIndex == 5)
            //{
            //    TextBox5.Visible = true;
            //    Label8.Visible = true;
            //    RequiredFieldValidator3.Enabled = true;
            //}
            //else
            //{
            //    TextBox5.Visible = false;
            //    Label8.Visible = false;
            //    RequiredFieldValidator3.Enabled = false;
            //}
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //RequiredFieldValidator4.Enabled = true;
            //RequiredFieldValidator1.Enabled = false;
            //RequiredFieldValidator2.Enabled = false;
            //RegularExpressionValidator1.Enabled = false;

            //if (Page.IsValid)
            //{
            //    if(DropDownList1.SelectedIndex == 5)
            //    {
            //        string insert_query = "UPDATE UserTable SET SecurityQuestion = '" + TextBox5.Text + "', SecurityAnswer = '" + TextBox4.Text.ToLower() + "' WHERE username = '" + Session["registerusername"].ToString() + "'";
            //        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            //        SqlConnection conn2 = new SqlConnection(constr);
            //        conn2.Open();
            //        SqlCommand comm2 = new SqlCommand(insert_query, conn2);

            //        comm2.ExecuteNonQuery();


            //        comm2.Dispose();
            //        conn2.Close();

            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Registration Successfull! You will now be redirected to the Main Page'); window.open('Main.aspx');", true);

            //    }
            //    else
            //    {
            //        string insert_query = "UPDATE UserTable SET SecurityQuestion = '" + DropDownList1.Text + "', SecurityAnswer = '" + TextBox4.Text.ToLower() + "' WHERE username = '" + Session["registerusername"].ToString() + "'";
            //        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            //        SqlConnection conn2 = new SqlConnection(constr);
            //        conn2.Open();
            //        SqlCommand comm2 = new SqlCommand(insert_query, conn2);

            //        comm2.ExecuteNonQuery();


            //        comm2.Dispose();
            //        conn2.Close();

            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Registration Successfull! You will now be redirected to the Main Page'); window.open('Main.aspx'); window.close('Register.aspx')", true);
                //}
        }
        
    }
}