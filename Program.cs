using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace usingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("\n ------- Upisivanje podataka u datoteku...");

            using (StreamWriter sw = new StreamWriter(@"c:\prviDir\mojaDatoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }

            Console.WriteLine("\n ------- Čitanje podataka u datoteku...\n");

            using (StreamReader sr = new StreamReader(@"c:\prviDir\mojaDatoteka.txt"))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            Console.ReadKey();
        }
    }
}
