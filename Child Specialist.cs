﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Child_Specialist : Form
    {
        SqlConnection con;
        public Child_Specialist()
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

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM ChildSpecialist", con);
            ad.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

         
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
    }
}
