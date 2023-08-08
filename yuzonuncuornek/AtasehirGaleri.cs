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
    public partial class AtasehirGaleri : Form
    {
        public AtasehirGaleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Seçiminiz: " + radioButton1.Text);
            }
            else
            {
                MessageBox.Show("Seçiminiz: "+radioButton2.Text);
            }
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Seçiminiz: " + checkBox1.Text);
            }
            else
            {
                MessageBox.Show("Seçiminiz: " + checkBox2.Text);
            }
        }
    }
}
