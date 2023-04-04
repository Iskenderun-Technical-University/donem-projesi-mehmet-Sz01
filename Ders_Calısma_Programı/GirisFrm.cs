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
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersPrgrmFrm fr1 = new DersPrgrmFrm();
            fr1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeKayitFrm fr1 = new UyeKayitFrm();
            fr1.Show();
            this.Hide();
        }
    }
}
