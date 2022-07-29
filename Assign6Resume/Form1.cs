using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign6Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resume re = new resume() {

            fullname = textBox1.Text,
            age = Convert.ToInt32(textBox2.Text),
            gender = textBox3.Text,
            contact = textBox4.Text,
            email = textBox5.Text,
            birthdate = textBox6.Text,
            birthplace = textBox7.Text,
            weight = textBox8.Text,
            height = textBox9.Text,
            nationality = textBox10.Text,
            status = textBox11.Text,
            primary = textBox12.Text,
            secondary = textBox13.Text,
            tertiary = textBox14.Text,
            skill1 = textBox15.Text,
            skill2 = textBox16.Text,
            skill3 = textBox17.Text
            };
            string json = JsonConvert.SerializeObject(re, Formatting.Indented);
            File.WriteAllText("C:\\resume.json", json);

        }
        class resume
        {
            public string fullname;
            public int age;
            public string gender;
            public string contact;
            public string email;
            public string birthdate;
            public string birthplace;
            public string weight;
            public string height;
            public string nationality;
            public string status;
            public string primary;
            public string secondary;
            public string tertiary;
            public string skill1;
            public string skill2;
            public string skill3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
            textBox17.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString(textBox5.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString(textBox6.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString(textBox7.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString(textBox8.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString(textBox9.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString(textBox10.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 450));
            e.Graphics.DrawString(textBox11.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 500));
            e.Graphics.DrawString(textBox12.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 550));
            e.Graphics.DrawString(textBox13.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 600));
            e.Graphics.DrawString(textBox14.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 650));
            e.Graphics.DrawString(textBox15.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 700));
            e.Graphics.DrawString(textBox16.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 750));
            e.Graphics.DrawString(textBox17.Text, new Font("Arial", 13), Brushes.Black, new Point(10, 800));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
