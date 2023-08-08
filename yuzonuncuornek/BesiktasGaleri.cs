using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuzonuncuornek
{
    public partial class BesiktasGaleri : Form
    {
        public BesiktasGaleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BesiktasGaleri_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem =="Mustang") 
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Mustang")
            {
                int kilometre = int.Parse(textBox1.Text);
                int beygir = int.Parse(textBox2.Text);
                int tutar = 1500000 + (kilometre) * beygir;
                MessageBox.Show("Ödemeniz Gereken Tutar: " + tutar.ToString());
            }
            else
            {
                int beygir = int.Parse(textBox4.Text);
                int kilometre = int.Parse(textBox3.Text);
                int tutar = 1250000 + (kilometre) * beygir;
                MessageBox.Show("Ödemeniz Gereken Tutar: " + tutar.ToString());
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();




        }
    }
}
