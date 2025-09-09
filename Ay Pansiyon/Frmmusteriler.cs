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
    public partial class Frmmusteriler : Form
    {
        public Frmmusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=ELOCAT\\SQLEXPRESS;Initial Catalog=AyPansiyon;Integrated Security=True;TrustServerCertificate=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());
               
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txttcno.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpgiristarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcikistarih.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodano.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }
            if (txtodano.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Silindi.");
                verilerigoster();
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            comboBox1.Text="";
            msktel.Clear();
            txtmail.Text="";
            txttcno.Clear();
            txtodano.Clear();
            txtucret.Clear();
            dtpgiristarih.Text = "";
            dtpcikistarih.Text = "";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set adi='" + txtadi.Text + "',Soyadi='" + txtsoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + msktel.Text +"',Mail='"+txtmail.Text+"',TC='"+txttcno.Text+"',OdaNo='"+txtodano.Text+"',Ucret='"+txtucret.Text+"',GirisTarih='"+dtpgiristarih.Value.ToString("yyyy-MM-dd")+ "',CikisTarih='" + dtpcikistarih.Value.ToString("yyyy-MM-dd")+ "'where Musteriid=" +id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Güncellendi.");
            verilerigoster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void Frmmusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")",baglanti);
