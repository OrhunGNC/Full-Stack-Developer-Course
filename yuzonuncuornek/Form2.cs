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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void şikayetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TalepSikayet talepSikayet = new TalepSikayet();
            talepSikayet.Show();
            this.Hide();
        }

        private void ataşehirGaleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtasehirGaleri atasehir = new AtasehirGaleri();
            atasehir.Show();
            this.Hide();
        }

        private void beşiktaşGaleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BesiktasGaleri besiktas=new BesiktasGaleri();
            besiktas.Show();
            this.Hide();
        }
    }
}
