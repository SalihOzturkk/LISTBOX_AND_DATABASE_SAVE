﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i; double toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            toplam = 0;
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);

            }
            label1.Text = "TOPLAM  :" + toplam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            toplam = 0;
            foreach (string top in listBox1.Items)
            {

                toplam += Convert.ToDouble(top);
            }
            label1.Text = "TOPLAM  :" + toplam;
        }
    }
}
