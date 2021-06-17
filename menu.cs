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

namespace Project_1
{
    public partial class menu : Form 
    {
        SqlConnection con;
        public menu(string g)
        {
            InitializeComponent();
            mesgBox(g);
        }
        public menu()
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
        public string symp;
        public string get_symp()
        {
            return symp;
        }

        private void menu_Load(object sender, EventArgs e)
        {
           
        }

        private void psycoButton_Click(object sender, EventArgs e)
        {
            Phsycologists p = new Phsycologists();
            p.Show();
            this.Close();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             symp = symp1.SelectedText;



        }
        public void mesgBox(string l)
        {
            MessageBox.Show(l);
        }

        private void search_Click(object sender, EventArgs e)
        {

            string sm1=symp1.Text;
            string sm2=symp2.Text;
            string sm3 = symp3.Text;
            predictionClass x = new predictionClass();
            


            inputModel obj2 = new inputModel();
            obj2.loss_of_appetite = 1;
          
            String.Format(obj2+"." + sm1);
            //obj2.
            predictionClass p = new predictionClass();
            p.illness(obj2);
            MessageBox.Show(p.Predict);


        }

        private void physioButton_Click(object sender, EventArgs e)
        {
            physiotherapist ph = new physiotherapist();
            ph.Show();
            this.Close();

        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            Heart_Specialist h = new Heart_Specialist();
            h.Show();
            this.Close();
        }
    }
}
