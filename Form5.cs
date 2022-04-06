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
    public partial class Form5 : Form
    {
        Radnik odRad;
        Graphics g;
        Bitmap b, sablon;
        public Form5(Radnik odRad)
        {
            InitializeComponent();
            this.odRad = odRad;
        }

        private void openPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg pic|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(new Bitmap(ofd.FileName), 60, 50, 235, 235);
                pictureBox1.Invalidate();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png pic|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(sfd.FileName);
                    MessageBox.Show("ID Card saved SUCCESSFULLY.");
                }
                catch
                {
                    MessageBox.Show("ERROR: ID Card is not saved");
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Size = new Size(815, 575); //1000 641

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Black);

            sablon = new Bitmap("idKarta.jpg");

            g.DrawImage(sablon, 0, 0);
            g.DrawString(odRad.ImePrezime + "\n(" + odRad.Sifra + ")", new Font("Consolas", 26, FontStyle.Bold), Brushes.White, 55, 300);
            g.DrawString("EMPLOYEE ID: (" + odRad.Sifra + ")", new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 200);
            g.DrawString("YEAR OF EMPLOYMENT:\n" + odRad.Godina, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 300);
            pictureBox1.Invalidate();
        }
    }
}
