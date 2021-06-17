using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { 
                panel2.Width += 2; 
                if(panel2.Width==600)
                {
                    
                    
                    timer1.Stop();
                    Sign_up s = new Sign_up();
                    Form1 f1 = new Form1();
                    f1.Close();
                    //form1  is  not closing 
                    s.Show();
                    
               
                
                }
            
            }
            catch(Exception)
            { return; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
