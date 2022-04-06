using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identifikacija__Identify_App_
{
    public partial class Form2 : Form
    {
        List<Radnik> L;
        Radnik odRad;
        public Form2(List<Radnik> L)
        {
            InitializeComponent();
            this.L = L;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Molimo za strpljenje dok sistem učita sve potrebne podatke ... ");
            foreach (var r in L)
            {
                listBox1.Items.Add(r.ToString());
            }
            MessageBox.Show("Svi potrebni podaci su uspešno učitani. Hvala na strpljenju!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            odRad = L[ind];
            richTextBox1.Text = "Šifra radnika:\t\t" + odRad.Sifra + "\n" +
                                "Ime i prezime radnika:\t" + odRad.ImePrezime + "\n" +
                                "Zanimanje:\t\t" + odRad.Zanimanje + "\n" +
                                "Plata:\t\t\t" + odRad.Plata + "\n" +
                                "Naknada za prekovr. rad:\t" + odRad.Prekovremeni + "\n" +
                                "Godina zaposlenja:\t\t" + odRad.Godina + "\n" +
                                "Mesto:\t\t\t" + odRad.Mesto + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("GREŠKA: Morate da odaberete jednog radnika!");
                return;
            }
            Form4 f4 = new Form4(odRad);
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("GREŠKA: Morate da odaberete jednog radnika!");
                return;
            }
            Form6 f6 = new Form6(odRad);
            f6.Show();
        }
    }
}
