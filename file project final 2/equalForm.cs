using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace file_project_final_2
{
    public partial class equalForm : Form
    {
        
        public equalForm( )
        {
            
            InitializeComponent();
        }

        private void finishbutton_Click(object sender, EventArgs e)
        {
            
            if(columetextBox.Text!=""&&textBox2.Text!=""&&textBox1.Text!=""&&inputnumtextBox.Text!="")
            {
                try
                {
                    int num1 = Convert.ToInt32(inputnumtextBox.Text);
                    int num2 = Convert.ToInt32(textBox1.Text);
                    if (columetextBox.Text == ">")
                    {
                       
                       
                    }
                    if (columetextBox.Text == "<")
                    {

                    }
                    if (columetextBox.Text == "=")
                    {

                    }
                    if (columetextBox.Text == "!=")
                    {

                    }
                    if (textBox2.Text == ">")
                    {

                    }
                    if (textBox2.Text == "<")
                    {

                    }
                    if (textBox2.Text == "=")
                    {

                    }
                    if (textBox2.Text == "!=")
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("please input the right data");
                }
               
            }
            else
            {
                MessageBox.Show("please write input your data");
                    
            }

        }

        private void inputnumtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
