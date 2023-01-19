using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpa_calculator
{
    public partial class Form1 : Form
    {
        Decimal m1, m2, m3, m4, m5, m6,gpa,uppertotal,lowertotal;
        Decimal credit1, credit2, credit3, credit4, credit5, credit6;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(marks1.Text!="")
            {
                m1 = Convert.ToDecimal(marks1.Text);
                if(m1>100||m1<0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
                
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 1");
            }
            if (marks2.Text != "")
            {
                 m2 = Convert.ToDecimal(marks2.Text);
                if (m2 > 100 || m2 < 0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 2");
            }
            if (marks3.Text != "")
            {
                 m3 = Convert.ToDecimal(marks3.Text);
                if (m3 > 100 || m3 < 0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 3");
            }
            if (marks4.Text != "")
            {
                 m4 = Convert.ToDecimal(marks4.Text);
                if (m4 > 100 || m4 < 0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 4");
            }
            if (marks5.Text != "")
            {
                 m5 = Convert.ToDecimal(marks5.Text);
                if (m5 > 100 || m5 < 0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 5");
            }
            if (marks6.Text != "")
            {
                 m6 = Convert.ToDecimal(marks6.Text);
                if (m6 > 100 || m6 < 0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
            }
            else
            {
                MessageBox.Show("YOU DO NOT FILL THE BOX 6");
            }
            //grading section
         Decimal mark1  =Gpa(m1);
         Decimal mark2 =Gpa(m2);
         Decimal mark3 =Gpa(m3);  
         Decimal mark4 =Gpa(m4);
         Decimal mark5 =Gpa(m5);
         Decimal mark6 =Gpa(m6);
            //MessageBox.Show(Convert.ToString(mark1));
            // MessageBox.Show(Convert.ToString(mark2));
            //MessageBox.Show(Convert.ToString(mark3));
            //MessageBox.Show(Convert.ToString(mark4));
            //MessageBox.Show(Convert.ToString(mark5));
            // MessageBox.Show(Convert.ToString(mark6));
         credit1 = Convert.ToDecimal(comboBox1.Text);
         credit2 = Convert.ToDecimal(comboBox2.Text);
         credit3 = Convert.ToDecimal(comboBox3.Text);
         credit4 = Convert.ToDecimal(comboBox4.Text);
         credit5 = Convert.ToDecimal(comboBox5.Text);
         credit6 = Convert.ToDecimal(comboBox6.Text);
            
            if (checkBox1.Checked) 
            {
                credit1 = 0.0m;
            }
            if (checkBox2.Checked ) 
            {
                credit2 = 0.0m;
            }
            if (checkBox3.Checked ) 
            {
                credit3 = 0.0m; 
            }
            if (checkBox4.Checked ) 
            {
                credit4 = 0.0m;
            }
            if (checkBox5.Checked ) 
            {
                credit5 = 0.0m;
            }
            if (checkBox6.Checked )
            {
                credit6 = 0.0m;
            }
            //MessageBox.Show(Convert.ToString(credit1));
            //MessageBox.Show(Convert.ToString(credit2));
            // MessageBox.Show(Convert.ToString(credit3));
            // MessageBox.Show(Convert.ToString(credit4));
            // MessageBox.Show(Convert.ToString(credit5));
            // MessageBox.Show(Convert.ToString(credit6));
            uppertotal = (mark1 * credit1) + (mark2 * credit2) + (mark3 * credit3) + (mark4 * credit4) + (mark5 * credit5) + (mark6 * credit6) ;
            lowertotal = credit1 + credit2 + credit3 + credit4 + credit5 + credit6;
            gpa = uppertotal / lowertotal;
            // gpa = (Decimal)System.Math.Round(gpa);
            //MessageBox.Show(Convert.ToString(gpa));
            //MessageBox.Show(String.Format("{0:0.00}", gpa));
            result1.Text= (String.Format("{0:0.00}", gpa));

            if (textBox4.Text == "" || textBox4.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 4");
            }
            if (textBox1.Text == "" || textBox1.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 1");
            }
            if (textBox2.Text == "" || textBox2.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 2");
            }
            if (textBox3.Text == "" || textBox3.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 3");
            }
            if (textBox6.Text == "" || textBox6.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 6");
            }
            if (textBox5.Text == "" || textBox5.Text == "ENTER YOUR COURSE")
            {
                MessageBox.Show("Please Enter Course Name In Box Number 5");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void marks1_TextChanged(object sender, EventArgs e)
        {

        }
        private Decimal Gpa(Decimal num1)
        {
            //MessageBox.Show(Convert.ToString(num1));
            Decimal num2 = 0.0m;
            if(num1<=100 && num1>=80)
            {
                num2 = 4.0m;
                //return num2;
            }
            if (num1 <= 79 && num1 >= 70)
            {

                num2 = 3.0m;
                //return num2;
            }
            if (num1 <= 69 && num1 >= 60)
            {

                num2 = 2.0m;
                //return num2;
            }
            if (num1 <= 59 && num1 >= 50)
            {

                num2 = 1.0m;
                //return num2;
            }
            if (num1 <50)
            {
                num2 = 0.0m;
                //return num2;
            }
            //MessageBox.Show(Convert.ToString(num2));
            return num2;
        }
    }
}
