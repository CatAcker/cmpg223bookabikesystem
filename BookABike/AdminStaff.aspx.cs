using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace BookABike
{
    public partial class AdminStaff : System.Web.UI.Page
    {
        static string isAdmin;
        static bool isNewAdmin = false;
        static SqlConnection connectDB;
        static SqlCommand commandDB;
        static string constrDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UsersDB.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            isAdmin = Request.QueryString["isAdmin"];
            isAdmin.Trim();
            if(isAdmin == "ADMIN")
            {
                btnAddBike.Visible = false;
                btnAddCl.Visible = false;
                btnRemoveCl.Visible = false;
                btnRemoveBike.Visible = false;
                btnChangeBikeLoc.Visible = false;
            }
        }

        protected void btnAddStaff_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 0;
        }

        protected void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 1;
        }

        protected void btnCalcProfit_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 2;
        }

        protected void btnAddBike_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 3;
        }

        protected void btnRemoveBike_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 4;
        }

        protected void btnChangeBikeLoc_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 5;
        }

        protected void btnAddCl_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 6;
        }

        protected void btnRemoveCl_Click(object sender, EventArgs e)
        {
            multiViewChange.ActiveViewIndex = 7;
        }

        protected void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAdmin.Checked)
            {
                Label1.Visible = false;
                txtNewStStation.Visible = false;
                isNewAdmin = true;
            }
            else
            {
                Label1.Visible = true;
                txtNewStStation.Visible = true;
                isNewAdmin = false;
            }
        }

        protected void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            string pass;
            pass = txtStaffPass.Text;
            int smallLetterCount = 0, capLetterCount = 0;
            bool isSpecialChar = false, passwordCheck = false, isDigitPresent = false;
            //Checks if length is correct
            if (pass.Length >= 8)
            {
                //Checks if password contains capital and small letters
                for (int i = 0; i < pass.Length; i++)
                {
                    if (pass[i] >= 'a' && pass[i] <= 'z')
                    {
                        smallLetterCount++;
                    }
                    if (pass[i] >= 'A' && pass[i] <= 'Z')
                    {
                        capLetterCount++;
                    }
                }
                if (smallLetterCount <= 0)
                {
                    lblPass1.Text = "Your password must contain at least one lowercase letter";
                    txtStaffPass.Text = "";
                    txtStaffPass.Focus();
                }
                else
                {
                    if (capLetterCount <= 0)
                    {
                        lblPass1.Text = "Your password must contain at least one uppercase letter";
                        txtStaffPass.Text = "";
                        txtStaffPass.Focus();                        
                    }
                    else
                    {
                        //Check if password contains numbers
                        isDigitPresent = pass.Any(c => char.IsDigit(c));
                        if (isDigitPresent)
                        {
                            //check is password contains special charecters 
                            isSpecialChar = pass.Any(sChar => !char.IsLetterOrDigit(sChar));
                            if (isSpecialChar)
                            {
                                passwordCheck = true;
                            }
                            else
                            {
                                lblPass1.Text = "The password needs to contain a special charackter.";
                                txtStaffPass.Text = "";
                                txtStaffPass.Focus();
                            }
                        }
                        else
                        {
                            lblPass1.Text = "The password needs to contain a digit.";
                            txtStaffPass.Text = "";
                            txtStaffPass.Focus();
                        }
                    }
                }
            }
            else
            {
                lblPass1.Text = "You need a password of 8 digits";
            }
            
            //if the password is correct
            if (passwordCheck)
            {//Checks if the username already exists
                try
                {                    
                    string passAddNew = txtStaffPass.Text;
                    passAddNew.Trim();
                    //Hasing the password, so that no one but you know the password//////////
                    MD5CryptoServiceProvider sh = new MD5CryptoServiceProvider();
                    UTF32Encoding utf8 = new UTF32Encoding();
                    string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(passAddNew)));
                    /////////////////////////////////////////////////////////////////////////
                    string insert_NewUser = "INSERT INTO Staff VALUES(@Station_Number,@Staff_FirstName,@Staff_LastName,@Weekly_Salary,@Staff_Emial,@Staff_ContactNumber,@Staff_Password,@isAdmin)";
                    connectDB = new SqlConnection(constrDB);
                    connectDB.Open();
                    commandDB = new SqlCommand(insert_NewUser, connectDB);
                    if (isNewAdmin)
                    {
                        commandDB.Parameters.AddWithValue("@Station_Number", 0);
                        commandDB.Parameters.AddWithValue("@isAdmin", "True");
                        chkAdmin.Checked = false;
                        isNewAdmin = false;
                    }
                    else
                    {
                        commandDB.Parameters.AddWithValue("@Station_Number", int.Parse(txtNewStStation.Text));
                        commandDB.Parameters.AddWithValue("@isAdmin", "False");
                        txtNewStStation.Text = "";
                    }
                    commandDB.Parameters.AddWithValue("@Staff_FirstName", txtStaffFN.Text);
                    commandDB.Parameters.AddWithValue("@Staff_LastName", txtStaffLN.Text);
                    commandDB.Parameters.AddWithValue("@Weekly_Salary", int.Parse(txtSalary.Text));
                    commandDB.Parameters.AddWithValue("@Staff_Emial", txtStaffEmail.Text);
                    commandDB.Parameters.AddWithValue("@Staff_ContactNumber", txtStaffConNumber.Text);
                    commandDB.Parameters.AddWithValue("@Staff_Password", hash);
                    commandDB.ExecuteNonQuery();
                    lblPass1.Text = "You have been added as a new user " + txtStaffLN.Text + " " + txtStaffFN.Text + "!";
                    txtStaffFN.Text = "";
                    txtStaffLN.Text = "";
                    txtSalary.Text = "";
                    txtStaffEmail.Text = "";
                    txtStaffConNumber.Text = "";
                    txtStaffPass.Text = "";
                    txtStaffFN.Focus();
                    
                    connectDB.Close();
                }

                catch (Exception err)
                {
                    lblPass1.Text = err.Message;
                }
            }
            //txtPass1.TextMode = TextBoxMode.Password;
            //txtPass2.TextMode = TextBoxMode.Password;
        }
    }
}