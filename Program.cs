using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botoslili_konyv_osztaly
{
    public class Konyv
    {
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Oldalszam { get; set; }
        public double Ar { get; set; }

        public Konyv(string cim, string szerzo, int oldalszam, double ar)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Ar = ar;
        }

        public Konyv(string cim, string szerzo, int oldalszam) : this(cim, szerzo, oldalszam, 3000)
        {
        }

        public override string ToString()
        {
            return $"Cím: {Cim}, Szerző: {Szerzo}, Oldalszám: {Oldalszam}, Ár: {Ar} Ft";
        }

        public bool VastagKonyv()
        {
            return Oldalszam > 500;
        }
        public bool DragaKonyv()
        {
            return Ar > 5000;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hány könyvet szeretne felvenni? ");
            int n = int.Parse(Console.ReadLine());
            Konyv[] konyvek = new Konyv[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Könyv címe: ");
                string cim = Console.ReadLine();

                Console.Write("Szerző: ");
                string szerzo = Console.ReadLine();

                Console.Write("Oldalszám: ");
                int oldalszam = int.Parse(Console.ReadLine());

                Console.Write("Ár (ha nincs, nyomjon Enter-t): ");
                string arInput = Console.ReadLine();

                double ar = string.IsNullOrEmpty(arInput) ? 3000 : double.Parse(arInput);  //ezt a részt AI segítségével sikerült megoldani :)
                konyvek[i] = new Konyv(cim, szerzo, oldalszam, ar);
            }
            foreach (var konyv in konyvek)
            {
                Console.WriteLine(konyv.ToString());
                Console.WriteLine($"Vastag könyv: {konyv.VastagKonyv()}");
                Console.WriteLine($"Drága könyv: {konyv.DragaKonyv()}");
            }
        }
    }
}
