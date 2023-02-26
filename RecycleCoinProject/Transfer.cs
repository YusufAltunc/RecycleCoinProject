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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Transfer_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("Select * From MusteriTbl",bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'recycleCoinDataSet1.MusteriTbl' table. You can move, or remove it, as needed.
            this.musteriTblTableAdapter.Fill(this.recycleCoinDataSet1.MusteriTbl);
            lblTC.Text = TcNo;

            SqlCommand komut = new SqlCommand("Select CoinDegeri,SHA256 From MusteriTbl where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblCarbon.Text = Convert.ToString(dr[0]);
                lblgondericiadres.Text= Convert.ToString(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblaliciadres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }
        public decimal coindegeri;
        public decimal transfermiktari;
        public decimal alicideger;
        private void button2_Click(object sender, EventArgs e)
        {
            coindegeri = Convert.ToDecimal(lblCarbon.Text);
            transfermiktari = Convert.ToDecimal(textBox1.Text);
            if(coindegeri > transfermiktari || coindegeri == transfermiktari)
            {
                //işlem devam et
                if(lblaliciadres.Text != lblgondericiadres.Text)
                {
                    lblgndrcyeni.Text = Convert.ToString(coindegeri - transfermiktari);
                    //goster
                    SqlCommand komut = new SqlCommand("Select CoinDegeri From MusteriTbl where SHA256=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", lblaliciadres.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        lblaliciyeni.Text = dr[0].ToString();
                    }
                    alicideger = Convert.ToDecimal(lblaliciyeni.Text) + transfermiktari;

                    //guncelle
                    SqlCommand komut3 = new SqlCommand("Update MusteriTbl set CoinDegeri=@p2 where SHA256=@p1", bgl.baglanti());
                    komut3.Parameters.AddWithValue("@p1", lblaliciadres.Text);
                    komut3.Parameters.AddWithValue("@p2", alicideger);
                    komut3.ExecuteNonQuery();
                    SqlCommand komut4 = new SqlCommand("Update MusteriTbl set CoinDegeri=@d2 where SHA256=@d1", bgl.baglanti());
                    komut4.Parameters.AddWithValue("@d1", lblgondericiadres.Text);
                    komut4.Parameters.AddWithValue("@d2", Convert.ToDecimal(lblgndrcyeni.Text));
                    komut4.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Coin Degerleri Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kendinize Coin gönderemezsiniz!!");
                }
            }
            else
            {
                MessageBox.Show("Girilen Carbon miktari cüzdanınızda bulunmamaktadır.Tekrar Deneyin!!!");
            }
        }
    }
}
