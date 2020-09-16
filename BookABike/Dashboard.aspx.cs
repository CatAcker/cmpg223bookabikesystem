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
    public partial class Dashboard : System.Web.UI.Page
    {
        public string email;
        public string hpass;
        public int paym = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                Page.MaintainScrollPositionOnPostBack = true;
                try
                {
                    Label2.Text = Session["username"].ToString();
                }
                catch (Exception ex)
                {
                    string script = "alert(\"No Session\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                string constr2;


                constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                SqlConnection conn2 = new SqlConnection(constr2);
                conn2.Open();



                SqlCommand comm2;
                SqlDataReader dataReader;
                String sql2;



                sql2 = "SELECT userEmail, password FROM UserTable WHERE username = '" + Label2.Text + "'";


                comm2 = new SqlCommand(sql2, conn2);



                dataReader = comm2.ExecuteReader();

                while (dataReader.Read())
                {
                    email = dataReader.GetValue(0).ToString();
                    hpass = dataReader.GetValue(1).ToString();

                }



                dataReader.Close();
                comm2.Dispose();

                conn2.Close();




                SqlConnection conn = new SqlConnection(constr2); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataReader dataReader2;
                String sql, Output;

                //Defining the Sql Statement
                sql = "SELECT payment FROM PayTable WHERE username = '" + Label2.Text + "'";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Defining the data reader
                dataReader2 = comm.ExecuteReader();

                //Getting the table values
                while (dataReader2.Read())
                {
                    paym = int.Parse("" + dataReader2.GetValue(0));
                }
                dataReader2.Close(); //Close the Data Reader!
                comm.Dispose(); //Stop the command!
                conn.Close();
            }
            else
            {
                string script = "alert(\"ACCESS DENIED\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Response.Redirect("Main.aspx");
                Response.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Main.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
                // Panel9.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
                //Panel9.Visible = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Panel2.Visible == true)
            {
                Panel2.Visible = false;
            }
            else
            {
                Panel2.Visible = true;
                ListBox1.Items.Clear();

                string constr;

                //The connection string can be found at the database properties
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataReader dataReader;
                String sql;

                //Defining the Sql Statement
                sql = "SELECT coutDate, returnDate, coutTime, returnTime, cost FROM BookingsTable WHERE username = '" + Label2.Text + "' AND payment = 0";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Defining the data reader
                dataReader = comm.ExecuteReader();
                int count = 1;
                double outamount = 0;
                //Getting the table values
                while (dataReader.Read())
                {
                    string ct = "" + dataReader.GetValue(0);
                    string rt = "" + dataReader.GetValue(1);
                    string amount = "" + dataReader.GetValue(4);
                    outamount += double.Parse(amount);
                    double hours = double.Parse(amount) / 25;
                    ListBox1.Items.Add("Outstanding Payment " + count);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    ListBox1.Items.Add("Checkout:  " + ct.Split(' ')[0] + "  " + dataReader.GetValue(2));
                    ListBox1.Items.Add("Return:  " + rt.Split(' ')[0] + "  " + dataReader.GetValue(3));
                    ListBox1.Items.Add("Total Hours:  " + hours);
                    ListBox1.Items.Add("Rate:  R25/h");
                    ListBox1.Items.Add("Total:  R" + amount);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    count++;
                }

                conn.Close();
                Label10.Text = "" + outamount;
            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Panel3.Visible == true)
            {
                Panel3.Visible = false;
            }
            else
            {
                Panel3.Visible = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Panel4.Visible == true)
            {
                Panel4.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
            }
            else
            {
                Panel4.Visible = true;

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Panel5.Visible == true)
            {
                Panel5.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;

            }
            else
            {
                Panel5.Visible = true;
                if (paym == 1)
                {
                    ImageButton1.BorderColor = System.Drawing.Color.Red;
                    ImageButton1.BorderStyle = BorderStyle.Dashed;
                    ImageButton2.BorderStyle = BorderStyle.None;
                    ImageButton3.BorderStyle = BorderStyle.None;
                }
                else if (paym == 2)
                {
                    ImageButton2.BorderColor = System.Drawing.Color.Red;
                    ImageButton2.BorderStyle = BorderStyle.Dashed;
                    ImageButton1.BorderStyle = BorderStyle.None;
                    ImageButton3.BorderStyle = BorderStyle.None;
                }
                else if (paym == 3)
                {
                    ImageButton3.BorderColor = System.Drawing.Color.Red;
                    ImageButton3.BorderStyle = BorderStyle.Dashed;
                    ImageButton1.BorderStyle = BorderStyle.None;
                    ImageButton2.BorderStyle = BorderStyle.None;
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                string script = "alert(\"Please select a return date, either on the same day as the checkout date or later.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (Calendar1.SelectedDate == Calendar2.SelectedDate)
            {
                if (DropDownList1.SelectedIndex >= DropDownList2.SelectedIndex)
                {
                    string script = "alert(\"Please select a return time that is later than the checkout time.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {

                    int rate = 25;
                    string h1 = DropDownList1.Text.Split(':')[0];
                    string h2 = DropDownList2.Text.Split(':')[0];
                    int hours = ((Calendar2.SelectedDate.Day - Calendar1.SelectedDate.Day) * 24) + (int.Parse(h2) - int.Parse(h1));
                    double cost = hours * rate;

                    String constr;

                    //The connection string can be found at the database properties
                    constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                    SqlConnection conn = new SqlConnection(constr); //Assign the connection

                    conn.Open(); //Opens the Connection

                    //Defining the variables
                    SqlCommand comm;
                    SqlDataAdapter adap = new SqlDataAdapter();
                    String sql;

                    //Defining the Sql Statement
                    sql = "INSERT INTO BookingsTable(username, coutDate, returnDate, coutTime, returnTime, cost, payment) VALUES('" + Label2.Text + "', '" + Calendar1.SelectedDate + "', '" + Calendar2.SelectedDate + "', '" + DropDownList1.Text + "', '" + DropDownList2.Text + "', '" + cost + "', 0)";

                    //The Command Statement
                    comm = new SqlCommand(sql, conn);

                    //Assosiate the Insert Command:
                    adap.InsertCommand = new SqlCommand(sql, conn);
                    adap.InsertCommand.ExecuteNonQuery();

                    comm.Dispose(); //Stop the command!
                    conn.Close();


                    string script = "alert(\"Thank You! Your booking was made successfully. You will now be redirected to the Bookings Option.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    Panel2.Visible = true;
                    Panel1.Visible = false;

                    //////////////////////////////////
                    ListBox1.Items.Clear();

                    string constr2;

                    //The connection string can be found at the database properties
                    constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                    SqlConnection conn2 = new SqlConnection(constr2); //Assign the connection

                    conn2.Open(); //Opens the Connection

                    //Defining the variables
                    SqlCommand comm2;
                    SqlDataReader dataReader;
                    String sql2;

                    //Defining the Sql Statement
                    sql2 = "SELECT coutDate, returnDate, coutTime, returnTime, cost FROM BookingsTable WHERE username = '" + Label2.Text + "' AND payment = 0";

                    //The Command Statement
                    comm2 = new SqlCommand(sql2, conn2);

                    //Defining the data reader
                    dataReader = comm2.ExecuteReader();
                    int count = 1;
                    double outamount = 0;
                    //Getting the table values
                    while (dataReader.Read())
                    {
                        string ct = "" + dataReader.GetValue(0);
                        string rt = "" + dataReader.GetValue(1);
                        string amount = "" + dataReader.GetValue(4);
                        outamount += double.Parse(amount);
                        double hours2 = double.Parse(amount) / 25;
                        ListBox1.Items.Add("Outstanding Payment " + count);
                        ListBox1.Items.Add("----------------------------------------------------------");
                        ListBox1.Items.Add("Checkout:  " + ct.Split(' ')[0] + "  " + dataReader.GetValue(2));
                        ListBox1.Items.Add("Return:  " + rt.Split(' ')[0] + "  " + dataReader.GetValue(3));
                        ListBox1.Items.Add("Total Hours:  " + hours2);
                        ListBox1.Items.Add("Rate:  R25/h");
                        ListBox1.Items.Add("Total:  R" + amount);
                        ListBox1.Items.Add("----------------------------------------------------------");
                        count++;
                    }

                    conn2.Close();
                    Label10.Text = "" + outamount;

                }

            }
            else
            {
                int rate = 25;
                string h1 = DropDownList1.Text.Split(':')[0];
                string h2 = DropDownList2.Text.Split(':')[0];
                int hours = ((Calendar2.SelectedDate.Day - Calendar1.SelectedDate.Day) * 24) + (int.Parse(h2) - int.Parse(h1));
                double cost = hours * rate;

                String constr;

                //The connection string can be found at the database properties
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataAdapter adap = new SqlDataAdapter();
                String sql;

                //Defining the Sql Statement
                sql = "INSERT INTO BookingsTable(username, coutDate, returnDate, coutTime, returnTime, cost, payment) VALUES('" + Label2.Text + "', '" + Calendar1.SelectedDate + "', '" + Calendar2.SelectedDate + "', '" + DropDownList1.Text + "', '" + DropDownList2.Text + "', '" + cost + "', 0)";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Assosiate the Insert Command:
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();

                comm.Dispose(); //Stop the command!
                conn.Close();


                string script = "alert(\"Thank You! Your booking was made successfully. You will now be redirected to the Payment Page.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Panel2.Visible = true;
                Panel1.Visible = false;
                //////////////////////////////////
                ListBox1.Items.Clear();

                string constr2;


                constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                SqlConnection conn2 = new SqlConnection(constr2);

                conn2.Open();


                SqlCommand comm2;
                SqlDataReader dataReader;
                String sql2;


                sql2 = "SELECT coutDate, returnDate, coutTime, returnTime, cost FROM BookingsTable WHERE username = '" + Label2.Text + "' AND payment = 0";


                comm2 = new SqlCommand(sql2, conn2);


                dataReader = comm2.ExecuteReader();
                int count = 1;
                double outamount = 0;

                while (dataReader.Read())
                {
                    string ct = "" + dataReader.GetValue(0);
                    string rt = "" + dataReader.GetValue(1);
                    string amount = "" + dataReader.GetValue(4);
                    outamount += double.Parse(amount);
                    double hours2 = double.Parse(amount) / 25;
                    ListBox1.Items.Add("Outstanding Payment " + count);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    ListBox1.Items.Add("Checkout:  " + ct.Split(' ')[0] + "  " + dataReader.GetValue(2));
                    ListBox1.Items.Add("Return:  " + rt.Split(' ')[0] + "  " + dataReader.GetValue(3));
                    ListBox1.Items.Add("Total Hours:  " + hours2);
                    ListBox1.Items.Add("Rate:  R25/h");
                    ListBox1.Items.Add("Total:  R" + amount);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    count++;
                }

                conn2.Close();
                Label10.Text = "" + outamount;

            }
            Panel1.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Label10.Text != "0")
            {
                if (paym != 0)
                {
                    string myQuery = "UPDATE BookingsTable SET payment = @payment WHERE username = @username AND payment = 0";
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                        {
                            cmd.Parameters.Add("@payment", SqlDbType.Int);
                            cmd.Parameters["@payment"].Value = "1";
                            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@username"].Value = Label2.Text;
                            connection.Open();

                            cmd.ExecuteScalar();
                            connection.Close();
                        }


                    }
                    if (paym == 1)
                    {
                        string script = "alert(\"Outstanding Bookings Paid using: PAYPAL\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else if (paym == 2)
                    {
                        string script = "alert(\"Outstanding Bookings Paid using: MASTERCARD\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else if (paym == 3)
                    {
                        string script = "alert(\"Outstanding Bookings Paid using: AMERICAN EXPRESS\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {

                    string script = "alert(\"Please Select a Payment Method\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    Panel5.Visible = true;


                }

                Panel2.Visible = true;
                ListBox1.Items.Clear();

                string constr;

                //The connection string can be found at the database properties
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataReader dataReader;
                String sql;

                //Defining the Sql Statement
                sql = "SELECT coutDate, returnDate, coutTime, returnTime, cost FROM BookingsTable WHERE username = '" + Label2.Text + "' AND payment = 0";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Defining the data reader
                dataReader = comm.ExecuteReader();
                int count = 1;
                double outamount = 0;
                //Getting the table values
                while (dataReader.Read())
                {
                    string ct = "" + dataReader.GetValue(0);
                    string rt = "" + dataReader.GetValue(1);
                    string amount = "" + dataReader.GetValue(4);
                    outamount += double.Parse(amount);
                    double hours = double.Parse(amount) / 25;
                    ListBox1.Items.Add("Outstanding Payment " + count);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    ListBox1.Items.Add("Checkout:  " + ct.Split(' ')[0] + "  " + dataReader.GetValue(2));
                    ListBox1.Items.Add("Return:  " + rt.Split(' ')[0] + "  " + dataReader.GetValue(3));
                    ListBox1.Items.Add("Total Hours:  " + hours);
                    ListBox1.Items.Add("Rate:  R25/h");
                    ListBox1.Items.Add("Total:  R" + amount);
                    ListBox1.Items.Add("----------------------------------------------------------");
                    count++;
                }

                conn.Close();
                Label10.Text = "" + outamount;
            }
            else

            {
                string script = "alert(\"Payment Cancelled: Your outstanding payments is R0.00\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Panel5.Visible = true;
            }

    }

    protected void india_Click(object sender, ImageMapEventArgs e)
        {
            string aa = e.PostBackValue;
            if (aa == "1")
            {
                Image1.ImageUrl = "~/Images/l1.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.68217615397808, 27.09289217533717";

            }

            if (aa == "2")
            {
                Image1.ImageUrl = "~/Images/l2.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.68311323672968, 27.09485829085654";
            }

            if (aa == "3")
            {
                Image1.ImageUrl = "~/Images/l3.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.68253050822874, 27.09358663083191";
            }

            if (aa == "4")
            {
                Image1.ImageUrl = "~/Images/l4.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.684423, 27.105633";
            }

            if (aa == "5")
            {
                Image1.ImageUrl = "~/Images/l5.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6887091, 27.1036679";
            }

            if (aa == "6")
            {
                Image1.ImageUrl = "~/Images/l6.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6780168, 26.9022229";
            }

            if (aa == "7")
            {
                Image1.ImageUrl = "~/Images/l7.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.69804, 27.1117913";
            }

            if (aa == "8")
            {
                Image1.ImageUrl = "~/Images/l8.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7059085, 27.1135472";
            }

            if (aa == "9")
            {
                Image1.ImageUrl = "~/Images/l9.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.706848, 27.1098972";
            }

            if (aa == "10")
            {
                Image1.ImageUrl = "~/Images/l10.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6848534, 27.0946511";
            }

            if (aa == "11")
            {
                Image1.ImageUrl = "~/Images/l11.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.686485, 27.0921961";
            }

            if (aa == "12")
            {
                Image1.ImageUrl = "~/Images/l12.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6875953, 27.0923077";
            }

            if (aa == "13")
            {
                Image1.ImageUrl = "~/Images/l13.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6886884, 27.0912931";
            }

            if (aa == "14")
            {
                Image1.ImageUrl = "~/Images/l14.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6894743, 27.0911126";
            }

            if (aa == "15")
            {
                Image1.ImageUrl = "~/Images/l15.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6867198, 27.0947188";
            }

            if (aa == "16")
            {
                Image1.ImageUrl = "~/Images/l16.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6896847, 27.0944612";
            }

            if (aa == "17")
            {
                Image1.ImageUrl = "~/Images/l17.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6872168, 27.094139";
            }

            if (aa == "18")
            {
                Image1.ImageUrl = "~/Images/l18.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6985131, 27.1016758";
            }

            if (aa == "19")
            {
                Image1.ImageUrl = "~/Images/l19.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7106675, 27.0816512";
            }

            if (aa == "20")
            {
                Image1.ImageUrl = "~/Images/l20.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7088836, 27.0776065";
            }

            if (aa == "21")
            {
                Image1.ImageUrl = "~/Images/l21.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7130151, 27.0951313";
            }

            if (aa == "22")
            {
                Image1.ImageUrl = "~/Images/l22.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7087152, 27.097558";
            }

            if (aa == "23")
            {
                Image1.ImageUrl = "~/Images/l23.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7094511, 27.0945316";
            }

            if (aa == "24")
            {
                Image1.ImageUrl = "~/Images/l24.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7036884, 27.0979208";
            }

            if (aa == "25")
            {
                Image1.ImageUrl = "~/Images/l25.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7019796, 27.0977465";
            }

            if (aa == "26")
            {
                Image1.ImageUrl = "~/Images/l26.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7013066, 27.0887088";
            }

            if (aa == "27")
            {
                Image1.ImageUrl = "~/Images/l27.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7065718, 27.0854305";
            }


            if (aa == "28")
            {
                Image1.ImageUrl = "~/Images/l28.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.697886, 27.0917198";
            }
            if (aa == "29")
            {
                Image1.ImageUrl = "~/Images/l29.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6962422, 27.0891092";
            }
            if (aa == "30")
            {
                Image1.ImageUrl = "~/Images/l30.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6956402, 27.0921996";
            }
            if (aa == "31")
            {
                Image1.ImageUrl = "~/Images/l31.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6918564, 27.0924074";
            }
            if (aa == "32")
            {
                Image1.ImageUrl = "~/Images/l32.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6926579, 27.0912873";
            }
            if (aa == "33")
            {
                Image1.ImageUrl = "~/Images/l33.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6934658, 27.0938114";
            }
            if (aa == "34")
            {
                Image1.ImageUrl = "~/Images/l34.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6938566, 27.0845337";
            }
            if (aa == "35")
            {
                Image1.ImageUrl = "~/Images/l35.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6996853, 27.0845941";
            }
            if (aa == "36")
            {
                Image1.ImageUrl = "~/Images/l36.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.698661, 27.0764065";
            }
            if (aa == "37")
            {
                Image1.ImageUrl = "~/Images/l37.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6912729, 27.0772442";
            }
            if (aa == "38")
            {
                Image1.ImageUrl = "~/Images/l38.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6922388, 27.0802788";
            }
            if (aa == "39")
            {
                Image1.ImageUrl = "~/Images/l39.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6972537, 27.0808499";
            }
            if (aa == "40")
            {
                Image1.ImageUrl = "~/Images/l40.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6995606, 27.0826737";
            }
            if (aa == "41")
            {
                Image1.ImageUrl = "~/Images/l41.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.7023184, 27.0784399";
            }
            if (aa == "42")
            {
                Image1.ImageUrl = "~/Images/l42.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.6943014, 27.0729463";
            }
            if (aa == "43")
            {
                Image1.ImageUrl = "~/Images/l43.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.691268, 27.0946332";
            }
            if (aa == "44")
            {
                Image1.ImageUrl = "~/Images/l44.jpg";
                Image1.Visible = true;
                Label12.Text = "-26.691123, 27.0865742";
            }

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Panel7.Visible == false)
            {
                Panel7.Visible = true;
                Panel8.Visible = false;
                TextBox1.Text = email;
            }
            else
            {
                Panel7.Visible = false;
            }

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (Panel8.Visible == false)
            {
                Panel8.Visible = true;
                Panel7.Visible = false;
            }
            else
            {
                Panel8.Visible = false;
            }




        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            
            if (Page.IsValid)
            {
                string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox2.Text.Trim(), "SHA1");

                if (TextBox1.Text != "")
                {
                    string constr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";

                    SqlConnection conn2 = new SqlConnection(constr2);
                    conn2.Open();



                    SqlCommand comm2;
                    SqlDataReader dataReader;
                    String sql2;



                    sql2 = "SELECT * FROM UserTable WHERE username LIKE '%" + Label2.Text + "%'";


                    comm2 = new SqlCommand(sql2, conn2);



                    dataReader = comm2.ExecuteReader();

                    while (dataReader.Read())
                    {
                        email = dataReader.GetValue(0).ToString();
                        hpass = dataReader.GetValue(2).ToString();

                    }



                    dataReader.Close();
                    comm2.Dispose();

                    conn2.Close();
                    if (FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox2.Text.Trim(), "SHA1") == hpass)
                    {



                        string myQuery = "UPDATE UserTable SET userEmail = @userEmail Where username = @username";
                        using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                        {
                            using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                            {
                                cmd.Parameters.Add("@userEmail", SqlDbType.NVarChar, 50);
                                cmd.Parameters["@userEmail"].Value = TextBox1.Text;
                                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50);
                                cmd.Parameters["@username"].Value = Label2.Text;
                                connection.Open();

                                cmd.ExecuteScalar();
                                connection.Close();
                            }


                        }




                        string script = "alert(\"Email updated Successfully!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                    else
                    {
                        string script = "alert(\"Incorrect Password!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                    }
                }
                else
                {
                    TextBox1.Text = "1";
                    RegularExpressionValidator1.Validate();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if(TextBox4.Text == TextBox5.Text)
            {
                if (FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox3.Text.Trim(), "SHA1") == hpass)
                {

                    string myQuery = "UPDATE UserTable SET password = @password Where username = @username";
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                        {
                            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 250);
                            cmd.Parameters["@password"].Value = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox5.Text.Trim(), "SHA1");
                            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50);
                            cmd.Parameters["@username"].Value = Label2.Text;
                            connection.Open();

                            cmd.ExecuteScalar();
                            connection.Close();
                        }


                    }

                    string script = "alert(\"Password updated Successfully!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    string script = "alert(\"Incorrect Password!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            else
            {
                string script = "alert(\"New passwords does not match!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.BorderColor = System.Drawing.Color.Red;
            ImageButton1.BorderStyle = BorderStyle.Dashed;
            ImageButton2.BorderStyle = BorderStyle.None;
            ImageButton3.BorderStyle = BorderStyle.None;

            string constr;

            //The connection string can be found at the database properties
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            if (paym == 0)
            {
                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataAdapter adap = new SqlDataAdapter();
                String sql;

                //Defining the Sql Statement
                sql = "INSERT INTO PayTable(username, payment) VALUES('" + Label2.Text + "',1)";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Assosiate the Insert Command:
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();

                comm.Dispose(); //Stop the command!
                conn.Close();

                string script = "alert(\"Payment Method Updated to: PAYPAL\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {

                string myQuery = "UPDATE PayTable SET payment = @payment Where username = @username";
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                    {
                        cmd.Parameters.Add("@payment", SqlDbType.Int);
                        cmd.Parameters["@payment"].Value = "1";
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                        cmd.Parameters["@username"].Value = Label2.Text;
                        connection.Open();

                        cmd.ExecuteScalar();
                        connection.Close();
                    }


                }

                string script = "alert(\"Payment Method Updated to: PAYPAL\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton2.BorderColor = System.Drawing.Color.Red;
            ImageButton2.BorderStyle = BorderStyle.Dashed;
            ImageButton1.BorderStyle = BorderStyle.None;
            ImageButton3.BorderStyle = BorderStyle.None;

            string constr;

            //The connection string can be found at the database properties
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            if (paym == 0)
            {
                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataAdapter adap = new SqlDataAdapter();
                String sql;

                //Defining the Sql Statement
                sql = "INSERT INTO PayTable(username, payment) VALUES('" + Label2.Text + "',2)";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Assosiate the Insert Command:
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();

                comm.Dispose(); //Stop the command!
                conn.Close();


                string script = "alert(\"Payment Method Updated to: MASTERCARD\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                string myQuery = "UPDATE PayTable SET payment = @payment Where username = @username";
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                    {
                        cmd.Parameters.Add("@payment", SqlDbType.Int);
                        cmd.Parameters["@payment"].Value = "2";
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                        cmd.Parameters["@username"].Value = Label2.Text;
                        connection.Open();

                        cmd.ExecuteScalar();
                        connection.Close();
                    }


                }

                string script = "alert(\"Payment Method Updated to: MASTERCARD\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton3.BorderColor = System.Drawing.Color.Red;
            ImageButton3.BorderStyle = BorderStyle.Dashed;
            ImageButton1.BorderStyle = BorderStyle.None;
            ImageButton2.BorderStyle = BorderStyle.None;

            string constr;

            //The connection string can be found at the database properties
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
            if (paym == 0)
            {
                SqlConnection conn = new SqlConnection(constr); //Assign the connection

                conn.Open(); //Opens the Connection

                //Defining the variables
                SqlCommand comm;
                SqlDataAdapter adap = new SqlDataAdapter();
                String sql;

                //Defining the Sql Statement
                sql = "INSERT INTO PayTable(username, payment) VALUES('" + Label2.Text + "',3)";

                //The Command Statement
                comm = new SqlCommand(sql, conn);

                //Assosiate the Insert Command:
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();

                comm.Dispose(); //Stop the command!
                conn.Close();

                string script = "alert(\"Payment Method Updated to: AMERICAN EXPRESS\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                string myQuery = "UPDATE PayTable SET payment = @payment Where username = @username";
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(myQuery, connection))
                    {
                        cmd.Parameters.Add("@payment", SqlDbType.Int);
                        cmd.Parameters["@payment"].Value = "3";
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                        cmd.Parameters["@username"].Value = Label2.Text;
                        connection.Open();

                        cmd.ExecuteScalar();
                        connection.Close();
                    }


                }

                string script = "alert(\"Payment Method Updated to: AMERICAN EXPRESS\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bookings.aspx");
        }
    }
}
            