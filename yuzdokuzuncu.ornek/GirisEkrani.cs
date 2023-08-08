using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuzdokuzuncu.ornek
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            go:
            string kAdi = txtname.Text;
            int sifre=int.Parse(txtpassword.Text);
            if (kAdi=="admin" && sifre == 1234)
            {
                MessageBox.Show("Sayın "+kAdi + " Hoşgeldiniz");
                Form1 pencere=new Form1();
                pencere.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre, tekrar deneyiniz...");
                txtname.Clear();
                txtpassword.Clear();
                goto go;
            }
        }
    }
}
