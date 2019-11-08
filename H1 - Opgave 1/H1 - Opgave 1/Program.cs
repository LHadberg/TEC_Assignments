using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace H1___Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            //Dette tillader ÆØÅ at blive skrevet i consollen.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Denne tillader ændren af consoltitlen.
            Console.Title = "Jankbot";

            //Følgende ændre programmets tekst- og baggrundsfarve.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.Write(@" ╔═══════════════════════════════════════════════════════════════════════════════╗
 ║ Vælg type af opgaver                                                          ║                                   
 ╠═════════════════════════════════════╦═════════════════════════════════════════╣
 ║ [1] - Navn & Alder                  ║ [3] - Gennemsnit                        ║
 ║ [2] - Adder                         ║                                         ║
 ╠═════════════════════════════════════╬═════════════════════════════════════════╣
 ║                                     ║    _                  _           _     ║
 ║ Esc - Lukke programmet              ║   | |    __ _ _______| |__   ___ (_)    ║
 ╠═════════════════════════════════════╣   | |   / _` |_  / _ \ '_ \ / _ \| |    ║
 ║                                     ║   | |__| (_| |/ /  __/ |_) | (_) | |    ║
 ║ Indtast Valg:                       ║   |_____\__,_/___\___|_.__/ \___/|_|    ║
 ╚═════════════════════════════════════╩═════════════════════════════════════════╝
 ");
            Console.SetCursorPosition(16, 10);
            ConsoleKeyInfo KeyPressed;
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: NavnOgAlder(); break;
                case ConsoleKey.D2: Adder(); break;
                case ConsoleKey.D3: Gennemsnit(); break;
                case ConsoleKey.Escape: Environment.Exit(0); break;
                default: Console.WriteLine("Du har tastet forkert."); Thread.Sleep(800); break;
            }
            Menu();
        }
        static void NavnOgAlder()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                String enterName = "";
                int enterAge = 0;
                Console.Write("Please enter your name...\n");
                enterName = Console.ReadLine();
                Console.Clear();
                bool trueFalse = true;
                while (trueFalse == true)
                {
                    Console.Write("Please enter your age...\n");
                    try
                    {
                        enterAge = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        Console.Write("You have entered a correct format.\n\nYour name is {0} and you seem to be {1} year(s) old.\nGood on you if you're 1 and understand this", enterName, enterAge);
                        trueFalse = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your input is incorrectly formatted.. Numbskull\nPress any key to try again...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Menu();
            }
        }
        static void Adder()
        {
            Console.Clear();
            double num1, num2, num3;
            Console.Write("Please enter the first number...\n");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Please enter the second number...\n");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                num3 = num1 + num2;
                Console.WriteLine("The sum of your two numbers is {0}", num3);
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Menu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Your input is incorrectly formatted.. Numbskull\nPress any key to try again...");
                Console.ReadKey();
            }
        }
        static void Gennemsnit()
        {
            Console.Clear();
            double num1, num2, num3, num4;
            Console.Write("Please enter the first number...\n");

            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Please enter the first number...\n");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Please enter the second number...\n");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                num4 = (num1 + num2 + num3) / 3;
                Console.WriteLine("The sum of your two numbers is {0}", num3);
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Menu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Your input is incorrectly formatted.. Numbskull\nPress any key to try again...");
                Console.ReadKey();
            }
        }

    }
}
