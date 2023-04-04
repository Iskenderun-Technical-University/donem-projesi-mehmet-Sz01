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
    }
}
