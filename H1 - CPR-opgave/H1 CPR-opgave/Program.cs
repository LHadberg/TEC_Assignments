using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_CPR_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            bool løkke = true;
            while (løkke == true)
            {
                string cpr;
                Console.WriteLine("Indsast venligst dit CPR nummer i følgende format DDMMYY-xxxx");
                cpr = Console.ReadLine();
                int index = cpr.IndexOf("-");
                int tjek = cpr.ToString().Length;
                string[] cprsplit = cpr.Split('-');
                bool ertal1 = cprsplit[0].All(char.IsDigit);
                bool ertal2 = cprsplit[1].All(char.IsDigit);
                int d, m, y;
                bool t = false;
                while (t != true || ertal1 != true || ertal2 != true || index != 6 || tjek != 11)
                {
                    try
                    {
                        index = cpr.IndexOf("-");
                        tjek = cpr.ToString().Length;
                        cprsplit = cpr.Split('-');
                        ertal1 = cprsplit[0].All(char.IsDigit);
                        ertal2 = cprsplit[1].All(char.IsDigit);
                        d = int.Parse(cprsplit[0]) % 100;
                        m = (int.Parse(cprsplit[0]) / 100) % 100;
                        y = int.Parse(cprsplit[0]) / 10000;
                        DateTime result = new DateTime(d, m, y);
                        t = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Din indtastning er ikke korrekt. Prøv igen: ");
                        cpr = Console.ReadLine();
                    }

                }
                int køn = cpr[cpr.Length - 1] % 2;
                if (køn == 1)
                {
                    Console.WriteLine("Nitten... Du er en mand.");
                }
                else
                {
                    Console.WriteLine("Du er en kvinde... Tillykke");
                }
                Console.WriteLine("Tryk på en vilkårlig tast for at fotsætte.\nTast 'Escape' for at stoppe");
                ConsoleKeyInfo valg;
                valg = Console.ReadKey();
                Console.Clear();
                if (valg.Key == ConsoleKey.Escape)
                {
                    løkke = false;
                }
            }
        }
    }
}
