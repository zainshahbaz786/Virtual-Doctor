using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_1
{
    public partial class Sign_up : Form
    {
        SqlConnection con;
        private static Regex Email_Address()
        {
            string Email_Pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for string only validation
        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for numbers only validation
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for validating password
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }
        public Sign_up()
        {
            InitializeComponent();
            string conString = Properties.Settings.Default.conectionstring;
            con = new SqlConnection(conString);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed", ex.Message);
            }
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            fname_error.Visible = false;
            lname_error.Visible = false;
            email_error.Visible = false;
            username_error.Visible = false;
            phone_error.Visible = false;
            password_error.Visible = false;
            cpassword_error.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = f_name.Text + " " + l_name.Text;
            string email = e_mail.Text;
            string username = user_name.Text;
            string password = pass.Text;
            string phone = phone_no.Text;
            string gender = (male.Checked) ? "Male" : "Female";
            string dateofbirth = dob.Text;
            string confirm = confirm_pass.Text;



            if (confirm != string.Empty && password != string.Empty && username != string.Empty && name != string.Empty && email != string.Empty && phone != string.Empty && gender != string.Empty && dateofbirth != string.Empty)
            {
                //for Firstname
                if (StringOnly().IsMatch(f_name.Text) != true)
                {
                    fname_error.Text = "First Name accepts Alphabets only!";
                    fname_error.Visible = true;
                    return;
                }


                //for Lastname
                if (StringOnly().IsMatch(l_name.Text) != true)
                {
                    lname_error.Text = "Last Name accepts Alphabets only!";
                    lname_error.Visible = true;
                    return;
                }


                //for Email Address
                if (Email_Address().IsMatch(email) != true)
                {
                    email_error.Text = "Invalid Email!";
                    email_error.Visible = true;
                    return;
                }


                //for username
                if (username == "")
                {
                    username_error.Text = "User Name can't be empty!";
                    username_error.Visible = true;
                    return;
                }


                //for Contacts  
                if (NumbersOnly().IsMatch(phone) != true)
                {
                    phone_error.Text = "Phone No accepts numbers only!";
                    phone_error.Visible = true;
                    return;
                }

                //for password
                if (ValidPassword().IsMatch(password) != true)
                {
                    password_error.Text = " Password must be 8-15 characters long" + Environment.NewLine + "It contains atleast one Upper case and numbers.";
                    password_error.Visible = true;
                    return;
                }

                else
                {
                    if (confirm == password)
                    {

                        string query = String.Format("Insert into Users (Name, Email, Password, Phone_no, Gender, Date_of_Birth, User_Name)" + "VALUES ('{0}','{1}','{2}','{3}', '{4}', '{5}', '{6}')", name, email, password, phone, gender, dateofbirth, username);
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, con))
                            {

                                command.ExecuteNonQuery();

                                MessageBox.Show("Your Account has been created Successfully! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        cpassword_error.Text = "Passwords doesn't match!";
                        cpassword_error.Visible = true;
                    }
                }

            }
            else
            {
                if (f_name.Text == "")
                {
                    fname_error.Text = "First Name can't be empty!";
                    fname_error.Visible = true;

                }
                else if (f_name.Text != "")
                {
                    fname_error.Visible = false;

                }

                if (l_name.Text == "")
                {
                    lname_error.Text = "Last Name can't be empty!";
                    lname_error.Visible = true;
                }
                else if (l_name.Text != "")
                {
                    lname_error.Visible = false;
                }

                if (email == "")
                {
                    email_error.Text = "Email can't be empty!";
                    email_error.Visible = true;
                }
                else if (email != "")
                {
                    email_error.Visible = false;
                }

                if (username == "")
                {
                    username_error.Text = "User Name can't be empty!";
                    username_error.Visible = true;
                }
                else if (username != "")
                {
                    username_error.Visible = false;
                }

                if (phone == "")
                {
                    phone_error.Text = "Phone No can't be empty!";
                    phone_error.Visible = true;
                }
                else if (phone != "")
                {
                    phone_error.Visible = false;
                }

                if (password == "")
                {
                    password_error.Text = "Password can't be empty!";
                    password_error.Visible = true;
                }
                else if (password != "")
                {
                    password_error.Visible = false;
                }

                if (confirm == "")
                {
                    cpassword_error.Text = "Confirm your password!";
                    cpassword_error.Visible = true;
                }
                if (confirm != "")
                {
                    cpassword_error.Text = "Confirm your password!";
                    cpassword_error.Visible = false;
                }




            }
        }

        private void email_error_Click(object sender, EventArgs e)
        {

        }

        private void lname_error_Click(object sender, EventArgs e)
        {

        }
    }
}
