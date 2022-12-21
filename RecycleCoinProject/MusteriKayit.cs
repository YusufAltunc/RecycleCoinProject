using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoinProject
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public float baslangicdegerleri = 0;
        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            ShaHesapla();
            //ekle
            SqlCommand komut = new SqlCommand("insert into MusteriTbl (Ad,Soyad,TC,Sifre,BeforeSHA256,SHA256,CarbonDegeri,CoinDegeri) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", lblOncekiSha.Text);
            komut.Parameters.AddWithValue("@p6", lblsha.Text);
            komut.Parameters.AddWithValue("@p7", baslangicdegerleri);
            komut.Parameters.AddWithValue("@p8", baslangicdegerleri);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select Count(*) From MusteriTbl", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblmusteritoplam.Text = dr1[0].ToString();

            }
            SqlCommand komut2 = new SqlCommand("Select SHA256 From MusteriTbl where Id=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(lblmusteritoplam.Text));
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblOncekiSha.Text = dr2[0].ToString();

            }
            bgl.baglanti().Close();

        }
        public string sha;
        public string ShaHesapla()
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inbytes = Encoding.ASCII.GetBytes($"{msktc.Text}-{lblOncekiSha.Text ?? ""}-{txtsifre.Text}");
            byte[] outbytes = sha256.ComputeHash(inbytes);
            lblsha.Text = Convert.ToBase64String(outbytes);
            sha = lblsha.Text;
            return sha;
        }

        
    }
}
