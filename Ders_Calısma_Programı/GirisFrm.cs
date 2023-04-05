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
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=Ders_Calısma;Integrated Security=True");

        private void KayitBtn_Click(object sender, EventArgs e)
        {
            UyeKayitFrm frm = new UyeKayitFrm();
            frm.Show();
            this.Hide();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_UyeGrs where UyeKullaniciAd = @p1 and UyeSifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DersPrgrmFrm frm = new DersPrgrmFrm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglanti.Close();
        }
    }
}
