using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Calısma_Programı
{
    public partial class DersPrgrmFrm : Form
    {
        public DersPrgrmFrm()
        {
            InitializeComponent();
        }

        private void ElktrkBtn_Click(object sender, EventArgs e)
        {
            //Elektrik bölümüne geçiş

            ElektrkFrm fr = new ElektrkFrm();
            fr.Show();
            this.Hide();
        }

        private void BlgsyrBtn_Click(object sender, EventArgs e)
        {
            BlgsyrFrm fr2 = new BlgsyrFrm();
            fr2.Show();
            this.Hide();
        }

        private void InstBtn_Click(object sender, EventArgs e)
        {
            InsaatFrm fr3 = new InsaatFrm();
            fr3.Show();
            this.Hide();
        }

        private void MknBtn_Click(object sender, EventArgs e)
        {
            MakineFrm fr4 = new MakineFrm();
            fr4.Show();
            this.Hide();
        }

        private void PtrlBtn_Click(object sender, EventArgs e)
        {
            PetrolFrm fr5 = new PetrolFrm();
            fr5.Show();
            this.Hide();
        }

        private void BymdklBtn_Click(object sender, EventArgs e)
        {
            BiyomedikalFrm fr5 = new BiyomedikalFrm();
            fr5.Show();
            this.Hide();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            GirisFrm fr5 = new GirisFrm();
            fr5.Show();
            this.Hide();
        }
    }
}
