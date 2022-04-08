using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProject1
{
    public partial class frmögretmen : Form
    {
        public frmögretmen()
        {
            InitializeComponent();
        }

        private void BtnKulüp_Click(object sender, EventArgs e)
        {
            frmKulüp fr = new frmKulüp();
            fr.Show();
            
        }

        private void btnDersİşlemleri_Click(object sender, EventArgs e)
        {
            frmDersİşlemleri fr = new frmDersİşlemleri();
            fr.Show();
            
        }

        private void BtnÖğrenci_Click(object sender, EventArgs e)
        {
            frmÖğrenci fr = new frmÖğrenci();
            fr.Show();
            
        }

        private void BtnSınav_Click(object sender, EventArgs e)
        {
            frmNotlar fr = new frmNotlar();
            fr.Show();
        }
    }
}
