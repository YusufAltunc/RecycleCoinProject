using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoinProject
{
    public partial class MusteriAnaEkran : Form
    {
        public MusteriAnaEkran()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
        private void MusteriAnaEkran_Load(object sender, EventArgs e)
        {
            SayfaYukleme();
        }

        public void SayfaYukleme()
        {
            lblTC.Text = tc;

            SqlCommand komut = new SqlCommand("Select Ad,Soyad,CarbonDegeri,CoinDegeri,SHA256 From MusteriTbl where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            //yani yukardaki iki satırda diyoruz ki tc ye esit olan ad ve soyadı getirsin.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
                lblcarbon.Text = Convert.ToString(dr[2]);
                lblcoin.Text = Convert.ToString(dr[3]);
                lbladres.Text = Convert.ToString(dr[4]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donusum fr = new Donusum();
            fr.tcno = tc;
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeriDonusum fr = new GeriDonusum();
            fr.tckimlik = tc;
            fr.Show();
            this.Hide();
        }

        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            Transfer fr = new Transfer();
            fr.TcNo = tc;
            fr.Show();
            this.Hide();
        }
    }
}
