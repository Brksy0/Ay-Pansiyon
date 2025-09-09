using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Frmyenimusteri : Form
    {
        public Frmyenimusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELOCAT\\SQLEXPRESS;Initial Catalog=AyPansiyon;Integrated Security=True;TrustServerCertificate=True");

        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtodano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void btnbosoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void dtpcıkıstarih_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpgiristarih.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcikistarih.Text);

            TimeSpan sonuc = buyuktarih - kucuktarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 500;
            txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarih,CikisTarih)values('" + txtadi.Text + "','" + txtsoyadi.Text + "','" + comboBox1.Text + "','" + msktel.Text + "','" + txtmail.Text + "','" + txttcno.Text + "','" + txtodano.Text + "','" + txtucret.Text + "','" + dtpgiristarih.Value.ToString("yyyy-MM-dd") + "','" + dtpcikistarih.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Yapıldı.");
        }

        private void Frmyenimusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open(); SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti); SqlDataReader oku1 = komut1.ExecuteReader(); while (oku1.Read()) { btnoda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda101.Text != "101") { btnoda101.BackColor = Color.Red; btnoda101.Enabled = false; }
            baglanti.Open(); SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti); SqlDataReader oku2 = komut2.ExecuteReader(); while (oku2.Read()) { btnoda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda102.Text != "102") { btnoda102.BackColor = Color.Red; btnoda102.Enabled = false; }
            baglanti.Open(); SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti); SqlDataReader oku3 = komut3.ExecuteReader(); while (oku3.Read()) { btnoda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda103.Text != "103") { btnoda103.BackColor = Color.Red; btnoda103.Enabled = false; }
            baglanti.Open(); SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti); SqlDataReader oku4 = komut4.ExecuteReader(); while (oku4.Read()) { btnoda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda104.Text != "104") { btnoda104.BackColor = Color.Red; btnoda104.Enabled = false; }
            baglanti.Open(); SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti); SqlDataReader oku5 = komut5.ExecuteReader(); while (oku5.Read()) { btnoda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda105.Text != "105") { btnoda105.BackColor = Color.Red; btnoda105.Enabled = false; }
            baglanti.Open(); SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti); SqlDataReader oku6 = komut6.ExecuteReader(); while (oku6.Read()) { btnoda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda106.Text != "106") { btnoda106.BackColor = Color.Red; btnoda106.Enabled = false; }
            baglanti.Open(); SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti); SqlDataReader oku7 = komut7.ExecuteReader(); while (oku7.Read()) { btnoda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda107.Text != "107") { btnoda107.BackColor = Color.Red; btnoda107.Enabled = false; }
            baglanti.Open(); SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti); SqlDataReader oku8 = komut8.ExecuteReader(); while (oku8.Read()) { btnoda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda108.Text != "108") { btnoda108.BackColor = Color.Red; btnoda108.Enabled = false; }
            baglanti.Open(); SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti); SqlDataReader oku9 = komut9.ExecuteReader(); while (oku9.Read()) { btnoda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString(); }
            baglanti.Close(); if (btnoda109.Text != "109") { btnoda109.BackColor = Color.Red; btnoda109.Enabled = false; }
        }
    }
}
