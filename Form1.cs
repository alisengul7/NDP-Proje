using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokVeSatışProgramı
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2(); // satış formuna geçiş için değişken tanımladım..

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;// bilgi metnini form yüklenirken gizledim
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text.Length > 10) && (textBox1.Text.Length < 12))//tc kimlik no girilmezse,fazla yada eksik girilse
            {

                frm2.Show();//eğer  kullanıcı doğru giriş yaptıysa form2 ye geçsin dedim..
                this.Hide();//form1 i gizle
                frm2.label12.Text = textBox1.Text.ToString() + ("    T.C Kimlik Numarası ile Giriş Yaptınız"); ;//tc kimlik no form2 deki labelde gözüksün dedim 
            }
            else
                MessageBox.Show("T.C Kimlik No Boş veya 11 Haneden Küçük yada Büyük Olamaz");//mesajını verdirdim..


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//programdan çıksın dedim
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox2.Visible = true;//form yüklenirken gizlediğim text2 yi görünür hale getirdim.

        }
    }
}
