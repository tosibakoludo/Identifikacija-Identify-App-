using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identifikacija__Identify_App_
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap b;
        SQLiteConnection con;
        List<Radnik> L = new List<Radnik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.LightBlue);
            g.FillEllipse(Brushes.Lavender, 25, 125, 650, 200);
            pictureBox1.Invalidate();

            try
            {
                con = new SQLiteConnection("Data source=" + Directory.GetCurrentDirectory() + @"\..\..\database.sqlite");

                con.Open();

                string tk = "select * from Salaries order by Id";
                SQLiteCommand cm = new SQLiteCommand(tk, con);

                var r = cm.ExecuteReader();

                while (r.Read())
                {
                    var sifra = r.GetInt32(0);
                    var imePrezime = r.GetString(1);
                    var zanimanje = r.GetString(2);
                    var plata = r.GetDouble(3);
                    var prekovremeni = r.GetDouble(4);
                    var godina = r.GetInt32(9);
                    var mesto = r.GetString(11);
                    Radnik nr = new Radnik(sifra, imePrezime, zanimanje, plata, prekovremeni, godina, mesto);
                    L.Add(nr);
                }
            }
            catch (DllNotFoundException x)
            {
                MessageBox.Show("GREŠKA/ERROR: " + x.Message + "\n=> Probajte da rebildujete program i ponovo ga pokrenete.\n=>Try rebuilding solution and starting it again.");
                this.Close();
            }
            catch (InvalidCastException)
            {
                return;
            }
            catch (Exception x)
            {
                MessageBox.Show("GREŠKA/ERROR: " + x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(L);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(L);
            f3.Show();
        }
    }
}
