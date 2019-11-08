using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machina
{
    class Program
    {
        static int UserGuess { get; set; }
        static void Main(string[] args)
        {
            Console.Write("Gæt et tal mellem 0- og 100.\nFørste forsøg: ");
            Møllen();
        }
        static public void Møllen()
        {
            bool løkke = true;
            while (løkke == true)
            {
                Random r = new Random();
                int rnd = r.Next(0, 100);
                int i = 1;
                Input();
                do
                {
                    if (UserGuess > rnd)
                    {
                        i++;
                        Console.Write("Desværre! Dit gæt var højere en tallet.\nPrøv igen: ");
                        UserGuess = Input();
                    }
                    if (UserGuess < rnd)
                    {
                        i++;
                        Console.Write("Desværre! Dit gæt var lavere en tallet.\nPrøv igen: ");
                        UserGuess = Input();
                    }
                } while (UserGuess != rnd);
                Console.WriteLine("Tillykke du gættede det rigtige tal! Det tog dig {0} forsøg.", i);
                Console.WriteLine("Tast en vilkårlig tast for at lukke programmet.");
                Console.ReadKey();
                løkke = false;
            }
        }
        private static int Input()
        {
            bool b = false;
            do
            {
                try
                {
                    UserGuess = Convert.ToInt32(Console.ReadLine());
                    b = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tegnet du indtastede stemmer ikke overens med den forventede type.");
                }
            } while (b != true); return UserGuess;
        }
    }
}