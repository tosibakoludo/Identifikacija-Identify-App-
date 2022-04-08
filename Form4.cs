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
    public partial class Form4 : Form
    {
        Radnik odRad;
        Graphics g;
        Bitmap b, sablon;
        public Form4(Radnik odRad)
        {
            InitializeComponent();
            this.odRad = odRad;
        }

        private void odaberiFotografijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg slika|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(new Bitmap(ofd.FileName), 60, 50, 235, 235);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(1016, 704);
            this.Size = new Size(815, 575);

            //MessageBox.Show("PictureBox size = " + pictureBox1.Size); // => 1) 1000, 641 2) 799, 512

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Black);

            //MessageBox.Show("PictureBox image size = " + pictureBox1.Image.Size); // => 1) 1000, 641 2) 799, 512

            sablon = new Bitmap("idKarta.jpg");

            //MessageBox.Show("idKarta.jpg size = " + sablon.Size); // => 1) 1000, 641 2) 1000, 641

            g.DrawImage(sablon, 0, 0);
            g.DrawString(odRad.ImePrezime + "\n(" + odRad.Sifra + ")", new Font("Consolas", 26, FontStyle.Bold), Brushes.White, 55, 300);
            g.DrawString("ŠIFRA RADNIKA: (" + odRad.Sifra + ")", new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 200);
            g.DrawString("GODINA ZAPOSLENJA:\n" + odRad.Godina, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 300);
            pictureBox1.Invalidate();
        }
    }
}
