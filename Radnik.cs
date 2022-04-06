using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifikacija__Identify_App_
{
    public class Radnik
    {
        int sifra;
        string imePrezime;
        string zanimanje;
        double plata;
        double prekovremeni;
        int godina;
        string mesto;

        public Radnik(int sifra, string imePrezime, string zanimanje, double plata, double prekovremeni, int godina, string mesto)
        {
            this.sifra = sifra;
            this.imePrezime = imePrezime;
            this.zanimanje = zanimanje;
            this.plata = plata;
            this.prekovremeni = prekovremeni;
            this.godina = godina;
            this.mesto = mesto;
        }

        public int Sifra { get => sifra; set => sifra = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Zanimanje { get => zanimanje; set => zanimanje = value; }
        public double Plata { get => plata; set => plata = value; }
        public double Prekovremeni { get => prekovremeni; set => prekovremeni = value; }
        public int Godina { get => godina; set => godina = value; }
        public string Mesto { get => mesto; set => mesto = value; }

        public override string ToString()
        {
            return sifra + " " + imePrezime;
        }
    }
}
