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

namespace Ders_Calısma_Programı
{
    public partial class UyeKayitFrm : Form
    {
        public UyeKayitFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=Ders_Calısma;Integrated Security=True");

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_UyeGrs(UyeKullaniciAd,UyeSifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Eklendi");

            GirisFrm frm = new GirisFrm();
            frm.Show();
            this.Hide();
        }
    }
}
