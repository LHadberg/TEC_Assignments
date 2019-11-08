using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_String_opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Original streng - Denne udskrives
            string s = "  Nu kan det da vist ikke gøres meget bedre  ";
            Console.WriteLine(s);
            //IndexOf finder indexpositionen for den valgte streng. Denne position returneres som en INT værdi.
            int det = s.IndexOf("det");
            Console.WriteLine("Indexpositionen af 'det' er: {0}",det);
            //Insert indsætter den følgende streng fra indexpositionen.
            string m = s.Insert(31, " ret");
            Console.WriteLine(m);
            //Remove fjerner et stykke streng. 
            //Det første tal er indexpositionen og det andet tal er hvor mange af de følgende cifre der slettes.
            string r = m.Remove(16, 5);
            Console.WriteLine(r);
            //Trim fjerner tomrum og dobbelt mellemrum. ToLower laver hele strengen lower-case.
            string ttl = r.Trim().ToLower();
            Console.WriteLine(ttl);
            //Char er en enkelt unicode karakter. Her vælger tegnet i den 17. indexposition og udskriver denne.
            char l = s[17];
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
