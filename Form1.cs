using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form1 : Form
    {
        private double answer;
        private float weightOnEarth;
        private float weightOnMars;

        public Form1()
        {
            answer = 0;
            weightOnEarth = 0;
            weightOnMars = 0;

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool checkNumber()
        {
            Boolean condition = true;
            int temp = 0;
            bool res1 = int.TryParse(textBox1.Text, out temp);
            bool res2 = int.TryParse(textBox2.Text, out temp);

            if (res1 == false && res2 == false)
            {
                condition = false;
            }
            return condition;
        }
        private void activate()
        {
            
            String[] array = new string[1];

            try
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && checkNumber())
                {
                    //condition statement checking the length of textBox1 , textBox2,  and number type.
                    s1 obj = new s1(textBox1.Text, textBox1.Text);
                    if (textBox1.Text.Length > 2 && textBox2.Text.Length > 2)
                    {
                        if (obj.calcuate() != 0)
                        {

                            double result = obj.calcuate();
                            int a = (int)Math.Round(result,3);
                            array[0] = a.ToString();
                            label5.Text = "good job ";
                            label7.Text = "";
                            label7.Text = array[0];
                            //MessageBox.Show("-->" + a);
                            array[0] = "";
                        }
                        listView1.ResetText();


                    }
                    else
                    {
                        Console.WriteLine("There is a  problem");
                        label5.Text = "";
                        label7.Text = "";
                        label5.Text = "Please check your weights and  try  again";
                        //MessageBox.Show("Please enter a  number  greater  than 0 here");
                    }
                }
                else
                {
                    //MessageBox.Show("That  is not  a number");
                    label5.Text = "";
                    label5.Text = "That is not  a number";
                    //Console.WriteLine("The programe prefers  a number");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Exception caught "+ e);
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            activate();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Login");
        }
    }
}
