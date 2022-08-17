using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sinhala, history, english, maths, science, total, avg;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_num.Text = "";
            textBox_sinhala.Text = "";
            textBox_history.Text = "";
            textBox_english.Text = "";
            textBox_maths.Text = "";
            textBox_science.Text = "";
            label_sinhala.Text = "";
            label_history.Text = "";
            label_english.Text = "";
            label_maths.Text = "";
            label_science.Text = "";
            label_total.Text = "";
            label_avg.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sinhala = Convert.ToDouble(textBox_sinhala.Text);
            history = Convert.ToDouble(textBox_history.Text);
            english = Convert.ToDouble(textBox_english.Text);
            maths = Convert.ToDouble(textBox_maths.Text);
            science = Convert.ToDouble(textBox_science.Text);
            total = sinhala + history + english + maths + science;
            label_total.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sinhala = Convert.ToDouble(textBox_sinhala.Text);
            history = Convert.ToDouble(textBox_history.Text);
            english = Convert.ToDouble(textBox_english.Text);
            maths = Convert.ToDouble(textBox_maths.Text);
            science = Convert.ToDouble(textBox_science.Text);
            total = sinhala + history + english + maths + science;
            avg = total / 5;
            label_avg.Text = avg.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sinhala_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] subj = new double[5];
            subj[0] = Convert.ToDouble(textBox_sinhala.Text);
            subj[1] = Convert.ToDouble(textBox_history.Text);
            subj[2] = Convert.ToDouble(textBox_english.Text);
            subj[3] = Convert.ToDouble(textBox_maths.Text);
            subj[4] = Convert.ToDouble(textBox_science.Text);
            String[] grade = new String[5];

            for (int i = 0; i < grade.Length; i++)
            {
                if (subj[i] >= 75)
                {
                    grade[i] = "A";
                }
                else if (subj[i] >= 65)
                {
                    grade[i] = "B";
                }
                else if (subj[i] >= 55)
                {
                    grade[i] = "C";
                }
                else if (subj[i] >= 35)
                {
                    grade[i] = "S";
                }
                else
                {
                    grade[i] = "F";
                }
            }
            label_sinhala.Text = grade[0];
            label_history.Text = grade[1];
            label_english.Text = grade[2];
            label_maths.Text = grade[3];
            label_science.Text = grade[4];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + textBox_name.Text + ", Student No: " +
                  textBox_num.Text + ", Total: " + label_total.Text + ", Average: " + label_avg.Text +
                  ".", "Student Results Report!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
