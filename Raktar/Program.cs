using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Raktar
{
    class Program
    {
        static List<Termek> lista = new List<Termek>();
        static void Main(string[] args)
        {
            beolvasRaktar();
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
    }
}
