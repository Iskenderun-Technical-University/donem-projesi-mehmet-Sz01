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
    public partial class BlgsyrFrm : Form
    {
        public BlgsyrFrm()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=Ders_Calısma;Integrated Security=True");


    }
}
