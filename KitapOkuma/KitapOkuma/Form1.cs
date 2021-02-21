using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KitapOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string pdfadres { get; set; }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KitapOku oku = new KitapOku();
            oku.Show();
            this.Hide();
     
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

         

          
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = pdfadres;
            axAcroPDF1.LoadFile(pdfadres);// pdf oku
        }
    }
}
