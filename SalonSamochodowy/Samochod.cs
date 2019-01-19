using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSamochodowy
{
    public class Samochod
    {
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public Silnik Silnik { get; set; }
        public double SpalanieSrednie { get; set; }
        public int CenaBazowa { get; set; }
        public List<Wyposazenie> ListaWyposazenia {get;set; }
    }
}
