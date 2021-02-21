using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapOkuma
{
    public partial class KitapSil : Form
    {

        public interface pdf   //Arayüz oluşturulur...
        {
         
            void sil(string kimlik);
            //silmek için primary key olan plaka alınır
            void guncelle(string text1, string text2, string text3, string text4, string text5, string text6);
            //vt de güncellenecek değişkenler alınır

        }
        public class duzenle : pdf  //pdf arayüzünden duzenle adında bir sınıf oluşturulur
        {




            veritabani.baglanti vt = new veritabani.baglanti();


            public void guncelle(string text1, string text2, string text3, string text4, string text5, string text6)
            {
                SqlConnection baglan = new SqlConnection(vt.connn);
                baglan.Open();
                if (text1.Trim() != "")
                {
                    SqlCommand cmd = new SqlCommand("sp_kitapDuzenle", baglan);//sp_kitapDuzenle StoredProcedure ü çağrılır
                    cmd.CommandType = CommandType.StoredProcedure;// StoredProcedure komutu atanır
                    cmd.Parameters.Add("@kitap_no", SqlDbType.Int).Value = text1;//değişkeler vt karşılıklarına atanır
                    cmd.Parameters.Add("@kitap_adi", SqlDbType.NVarChar, 50).Value = text2;
                    cmd.Parameters.Add("@kitap_yazari", SqlDbType.NVarChar, 50).Value = text3;
                    cmd.Parameters.Add("@kitap_sayfasi", SqlDbType.Int).Value = Convert.ToInt32(text4);
                    cmd.Parameters.Add("@kitap_basimyili", SqlDbType.NVarChar, 50).Value = text5;
                    cmd.Parameters.Add("@kitap_pdfadres", SqlDbType.NVarChar, 150).Value = text6;
                    cmd.ExecuteNonQuery();//komut çalıştırılır ve vt ye kayıt işlemi gerçkeleştirilir


                    MessageBox.Show("Seçilen kitap düzenlendi!");
              
                }
                else
                {
                    MessageBox.Show("Lütfen kitap seçiniz!");
                }
                baglan.Close();//vt bağlantısı kapatılır
            }





            public void sil(string kimlik)
            {


                veritabani.baglanti vt = new veritabani.baglanti();
                SqlConnection baglan = new SqlConnection(vt.connn);
                baglan.Open();
                if (kimlik.Trim() != "")
                {

                    SqlCommand cmd = new SqlCommand("sp_kitapSil", baglan);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@kitap_no", SqlDbType.Int).Value = Convert.ToInt32(kimlik);
                    cmd.ExecuteNonQuery();//komut çalıştırılır ve vt ye silme işlemi gerçkeleştirilir
                    MessageBox.Show("Seçilen kitap silindi !");
                 
                }
                else
                {
                    MessageBox.Show("ID seçilmedi!");
                }
                baglan.Close();


            }
        }










        public KitapSil()
        {
            InitializeComponent();
        }
        public void listele()
        {

            veritabani.baglanti vt = new veritabani.baglanti();
            SqlConnection baglan = new SqlConnection(vt.connn);
            baglan.Open();
            DataTable refreshgrid = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * From kitap",baglan);
            adptr.Fill(refreshgrid);
            dataGridView1.DataSource = refreshgrid;
        }
        private void KitapSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapdfDataSet3.sp_kitapListele' table. You can move, or remove it, as needed.
            this.sp_kitapListeleTableAdapter.Fill(this.kitapdfDataSet3.sp_kitapListele);
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Enabled = false;
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            duzenle vt = new duzenle();//pdf clasına ulaşım sağlamak için vt değişkeni yaratılır
            vt.guncelle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            //pdf clasındaki guncelle fonksiyonuna gerkli değişkeler gönderilir

            this.sp_kitapListeleTableAdapter.Fill(this.kitapdfDataSet3.sp_kitapListele); //DataGridView Güncellernir

        }

        private void button1_Click(object sender, EventArgs e)
        {
            duzenle vt = new duzenle();//pdf clasına ulaşım sağlamak için vt değişkeni yaratılır
            vt.sil(textBox1.Text);
            //pdf clasındaki sil fonksiyonuna gerkli değişkeler gönderilir

            this.sp_kitapListeleTableAdapter.Fill(this.kitapdfDataSet3.sp_kitapListele); //DataGridView Güncellernir
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "PDF Dosyası | *.pdf";
            openfile.ShowDialog();

            textBox6.Text = openfile.FileName; // Dosya adresi FileName , SafeFileName = Dosya adı verir.


        }
    }
}
