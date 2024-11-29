using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//DOSYALAMA İŞLEMLERİNDE KULLANILIYOR
namespace _2024._10._07
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //SEÇİLENİ EKLE
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("BİR DERS ADI SEÇİNİZ!!!");
                return;
            }
            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);
        }
        int i;//TÜMÜNÜ EKLE
        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < listBox1.Items.Count;i++ )
            {
                listBox2.Items.Add(listBox1.Items [i]);
            }
            listBox1.Items.Clear();
        }
        DialogResult soru;
        private void button3_Click(object sender, EventArgs e)
        {
            soru = MessageBox.Show("BİLGİLER KAYIT YAPILSIN MI", "KAYIT İŞLEMİ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                StreamWriter kaydet = new StreamWriter("bilgiler.txt",true);
                //TRUE YAZMAZSAK DOSYAYI BULAMADIĞI İÇİN HATA VERECEK TRUE YAZINCA DOSYAYI OLUŞTURUP DOSYADA KAYDETMEYE BAŞLIYACAK
                kaydet.WriteLine(DateTime.Now+" TARİHLİ BİLGİLER");
                kaydet.WriteLine("--------------------------------------------");
                foreach (string veriler in listBox2.Items)
                {
                    kaydet.WriteLine(veriler);
                }

                kaydet.WriteLine("--------------------------------------------");
                kaydet.Close();
                MessageBox.Show("BİLGİLER KAYDEDİLDİ!!!!");

            }
        }
    }
}
