using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace KitapOkuma
{
    class veritabani
    {

        public class baglanti//veritabanı yolu kapsülleme ile gizlenir
        {
            private string conn = "Data Source=ATOMER\\SQLEXPRESS;Initial Catalog=kitapdf;Integrated Security=True";
            //Veritabanının bağlantı yolu private bir değişkene atanır...
            public string connn
            {
                get { return conn; }
                set { conn = value; }
            }
        }

    }
}
