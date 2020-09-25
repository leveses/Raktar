using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Diagnostics;

namespace Raktar
{
    class Program
    {
        static List<Megrendelesek> rendeles = new List<Megrendelesek>();
        static List<Termek> lista = new List<Termek>();
        static void Main(string[] args)
        {
            /*beolvasRaktar();
            foreach (var i in lista)
            {
                Console.WriteLine(i.NEV);
            }*/
            beolvasRendeles();
            foreach (var f in rendeles)
            {
                Console.WriteLine(f.DATUM + " " + f.RENDELESSZAM + " " + f.EMAIL);
            }
            Console.ReadKey();
        }
        static void beolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                //sor[0] -> kód
                //sor[1] -> név...
                string[] sor = raktar.ReadLine().Split(';');
                lista.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }
            raktar.Close();
        }
        static void beolvasRendeles()
        {
            StreamReader megrendeles = new StreamReader("rendeles.csv");
            while (!megrendeles.EndOfStream)
            {
                string adat = megrendeles.ReadLine();
                string[] sor = adat.Split(';');
                if (sor[0] == "M")
                {
                    rendeles.Add(new Megrendelesek(sor[1], int.Parse(sor[2]), sor[3]));
                }
                else
                {
                    //rendeles[rendeles.Count - 1].tetelek.Add(adat);
                    rendeles[rendeles.Count - 1].TetelHozzaad(sor[2], int.Parse(sor[3]));
                }
            }
            megrendeles.Close();
        }
    }
}
