using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSamochodowy.Dane
{
    public class Dane
    {
        public static List<Wyposazenie> DostepneWyposazenie { get; set; }
        public static List<Samochod> Samochody { get; set; }
        public static List<Silnik> Silniki { get; set; }

        static Dane()
        {
            DostepneWyposazenie = new List<Wyposazenie>();
            DostepneWyposazenie.Add(new Wyposazenie() { Nazwa = "Czujnik deszczu", Cena = 500, CzyStandard = false });
            DostepneWyposazenie.Add(new Wyposazenie() { Nazwa = "Tempomat", Cena = 1000, CzyStandard = false });
            DostepneWyposazenie.Add(new Wyposazenie() { Nazwa = "Radio", Cena = 2000, CzyStandard = true });
            DostepneWyposazenie.Add(new Wyposazenie() { Nazwa = "Podlokietnik", Cena = 600, CzyStandard = false });
            DostepneWyposazenie.Add(new Wyposazenie() { Nazwa = "Klimatyzacja", Cena = 2000, CzyStandard = false });

            Silniki = new List<Silnik>();
            Silniki.Add(new Silnik() { Moc = 140, Pojemnosc = 1398, Turbo = true });

            Samochod s1 = new Samochod() { CenaBazowa = 50000, Silnik = Silniki[0], Model = "A1", RokProdukcji = 2018, SpalanieSrednie = 6.1 };
            s1.ListaWyposazenia = new List<Wyposazenie>();
            s1.ListaWyposazenia.Add(DostepneWyposazenie[2]);
            s1.ListaWyposazenia.Add(DostepneWyposazenie[4]);

            Samochod s2 = new Samochod() { CenaBazowa = 45000, Silnik = Silniki[0], Model = "A2", RokProdukcji = 2018, SpalanieSrednie = 5.1 };
            s2.ListaWyposazenia = new List<Wyposazenie>();
            s1.ListaWyposazenia.Add(DostepneWyposazenie[2]);
            s1.ListaWyposazenia.Add(DostepneWyposazenie[4]);
            s1.ListaWyposazenia.Add(DostepneWyposazenie[1]);
            s1.ListaWyposazenia.Add(DostepneWyposazenie[3]);

            Samochody = new List<Samochod>();
            Samochody.Add(s1);
            Samochody.Add(s2);
        }
    }
}
