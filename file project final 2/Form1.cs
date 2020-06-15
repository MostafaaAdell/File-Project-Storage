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
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            ds.Tables.Clear();
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter= " XML Document|*.xml";
            
            
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   
                    MessageBox.Show("succesfully added");
                    textBox1.Text = fd.FileName;
                    addcolumetextBox.Text = fd.SafeFileName;
                    XmlReader xmlfile = XmlReader.Create(fd.FileName, new XmlReaderSettings());
                    ds.ReadXml(xmlfile);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    
                }
                else
                {
                    MessageBox.Show("please try again");
                }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Document|*.xml";
            if (dataGridView1.FirstDisplayedCell != null)
            {
                while (true)
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        MessageBox.Show("succesfully saved");
                        ds.Tables[0].WriteXml(sfd.FileName);

                        break;
                    }
                    else
                    {
                        MessageBox.Show("please try again");
                    }
                }
            }
            else
            {
                MessageBox.Show("choose first ,then save");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.FirstDisplayedCell != null)
                {

                    if (textBox2.Text == "" || Convert.ToInt32(textBox2.Text) > ds.Tables[0].Rows.Count)
                    {
                        MessageBox.Show("please fill or write an exist row index");
                    }
                    else
                    {
                        ds.Tables[0].Rows.RemoveAt(Convert.ToInt32(textBox2.Text) - 1);
                    }
                }





                else
                {
                    MessageBox.Show("plese wait until you choose an xml file");
                }
            }
            catch
            {
                MessageBox.Show("please write an exist row");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.FirstDisplayedCell!=null)
            {
                ds.Tables[0].Rows.Add();
               
            }
            else
            {
                MessageBox.Show("plese wait until you choose an xml file");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to clear all data?","cleae data",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                dataGridView1.DataSource = "";
                ds.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                addcolumetextBox.Text = "";
                numtextBox.Text = "";
            }
            else {}
        }

        private void columbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void chosecolumetextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conditiontextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dataGridView1.FirstDisplayedCell!=null)
            {
                if (conditonscomboBox.Text == "=")
                {
                    try
                    {
                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;
                        if (numtextBox.Text != "")
                        {
                            for (int i = 0; i < cont; i++)
                            {
                                if (ds.Tables[0].Rows[i][colindex].ToString() == numtextBox.Text)
                                {

                                }
                                else
                                {
                                    dataGridView1.Rows.RemoveAt(i);
                                    cont--;
                                    i--;

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter your number first");
                            conditonscomboBox.SelectedText = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }

                if (conditonscomboBox.Text == "sum")
                {
                    try
                    {
                        if (numtextBox.Text != "")
                        {
                            try
                            {
                                int colindex = dataGridView1.CurrentCell.ColumnIndex;
                                int rowindex = dataGridView1.CurrentCell.RowIndex;
                                ds.Tables[0].Rows[rowindex][colindex] = Convert.ToInt32(ds.Tables[0].Rows[rowindex][colindex]) + Convert.ToInt32(numtextBox.Text);
                            }
                            catch
                            {
                                MessageBox.Show("can not sum strings");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter the your number first");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }

                if (conditonscomboBox.Text == ">")
                {
                    try
                    {

                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;
                        if (numtextBox.Text != "")
                        {
                            try {
                                for (int i = 0; i < cont; i++)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[i][colindex]) > Convert.ToInt32(numtextBox.Text))
                                    {

                                    }
                                    else
                                    {
                                        dataGridView1.Rows.RemoveAt(i);
                                        cont--;
                                        i--;

                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("can not compare between strings");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter your number first");
                            conditonscomboBox.SelectedText = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }


                if (conditonscomboBox.Text == "average")
                {
                    try
                    {
                        int average = 0;
                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;

                        try {
                            for (int i = 0; i < cont; i++)
                            {
                                average += Convert.ToInt32(ds.Tables[0].Rows[i][colindex]);

                            }
                            average /= (dataGridView1.RowCount) - 1;
                            MessageBox.Show(average.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("can not get averege of colume of strings");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }

                if (conditonscomboBox.Text == "sum colume")
                {
                    try
                    {
                        int sum = 0;
                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;

                        try {
                            for (int i = 0; i < cont; i++)
                            {
                                sum += Convert.ToInt32(ds.Tables[0].Rows[i][colindex]);

                            }


                            MessageBox.Show(sum.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("can not sum colume of string");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }

                    if (conditonscomboBox.Text == "<")
                {
                    try {
                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;
                        if (numtextBox.Text != "")
                        {
                            try
                            {
                                for (int i = 0; i < cont; i++)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[i][colindex]) < Convert.ToInt32(numtextBox.Text))
                                    {

                                    }
                                    else
                                    {
                                        dataGridView1.Rows.RemoveAt(i);
                                        cont--;
                                        i--;

                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("can not compare between strings");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter your number first");
                            conditonscomboBox.SelectedText = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }

                if (conditonscomboBox.Text == "!=")
                {
                    try
                    {
                        int colindex = dataGridView1.CurrentCell.ColumnIndex;
                        int cont = (dataGridView1.RowCount) - 1;
                        if (numtextBox.Text != "")
                        {
                            for (int i = 0; i < cont; i++)
                            {
                                if (ds.Tables[0].Rows[i][colindex].ToString() != numtextBox.Text)
                                {

                                }
                                else
                                {
                                    dataGridView1.Rows.RemoveAt(i);
                                    cont--;
                                    i--;

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter your number first");
                            conditonscomboBox.SelectedText = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("the table is empty");
                    }
                }
                if (conditonscomboBox.Text == "and")
                {


                }

                if (conditonscomboBox.Text == "or")
                {
                    equalForm eq = new equalForm();
                    eq.Show();

                }

            }
            else
            {
                MessageBox.Show("please choose your xml file first");
                conditonscomboBox.SelectedText = "";
            }
        }

        private void numtextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.FirstDisplayedCell != null)
            {
                ds.Tables.Clear();
                ds.ReadXml(textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else
            {
                MessageBox.Show("please choose your xml file first");
            }            
        }

        private void addcolumbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.FirstDisplayedCell != null)
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("please enter your colume name first");
                }
                else
                {
                    
                    ds.Tables[0].Columns.Add(textBox5.Text);
                    textBox5.Text = "";
                }
            }
            else
            {
                MessageBox.Show("plese wait until you choose an xml file");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.FirstDisplayedCell != null)
            {
                try
                {
                    if (deletcolmtextBox.Text == "" || Convert.ToInt32(deletcolmtextBox.Text) > ds.Tables[0].Columns.Count)
                    {
                        MessageBox.Show("please fill or write an exist colume index");
                    }
                    else
                    {
                        ds.Tables[0].Columns.RemoveAt(Convert.ToInt32(deletcolmtextBox.Text)-1);
                        deletcolmtextBox.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("please enter an exist colume index");
                }

            }
            else
            {
                MessageBox.Show("plese wait until you choose an xml file");
            }
        }
    }
}
