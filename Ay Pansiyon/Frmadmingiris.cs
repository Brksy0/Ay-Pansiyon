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
    public partial class Frmadmingiris : Form
    {
        public Frmadmingiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELOCAT\\SQLEXPRESS;Initial Catalog=AyPansiyon;Integrated Security=True;TrustServerCertificate=True");


        private void btngirisyap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1= new SqlParameter("KullaniciAdi",txtkullanıcıadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi",txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show(); this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş!");
            }
        }

        private void Frmadmingiris_Load(object sender, EventArgs e)
        {

        }
    }
}