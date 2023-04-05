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
    public partial class ElektrkFrm : Form
    {
        public ElektrkFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=Ders_Calısma;Integrated Security=True");


        // Pazartesi ders ekleme çıkarma

        private void PzrtsiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Elektrik (DersAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", PzrtsiEkleTxtBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();     

            string metin = PzrtsiEkleTxtBox.Text;
            PzrtsiChckLstBox.Items.Add(metin);
            PzrtsiEkleTxtBox.Text = "";
            MessageBox.Show("Ders eklendi");
        }

        private void PzrtsiCikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komutsil = new SqlCommand("Delete From Tbl_Elektrik Where DersAd = @k1", baglanti);
            Komutsil.Parameters.AddWithValue("@k1", PzrtsiCikarTxtBox.Text);
            Komutsil.ExecuteNonQuery();
            baglanti.Close();

            int indeks = PzrtsiChckLstBox.SelectedIndex;
            PzrtsiChckLstBox.Items.RemoveAt(indeks);
            PzrtsiCikarTxtBox.Text = "";
            MessageBox.Show("Kayıt Silindi");
        }

        private void PzrtsiChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PzrtsiCikarTxtBox.Text = PzrtsiChckLstBox.SelectedItem.ToString();
        }

        // Salı ders ekleme çıkarma

        private void SalıEkle_Click(object sender, EventArgs e)
        {
            string metin1 = SalıEkleTxtBox.Text;
            SaliChckLstBox.Items.Add(metin1);
            SalıEkleTxtBox.Text = "";
        }

        private void SalıCikar_Click(object sender, EventArgs e)
        {
            int indeks = SaliChckLstBox.SelectedIndex;
            SaliChckLstBox.Items.RemoveAt(indeks);
            SaliCikarTxtBox.Text = "";
        }

        private void SaliChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaliCikarTxtBox.Text = SaliChckLstBox.SelectedItem.ToString();
        }

        // Çarşamba ders ekleme çıkarma

        private void CrsmbEkle_Click(object sender, EventArgs e)
        {
            string metin2 = CrsmbEkleTxtBox.Text;
            CrsmbChckLstBox.Items.Add(metin2);
            CrsmbEkleTxtBox.Text = "";
        }

        private void CrsmbCıkar_Click(object sender, EventArgs e)
        {
            int indeks = CrsmbChckLstBox.SelectedIndex;
            CrsmbChckLstBox.Items.RemoveAt(indeks);
            CrsmbCikarTxtBox.Text = "";
        }

        private void CrsmbChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrsmbCikarTxtBox.Text = CrsmbChckLstBox.SelectedItem.ToString();
        }

        // Perşembe ders ekleme çıkarma

        private void PrsmbEkle_Click(object sender, EventArgs e)
        {
            string metin2 = PrsmbEkleTxtBox.Text;
            PrsmbChckLstBox.Items.Add(metin2);
            PrsmbEkleTxtBox.Text = "";
        }

        private void PrsmbCıkar_Click(object sender, EventArgs e)
        {
            int indeks = PrsmbChckLstBox.SelectedIndex;
            PrsmbChckLstBox.Items.RemoveAt(indeks);
            PrsmbCikarTxtBox.Text = "";
        }

        private void PrsmbChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrsmbCikarTxtBox.Text = PrsmbChckLstBox.SelectedItem.ToString();
        }

        // Cuma ders ekleme çıkarma

        private void CumaEkle_Click(object sender, EventArgs e)
        {
            string metin2 = CumaEkleTxtBox.Text;
            CumaChckLstBox.Items.Add(metin2);
            CumaEkleTxtBox.Text = "";
        }

        private void CumaCıkar_Click(object sender, EventArgs e)
        {
            int indeks = CumaChckLstBox.SelectedIndex;
            CumaChckLstBox.Items.RemoveAt(indeks);
            CumaCikarTxtBox.Text = "";
        }

        private void CumaChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CumaCikarTxtBox.Text = CumaChckLstBox.SelectedItem.ToString();
        }
          
         // Cumartesi ders ekleme çıkarma

        private void CmrtsiEkle_Click(object sender, EventArgs e)
        {
            string metin2 = CmrtsiEkleTxtBox.Text;
            CmrtsiChckLstBox.Items.Add(metin2);
            CmrtsiEkleTxtBox.Text = "";
        }

        private void CmrtsiCıkar_Click(object sender, EventArgs e)
        {
            int indeks = CmrtsiChckLstBox.SelectedIndex;
            CmrtsiChckLstBox.Items.RemoveAt(indeks);
            CmrtsiCikarTxtBox.Text = "";
        }

        private void CmrtsiChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmrtsiCikarTxtBox.Text = CmrtsiChckLstBox.SelectedItem.ToString();
        }

        // Pazar ders ekleme çıkarma

        private void PazarEkle_Click(object sender, EventArgs e)
        {
            string metin2 = PazarEkleTxtBox.Text;
            PazarChckLstBox.Items.Add(metin2);
            PazarEkleTxtBox.Text = "";
        }

        private void PazarCıkar_Click(object sender, EventArgs e)
        {
            int indeks = PazarChckLstBox.SelectedIndex;
            PazarChckLstBox.Items.RemoveAt(indeks);
            PazarCikarTxtBox.Text = "";
        }

        private void PazarChckLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PazarCikarTxtBox.Text = PazarChckLstBox.SelectedItem.ToString();
        }

    }
}
