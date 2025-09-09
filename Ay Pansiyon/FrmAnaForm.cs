using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay Pansiyona Hoşgeldiniz.Lütfen Yapmak İstediğiniz İşlemi Aşağıdan Seçiniz.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmyenimusteri fr = new Frmyenimusteri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmodalar frmodalar = new frmodalar();
            frmodalar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmmusteriler fr = new Frmmusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay Pansiyon Uygulaması Staj İçin Burak Said Yöndemli Tarafından Hazırlanmış Bir Projedir.");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmgelirgider fr=new Frmgelirgider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmstoklar fr=new Frmstoklar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mesajlar fr=new Mesajlar();
            fr.Show();
        }
    }
}
