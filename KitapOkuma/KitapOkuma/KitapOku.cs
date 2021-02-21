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
    public partial class KitapOku : Form
    {
        public KitapOku()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

          
            Form1 frm = new Form1();
            frm.pdfadres = dataGridView1.CurrentRow.Cells[5].Value.ToString();//form1 e giderken gridwiwdeki pdf adresi gönderilir
            frm.Show();

        }

        private void KitapOku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapdfDataSet.kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kitapdfDataSet.kitap);
            // TODO: This line of code loads data into the 'kitapdfDataSet3.sp_kitapListele' table. You can move, or remove it, as needed.
            this.sp_kitapListeleTableAdapter.Fill(this.kitapdfDataSet3.sp_kitapListele);
            // TODO: This line of code loads data into the 'kitapdfDataSet2.kitap' table. You can move, or remove it, as needed.

            
          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.Show();
            this.Hide();

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void kitapBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapSil kitapsil = new KitapSil();
            kitapsil.Show();
        }
    }
}
