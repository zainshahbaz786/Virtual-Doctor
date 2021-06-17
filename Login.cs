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
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
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

        private void sign_up_Click(object sender, EventArgs e)
        {

            this.Hide();
            Sign_up s = new Sign_up();
            s.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
                string username = login_username.Text;
                string password = login_password.Text;
                if (username != string.Empty || password != string.Empty)
                {
                    SqlCommand cmd = new SqlCommand("select * from Users where User_Name ='" + username + "' and password = '" + password + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        menu m = new menu();
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
