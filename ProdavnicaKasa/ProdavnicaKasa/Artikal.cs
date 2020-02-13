using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaKasa
{
    class Artikal
    {
        private int id_artikal;
        private string naziv;
        private double cena;
        private double popust;
        private int kolicina = 0;

        public int Id_artikal { get { return id_artikal; } set { id_artikal = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public double Cena { get { return cena; } set { cena = value; } }
        public double Popust { get { return popust; } set { popust = value; } }
        public int Kolicina { get { return kolicina; } set { kolicina = value; } }

        public Artikal()
        {

        }

        public Artikal(int id_artikal, string naziv, double cena, double popust)
        {
            this.id_artikal = id_artikal;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
        }

        public override string ToString()
        {
            if (kolicina == 0)
                return naziv + ", Cena:" + cena + ", Popust:" + popust;
            else
                return kolicina + "* " + naziv + ", Cena:" + cena + ", Popust:" + popust;
        }

       
    }
}
