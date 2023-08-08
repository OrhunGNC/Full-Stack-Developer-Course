using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuzonuncuornek
{
    public partial class TalepSikayet : Form
    {
        public TalepSikayet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TalepEkrani talepEkrani = new TalepEkrani();
            talepEkrani.listBox1.Items.Add("Telefon No: " + maskedTextBox1.Text);
            talepEkrani.listBox1.Items.Add("Tarih: " + dateTimePicker1.Text);
            talepEkrani.listBox1.Items.Add("Şikayet&Talep: " + textBox1.Text);
            talepEkrani.Show();
            this.Hide();
        }
    }
}
