using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijeVozila
{
   class Vozilo
    {
        private int brojkotaca, godProizvodnje;
        private string model, kategorija;

        public Vozilo(int brojkotaca, int godProizvodnje, string model, string kategorija)
        {
            this.brojkotaca = brojkotaca;
            this.godProizvodnje = godProizvodnje;
            this.model = model;
            this.kategorija = kategorija;
        }

        public int Brojkotaca { get => brojkotaca; set => brojkotaca = value; }
        public int GodProizvodnje { get => godProizvodnje; set => godProizvodnje = value; }
        public string Model { get => model; set => model = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

       
        public override string ToString()
        {
            string ispis = this.model + "\t" + this.godProizvodnje + "\t" + this.brojkotaca + "\t\t" + this.kategorija;
            return ispis;
        }
    }
  
}
