using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitapOkuma
{


    public partial class Form2 : Form
    {
        public interface ekle   //Arayüz oluşturulur...
        {
            void ekle(string text1, string text2, string text3, string text4,  string text5);
            //vt ye eklemek istediğimiz değişkenler alınır
  

        }
        public class pdf : ekle  //ekle arayüzünden pdf adında bir sınıf oluşturulur
        {
   
            public void ekle(string text1, string text2,string text3, string text4,  string text5)
            {

                veritabani.baglanti vt = new veritabani.baglanti();
                SqlConnection baglan = new SqlConnection(vt.connn);
                baglan.Open();//vt bağlantısı aktif edilir
                SqlCommand cmd = new SqlCommand("sp_kitapEkle", baglan);//sp_kitapEkle StoredProcedure ü çağrılır
                cmd.CommandType = CommandType.StoredProcedure;// StoredProcedure komutu atanır
                cmd.Parameters.Add("kitap_adi", SqlDbType.NVarChar, 50).Value = text1;//değişkeler vt karşılıklarına atanır
                cmd.Parameters.Add("kitap_yazari", SqlDbType.NVarChar, 50).Value = text2;
                cmd.Parameters.Add("kitap_sayfasi", SqlDbType.Int).Value = Convert.ToInt32(text3);
                cmd.Parameters.Add("kitap_basimyili", SqlDbType.NVarChar, 50).Value = text4;
                cmd.Parameters.Add("kitap_pdfadres", SqlDbType.NVarChar, 150).Value = text5;
                cmd.ExecuteNonQuery();//komut çalıştırılır ve vt ye kayıt işlemi gerçkeleştirilir
                baglan.Close();//vt bağlantısı kapatılır

                KitapOku kitapoku = new KitapOku();
                kitapoku.Show();//kitapoku formu gösterilir
                
            }



     




          
        }








        public Form2()
        {
            InitializeComponent();
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            pdf a = new pdf();// pdf clasına ulaşım sağlamak için a değişkeni yaratılıt
            a.ekle(textBox1.Text, textBox2.Text,textBox3.Text,maskedTextBox1.Text,textBox5.Text);
            //pdf clasındaki ekle fonksiyonuna gerkli değişkeler gönderilir


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = " PDF Dosyaları | *.pdf";
            open.ShowDialog();

            textBox5.Text = open.FileName.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}
