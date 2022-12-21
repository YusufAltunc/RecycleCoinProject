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
    public partial class GeriDonusum : Form
    {
        public GeriDonusum()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tckimlik;

        private void GeriDonusum_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From NesnelerTbl",bgl.baglanti());
            da1.Fill(dt);
            dataGridView1.DataSource= dt;

            // TODO: This line of code loads data into the 'recycleCoinDataSet.NesnelerTbl' table. You can move, or remove it, as needed.
            this.nesnelerTblTableAdapter.Fill(this.recycleCoinDataSet.NesnelerTbl);
            lblTC.Text = tckimlik;

            SqlCommand komut = new SqlCommand("Select CarbonDegeri From MusteriTbl where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblCarbon.Text = Convert.ToString(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblnesne.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lbldeger.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
        public int toplam;
        public int toplam2;
        private void button1_Click(object sender, EventArgs e)
        {
            toplam = Convert.ToInt32(lbldeger.Text)*Convert.ToInt32(txtadet.Text);
            lblsondeger.Text = Convert.ToString(toplam);
            toplam2 = Convert.ToInt32(lblsondeger.Text) + Convert.ToInt32(lblCarbon.Text);
            lbltoplamcarbon.Text = toplam2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update MusteriTbl set CarbonDegeri=@p2 where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(lbltoplamcarbon.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değer Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }
    }
}
