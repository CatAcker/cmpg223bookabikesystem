using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BookABike
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Main.aspx");
            Response.Close();
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            string constr;

            //The connection string can be found at the database properties
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(constr); //Assign the connection

            conn.Open(); //Opens the Connection

            //Defining the variables
            SqlCommand comm;
            SqlDataReader dataReader;
            String sql, uname, email;

            //Defining the Sql Statement
            sql = "SELECT * FROM UserTable";

            //The Command Statement
            comm = new SqlCommand(sql, conn);

            //Defining the data reader
            dataReader = comm.ExecuteReader();

            //Getting the table values
            while (dataReader.Read())
            {
                email = "" + dataReader.GetValue(0);
                uname = ""+dataReader.GetValue(1);
                

                if(uname == TextBox1.Text && email == TextBox3.Text)
                {
                    Session["resetPass"] = uname;
                    TextBox1.Enabled = false;
                    TextBox3.Enabled = false;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    TextBox6.Visible = true;
                    TextBox5.Visible = true;
                    Button3.Visible = true;
                    Button4.Visible = true;
                    Label6.Visible = true;
                    Label8.Visible = true;

                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "window.onload=function(){window.scrollTo(0,document.body.scrollHeight)};", true);

                    string constr2;

                    //The connection string can be found at the database properties
                    constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                    SqlConnection conn2 = new SqlConnection(constr2); //Assign the connection

                    conn2.Open(); //Opens the Connection

                    //Defining the variables
                    SqlCommand comm2;
                    SqlDataReader dataReader2;
                    String sql2;
                    String question = "";
                    String answer = "";
                    

                    //Defining the Sql Statement
                    sql2 = "SELECT * FROM UserTable WHERE username = '" + Session["resetPass"].ToString() + "'";

                    //The Command Statement
                    comm2 = new SqlCommand(sql2, conn2);

                    //Defining the data reader
                    dataReader2 = comm2.ExecuteReader();

                    //Getting the table values
                    while (dataReader2.Read())
                    {
                        question = "" + dataReader2.GetValue(3);
                        answer = "" + dataReader2.GetValue(4);
                    }

                    TextBox6.Enabled = false;
                    TextBox6.Text = question;

                    dataReader2.Close(); //Close the Data Reader!
                    comm2.Dispose(); //Stop the command!
                    conn2.Close();
                }

            }
            if (Session["resetPass"] == null)
            {

                string script = "alert(\"Incorrect Username or Email\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

            }
            dataReader.Close(); //Close the Data Reader!
            comm.Dispose(); //Stop the command!
            conn.Close(); //Always Close the Connection when done!
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string constr2;

            //The connection string can be found at the database properties
            constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

            SqlConnection conn2 = new SqlConnection(constr2); //Assign the connection

            conn2.Open(); //Opens the Connection

            //Defining the variables
            SqlCommand comm2;
            SqlDataReader dataReader2;
            String sql2;
            String question = "";
            String answer = "";


            //Defining the Sql Statement
            sql2 = "SELECT * FROM UserTable WHERE username = '" + Session["resetPass"].ToString() + "'";

            //The Command Statement
            comm2 = new SqlCommand(sql2, conn2);

            //Defining the data reader
            dataReader2 = comm2.ExecuteReader();

            //Getting the table values
            while (dataReader2.Read())
            {
                question = "" + dataReader2.GetValue(3);
                answer = "" + dataReader2.GetValue(4);
            }

            TextBox6.Enabled = false;
            TextBox6.Text = question;

            dataReader2.Close(); //Close the Data Reader!
            comm2.Dispose();
            if (TextBox5.Text.ToLower() == answer)
            {
                TextBox5.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Session["validAcc"] = Session["resetPass"];
                Response.Redirect("ResetPassword2.aspx");
            }
            else
            {
                string script = "alert(\"Incorrect Answer\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}