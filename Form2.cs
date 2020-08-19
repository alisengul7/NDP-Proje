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
    public partial class Form2 : Form
    {

        Form3 frm3 = new Form3();//hakkında formuna geçiş için tanımladığım değişken
        int fyt, pesinat, toplam, taksit, adet, tutar, i, a, stok;//değişkenler

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;//satın al butonunu form yüklenirken pasif ettim
            a = 10;//a değişkenine stok sayısı olarak 10 unu atadım

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bilgisayar")//Combobox1 içindeki text Bilgisayarsa
            {
                comboBox2.Items.Clear();//combobox2  içeriğini temizle
                comboBox2.Items.Add("Vestel");//combobox2 nin içini vestel,acer,exper yap
                comboBox2.Items.Add("Acer");//combobox2 nin içini vestel,acer,exper yap
                comboBox2.Items.Add("Exper");//combobox2 nin içini vestel,acer,exper yap
            }

            if (comboBox1.Text == "Cep Telefonu")//Combobox1 içindeki text cep telefonuysa
            {
                comboBox2.Items.Clear();//combobox2  içeriğini temizle
                comboBox2.Items.Add("Nokia");//combobox2 nin içini nokia,samsung,lg yap
                comboBox2.Items.Add("Samsung");//combobox2 nin içini nokia,samsung,lg yap
                comboBox2.Items.Add("LG");//combobox2 nin içini nokia,samsung,lg yap
            }

            if (comboBox1.Text == "Kamera")//Combobox1 içindeki text kameraysa
            {
                comboBox2.Items.Clear();//combobox2  içeriğini temizle
                comboBox2.Items.Add("JVJ");//combobox2 nin içini jvj,sony,panasonic yap
                comboBox2.Items.Add("Sony");//combobox2 nin içini jvj,sony,panasonic yap
                comboBox2.Items.Add("Panasonic");//combobox2 nin içini jvj,sony,panasonic yap
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Vestel")//combobox2 nin içindeki text Vestelse
                textBox1.Text = "1250 ";//textbox1 in içini 1250 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "Acer")//combobox2 nin içindeki text Acerse
                textBox1.Text = "1550 ";//textbox1 in içini 1550 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "Exper")//combobox2 nin içindeki text Experse
                textBox1.Text = "1445 ";//textbox1 in içini 1445 tl yap
            label13.Text = "10";//stok sayısı

            if (comboBox2.Text == "Nokia")//combobox2 nin içindeki text Nokiasa
                textBox1.Text = "750 ";//textbox1 in içini 750 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "Samsung")//combobox2 nin içindeki text Samsungsa
                textBox1.Text = "600 ";//textbox1 in içini 600 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "LG")//combobox2 nin içindeki text lgse 
                textBox1.Text = "500 ";//textbox1 in içini 500 tl yap
            label13.Text = "10";//stok sayısı

            if (comboBox2.Text == "JVJ")//combobox2 nin içindeki text jvjse
                textBox1.Text = "1000 ";//textbox1 in içini 1000 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "Sony")//combobox2 nin içindeki text sonyse
                textBox1.Text = "1200 ";//textbox1 in içini 1200 tl yap
            label13.Text = "10";//stok sayısı
            if (comboBox2.Text == "Panasonic")//combobox2 nin içindeki text panasonicse
                textBox1.Text = "1110 ";//textbox1 in içini 1110 tl yap
            label13.Text = "10";//stok sayısı

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try// doğru işlem yapıldıysa aşağıdaki kodları çalıştır
            {

                fyt = int.Parse(textBox1.Text);//fyt değişkenini textbox1 e sayısal olarak atadım
                pesinat = int.Parse(textBox2.Text);//pesinat değişkenini textbox2 ye sayısal olarak atadım
                adet = int.Parse(textBox3.Text);//adet değişkenini textbox3 e sayısal olarak atadım
                taksit = int.Parse(comboBox3.Text);//taksit değişkenini combobox3 e sayısal olarak atadım

                if (taksit > 0)// taksit 0 dan büyükse yani taksit varsa aşağıdaki işlemler yapılsın
                {

                    toplam = (fyt + (fyt * adet - pesinat) * taksit * 2 / 100);//fiyat işlemleri %2 kdv dahil
                    textBox5.Text = toplam.ToString("C");//sonucu textbox5 te gösterdim.
                    tutar = ((toplam - pesinat) / taksit);//fiyat işlemleri 
                    textBox4.Text = tutar.ToString("C");//sonucu textbox4 te gösterdim.
                }
                else if (taksit == 0)//taksit 0 dan büyük değilse yani taksit yoksa aşağıdaki işlemler yapılsın dedim.
                {



                    toplam = (fyt + (fyt * adet - pesinat) * 2 / 100);//Peşin fiyat işlemleri %2 kdv dahil
                    textBox5.Text = toplam.ToString("C");//sonucu textbox5 te gösterdim
                    tutar = ((toplam - pesinat));//Peşin fiyat işlemleri
                    textBox4.Text = tutar.ToString("C");//sonucu textbox4 da gösterdim.
                }

            }

            catch// doğru işlem yapılmadıysa  aşağıdaki mesajı ver dedim
            {

                MessageBox.Show(" Alanlara Sayısal Veriler Girilebilir veya Alanlar Boş Bırakılamaz");

                // Kullanıcı textleri boş geçtiğinde veya textlerin için metin girdiklerinde ekrana mesaj versin dedim

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();//programdan çıksın dedim.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")//combobox1 in içeriği boş ise
                MessageBox.Show("Lütfen Bir Ürün Seçiniz");// mesajını ver
            else if (comboBox2.Text == "")//combobox1 in içi dolu olup combobox2 nin içi boş ise 
                MessageBox.Show("Lütfen Bir Ürün Adı Seçiniz");//mesajını ver
            else if (textBox3.Text == "")//textbox3 boş ise
                MessageBox.Show("Lütfen Alacağınız Ürün Adedini Yazınız");//mesajını ver
            else if (textBox4.Text == "" && textBox5.Text == "")//textbox3 dolu olup textbox4 ve textbox5 boş ise
                MessageBox.Show("Lütfen  Hesapla Butonuna Basarak Aldığınız Ürünlerin Fiyatını Hesaplayınız");//mesajını ver
            else//yukarıdakilerden hiçbiri değilse 
                i++;//i değişkenini 1 arttır
            label11.Text = i.ToString();//i değişkenini label11 de göster
            button2.Enabled = true;//satın al butonunu aktif et
            // textBox2.Text = "";//yeni ürünleri satmak için textboxların içini boşalt
            textBox2.Text = "";//yeni ürünleri satmak için textboxların içini boşalt
            textBox3.Text = "";//yeni ürünleri satmak için textboxların içini boşalt
            textBox4.Text = "";//yeni ürünleri satmak için textboxların içini boşalt
            textBox5.Text = "";//yeni ürünleri satmak için textboxların içini boşalt

        }

        private void button2_Click(object sender, EventArgs e)
        {



            if (label13.Text == "0")// stok sayısı sıfırsa  aşağıdaki mesajı ver ve formu kapat dedim.
            {
                MessageBox.Show("Bu Ürün Stoklarda Bulunmamaktadır..Lütfen Başka Bir Ürün Seçiniz");
                this.Close();
            }
            else// değilse


                stok = a - int.Parse(label11.Text);//stok değişkenini  label11 e sayısal olarak atadım ve a değişkeninden label11 i çıkardım

            label13.Text = stok.ToString(); //a değişkenini label15 e atadım ..
            button2.Enabled = false;//satın al butonunu pasif et dedim

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm3.Show();//hakkında formuna git
        }
    }
}
