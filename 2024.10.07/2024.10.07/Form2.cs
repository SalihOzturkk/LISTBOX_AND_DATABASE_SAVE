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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int gun =(int) DateTime.Now.DayOfWeek;
            //haftadan gün çekme methodu
            int gun = Convert.ToInt32(textBox1.Text);
            switch (gun)
            {
                case 1: { MessageBox.Show("PAZARTESİ"); break; }
                case 2: { MessageBox.Show("SALI"); break; }
                case 3: { MessageBox.Show("ÇARŞAMBA"); break; }
                case 4: { MessageBox.Show("PERŞEMBE"); break; }
                case 5: { MessageBox.Show("CUMA"); break; }
                case 6: { MessageBox.Show("CUMARTESİ"); break; }
                case 7: { MessageBox.Show("PAZAR"); break; }
                default: { MessageBox.Show("GEÇERLİ BİR DEĞER GİRİNİZ!!!"); break; }




            }
 
        }
    }
}
