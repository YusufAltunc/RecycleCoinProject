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
    public partial class Donusum : Form
    {
        public Donusum()
        {
            InitializeComponent();
        }
        public string tcno;
        public decimal donusum;
        public decimal toplam;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update MusteriTbl set CoinDegeri=@p1,CarbonDegeri=@p3 where TC=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", lblTC.Text);
            komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(lblcoindegisim.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(lblcarbondegisim.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Coin Değerinizin Dönüşümü Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }

        private void Donusum_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcno;

            SqlCommand komut = new SqlCommand("Select CarbonDegeri,CoinDegeri From MusteriTbl where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            //yani yukardaki iki satırda diyoruz ki tc ye esit olan ad ve soyadı getirsin.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblcarbon.Text = Convert.ToString(dr[0]);
                lblcoin.Text = Convert.ToString(dr[1]);
            }
            bgl.baglanti().Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            donusum = Convert.ToDecimal(lblcarbon.Text) / 1000;
            toplam = Convert.ToDecimal(lblcoin.Text) + donusum;
            lblcoindegisim.Text= Convert.ToString(toplam);
            lblcarbondegisim.Text= "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }
    }
}
