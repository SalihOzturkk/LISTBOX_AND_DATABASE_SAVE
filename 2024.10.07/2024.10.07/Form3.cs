using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._10._07
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i;
        private void Form3_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i * 10);
                comboBox1.Items.Add(i * 10);
            }
        }
        string ad,ders;
        double vize, final, ortalama;
        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            ders = comboBox3.Text; 
            vize = Convert.ToDouble(comboBox1.Text);
            final = Convert.ToDouble(comboBox2.Text);
            ortalama = vize * 0.40 + final * 0.60;
            ortalama = Math.Round(ortalama, 1);
            listBox1.Items.Add(ad +" "+ders+ " " + ortalama);

        }
    }
}
