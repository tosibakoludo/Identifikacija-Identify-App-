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
    public partial class Form6 : Form
    {
        Radnik odRad;
        Graphics g;
        Bitmap b, sablon;
        public Form6(Radnik odRad)
        {
            InitializeComponent();
            this.odRad = odRad;
        }

        private void odaberiFotografijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg pic|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(new Bitmap(ofd.FileName), 590, 125, 235, 235);
                pictureBox1.Invalidate();
            }
        }

        private void sačuvajKaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png fotografija|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(sfd.FileName);
                    MessageBox.Show("Kartica je sačuvana USPEŠNO.");
                }
                catch
                {
                    MessageBox.Show("GREŠKA: Kartica nije sačuvana.");
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1217, 762); //1201 699 +16 +63

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Black);

            sablon = new Bitmap("taki_company.jpg");

            string sifra;
            if (odRad.Sifra < 10)
            {
                sifra = "00000" + odRad.Sifra;
            }
            else if (odRad.Sifra < 100)
            {
                sifra = "0000" + odRad.Sifra;
            }
            else if (odRad.Sifra < 1000)
            {
                sifra = "000" + odRad.Sifra;
            }
            else if (odRad.Sifra < 10000)
            {
                sifra = "00" + odRad.Sifra;
            }
            else if (odRad.Sifra < 100000)
            {
                sifra = "0" + odRad.Sifra;
            }
            else
            {
                sifra = odRad.Sifra.ToString();
            }
            g.DrawImage(sablon, 0, 0);
            g.DrawString(sifra + "\n" + odRad.ImePrezime.ToUpper(), new Font("Consolas", 26, FontStyle.Bold), Brushes.White, 570, 390);
            string zanimanje = odRad.Zanimanje;
            if (odRad.Zanimanje.Contains(',') || odRad.Zanimanje.Contains('('))
            {
                zanimanje = zanimanje.Split(',')[0];
                zanimanje = zanimanje.Split('(')[0];
            }
            g.DrawString(zanimanje.ToUpper(), new Font("Consolas", 16, FontStyle.Bold), Brushes.White, 570, 490);
            g.DrawString("DATUM IZDAVANJA: " + DateTime.Now.ToString("dd.MM.yyyy.") + "\nVAŽI DO: " + DateTime.Now.AddYears(2).ToString("dd.MM.yyyy.") + "\nMESTO: " + odRad.Mesto.ToUpper(), new Font("Consolas", 10, FontStyle.Bold), Brushes.White, 570, 535);
            pictureBox1.Invalidate();
        }
    }
}
