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
    public partial class Form3 : Form
    {
        List<Radnik> L;
        Radnik odRad;
        public Form3(List<Radnik> L)
        {
            InitializeComponent();
            this.L = L;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please be patient while system loads the necessary data ...");
            foreach (var r in L)
            {
                listBox1.Items.Add(r.ToString());
            }
            MessageBox.Show("All required data is successfully loaded. Thank you for being patient!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            odRad = L[ind];
            richTextBox1.Text = "Employee ID:\t\t" + odRad.Sifra + "\n" +
                                "Employee name and surname:\t" + odRad.ImePrezime + "\n" +
                                "Occupation:\t\t" + odRad.Zanimanje + "\n" +
                                "Salary:\t\t\t" + odRad.Plata + "\n" +
                                "Overtime compensation:\t" + odRad.Prekovremeni + "\n" +
                                "Year of employment:\t" + odRad.Godina + "\n" +
                                "City:\t\t\t" + odRad.Mesto + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("ERROR: Please select an employee.");
                return;
            }
            Form5 f5 = new Form5(odRad);
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("ERROR: Please select an employee.");
                return;
            }
            Form7 f7 = new Form7(odRad);
            f7.Show();
        }
    }
}
