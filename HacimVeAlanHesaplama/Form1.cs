using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacimVeAlanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hacim hcm = new Hacim(Convert.ToInt32(txtUzunKenar.Text),
                                  Convert.ToInt32(txtKisaKenar.Text),
                                  Convert.ToInt32(txtAyritUzunluk.Text));
            int sonuc =hcm.HacimHesapla();
            txtSonuc.Text = sonuc.ToString();
           
        }

        private void btnKüpHacimHesapla_Click(object sender, EventArgs e)
        {
            Hacim hcmKüp = new Hacim(Convert.ToInt32(txtKüp.Text));
            int sonuc = hcmKüp.HacimHesaplaKüp();
            txtSonuc.Text = sonuc.ToString();


        }

        private void btnDikdörtgenAlanHesapla_Click(object sender, EventArgs e)
        {
            Alan alanDikdörtgen = new Alan(Convert.ToInt32(txtUzunKenarAlan.Text),
                                           Convert.ToInt32(txtKisaKenarAlan.Text));
            int sonucAlan = alanDikdörtgen.DikdörtgenAlanHesapla();
            txtSonucAlan.Text = sonucAlan.ToString();

        }

        private void btnKareAlanHesapla_Click(object sender, EventArgs e)
        {
            Alan alanKare = new Alan(Convert.ToInt32(txtKareAlan.Text));
            int sonucAlan = alanKare.KareAlanHesapla();
            txtSonucAlan.Text = sonucAlan.ToString();


            
        }
    }
}
