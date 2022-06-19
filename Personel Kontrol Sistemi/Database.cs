using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Personel_Kontrol_Sistemi
{
    class Database
    {
        public static SqlConnection baglanti= new SqlConnection("Server=.\\SQLExpress;Database=Personel_Takip;Trusted_Connection=True;");
        public static void ESG(SqlCommand cmd,string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public static DataTable Listele_Ara(DataGridView gridView,string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
             adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();


            return tbl;
        }

   
    }
}
