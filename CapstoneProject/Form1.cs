using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            //********************************
            // Application: Matrix Multiplier
            // Designer: Cheung Connor
            // Date: 4/27/19
            //********************************
            bool moveFoward = true;
            double result;

            if (!double.TryParse(textBox1.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox2.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox3.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox4.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox5.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox6.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox7.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox8.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(textBox9.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(txt_Matrix21.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(txt_Matrix22.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }
            if (!double.TryParse(txt_Matrix23.Text, out result))
            {
                txt_Error.Text = "ERROR => MUST ENTER NUMBERS";
                txt_Error.ForeColor = Color.Red;
                moveFoward = false;
            }


            if (moveFoward == true)
            {
                txt_Error.Text = " ";
                double Box1 = double.Parse(textBox1.Text);
                double Box4 = double.Parse(textBox4.Text);
                double Box7 = double.Parse(textBox7.Text);
                double Box2 = double.Parse(textBox2.Text);
                double Box5 = double.Parse(textBox5.Text);
                double Box8 = double.Parse(textBox8.Text);
                double Box3 = double.Parse(textBox3.Text);
                double Box6 = double.Parse(textBox6.Text);
                double Box9 = double.Parse(textBox9.Text);
                double matrix21 = double.Parse(txt_Matrix21.Text);
                double matrix22 = double.Parse(txt_Matrix22.Text);
                double matrix23 = double.Parse(txt_Matrix23.Text);


                double answer1 = Box1 * matrix21;
                txt_Answer1.Text = answer1.ToString();

                double answer2 = Box2 * matrix22;
                txt_Answer2.Text = answer2.ToString();

                double answer3 = Box3 * matrix23;
                txt_Answer3.Text = answer3.ToString();

                double answer4 = Box4 * matrix21;
                txt_Answer4.Text = answer4.ToString();

                double answer5 = Box5 * matrix22;
                txt_Answer5.Text = answer5.ToString();

                double answer6 = Box6 * matrix23;
                txt_Answer6.Text = answer6.ToString();

                double answer7 = Box7 * matrix21;
                txt_Answer7.Text = answer7.ToString();

                double answer8 = Box8 * matrix22;
                txt_Answer8.Text = answer8.ToString();

                double answer9 = Box9 * matrix23;
                txt_Answer9.Text = answer9.ToString();
            }








        }
    }
}
