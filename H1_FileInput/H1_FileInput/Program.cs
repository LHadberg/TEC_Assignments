using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H1_FileInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string sti = @"C:\Users\tec\Documents\TestEnviroment\TestDoc.txt";
            using (StreamReader sr = File.OpenText(sti))
            {
                string datafrafil = "";
                while ((datafrafil = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Data fra filen er: " + datafrafil);
                }
                Console.ReadLine();
            }   
        }
    }
}
