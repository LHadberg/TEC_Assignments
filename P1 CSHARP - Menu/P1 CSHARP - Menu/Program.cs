using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace P1_CSHARP___Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dette er vores Main string der går ind i det static void der er dedikeret til hovedmenuen.
            Menu();
        }

        private static void Menu()
        {
            //Denne private static void er hovedmenuen. Den skal agere som samlingspunkt for resten af opgaverne.

            //Dette tillader ÆØÅ at blive skrevet i consollen.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Denne tillader ændren af consoltitlen.
            Console.Title = "Hovedmenu";

            //Følgende ændre programmets tekst- og baggrundsfarve.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.Write(@" ╔═══════════════════════════════════════════════════════════════════════════════╗
 ║ Vælg type af opgaver                                                          ║                                   
 ╠═════════════════════════════════════╦═════════════════════════════════════════╣
 ║ [1] - Variabler                     ║ [Q] - Returtyper og parametre           ║
 ║ [2] - Strings                       ║ [W] - Instancevariabler                 ║
 ║ [3] - Aritmetiske udtryk            ║ [E] - Nedarvning                        ║
 ║ [4] - Variabler i udtryk            ║ [R] - Konstruktors                      ║    
 ║ [5] - Boolske variable              ║ [T] - Arrays                            ║
 ║ [6] - If else statements            ║ [Y] - Gennemløb af arrays               ║    
 ║ [7] - Switch case                   ║ [U] - Public, Private og Protected      ║
 ║ [8] - Loops                         ║                                         ║
 ║ [9] - Udvidet kontrolstrukturer     ║ Husk du kan læse titlen af programmet   ║
 ║ [0] - Metoder og Instanser          ║ for at finde ud af hvor du er           ║
 ╠═════════════════════════════════════╬═════════════════════════════════════════╣
 ║                                     ║    _                  _           _     ║
 ║ Esc - Lukke programmet              ║   | |    __ _ _______| |__   ___ (_)    ║
 ╠═════════════════════════════════════╣   | |   / _` |_  / _ \ '_ \ / _ \| |    ║
 ║                                     ║   | |__| (_| |/ /  __/ |_) | (_) | |    ║
 ║ Indtast Valg:                       ║   |_____\__,_/___\___|_.__/ \___/|_|    ║
 ╚═════════════════════════════════════╩═════════════════════════════════════════╝
 ");
            Console.SetCursorPosition(16, 18);

            //Vi initialisere en consolekeyinfo variabel for at gøre menuen glattere kørende.
            ConsoleKeyInfo KeyPressed;
            KeyPressed = Console.ReadKey(true);

            //Denne switch case skal sammen med ovenstående consolekeyinfo lave menuen interaktiv og gøre det muligt at bevæge sig til nedenstående private static voids.
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: Var(); break;
                case ConsoleKey.D2: Strings(); break;
                case ConsoleKey.D3: Aritmetiske(); break;
                case ConsoleKey.D4: VarUd(); break;
                case ConsoleKey.D5: BoolskeVar(); break;
                case ConsoleKey.D6: IfElse(); break;
                case ConsoleKey.D7: Switch(); break;
                case ConsoleKey.D8: Loop(); break;
                case ConsoleKey.D9: UdKon(); break;
                case ConsoleKey.D0: MetIn(); break;
                case ConsoleKey.Q: RetPa(); break;
                case ConsoleKey.W: InsVar(); break;
                case ConsoleKey.E: NedArv(); break;
                case ConsoleKey.R: ConSt(); break;
                case ConsoleKey.T: Arr(); break;
                case ConsoleKey.Y: GenArr(); break;
                case ConsoleKey.U: PPP(); break;
                case ConsoleKey.Escape: Environment.Exit(0); break;
                default: Console.WriteLine("Du har tastet forkert."); Thread.Sleep(800); break;
            }
            //I slutningen af alle voids går vi til hovedmenuen
            Menu();
        }

        private static void Var()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Variabel-opgaverne";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║ [3] - Opgave 3                      ║
 ║ [4] - Opgave 4                      ║
 ║ [5] - Opgave 5                      ║
 ║ [6] - Opgave 6                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: VarOpg1(); break;
                case ConsoleKey.D2: VarOpg2(); break;
                case ConsoleKey.D3: VarOpg3(); break;
                case ConsoleKey.D4: VarOpg4(); break;
                case ConsoleKey.D5: VarOpg5(); break;
                case ConsoleKey.D6: VarOpg6(); break;
                case ConsoleKey.UpArrow: PPP(); break;
                case ConsoleKey.DownArrow: Strings(); break; //Du har muligheden for at bevæge sig til næste eller forrige void ved hjælp af piltasterne. Denne eksistere i hver void.
                case ConsoleKey.Escape: Menu(); break;//Giver muligheden for at lukke programmet ned ved at taste 'Escape'
            }

            Var();
        }
        private static void VarOpg1()
        {
            Console.Clear();
            double tal1 = 5; //Her initializes en variabel af typen Double
            double tal2 = 3;

            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
            Console.Read();
            Var();
        }
        private static void VarOpg2()
        {
            Console.Clear();
            double tal1 = 5;
            double tal2 = 3;

            Console.WriteLine("Tal1 er " + tal1);
            Console.WriteLine("tal2 er " + tal2);
            Console.Read();
            Var();

        }
        private static void VarOpg3()
        {
            Console.Clear();
            string userName = "Søren";
            double userAge = 16;
            float userMoney = 1234.34f;
            Console.WriteLine("Jeg hedder " + userName + ", er " + userAge + " år gammel og har tjent " + userMoney + " kr. på at lappe cykler.");
            Console.Read(); //Det er muligt at skrive en sætning og samtidig tilføje variablers værdi til denne. 
            Var();
        }
        private static void VarOpg4()
        {
            Console.Clear();
            double kage = 23.56;
            double øl = 34.67;
            double pølse = 65.34;
            double total = (kage + øl + pølse); //Du kan lave regnestykker og skrive resultatet til en variabel der kan bruges på et senere tidspunkt.

            Console.WriteLine(@"Kage " + kage + "\nØl  " + øl + "\nPølse " + pølse + "\nTotal: " + total);
            Console.Read();
            Var();
        }
        private static void VarOpg5()
        {
            Console.Clear();
            string userName;
            byte userAge;
            Console.WriteLine("Indtast venligst dit navn: ");
            userName = Console.ReadLine();
            Console.WriteLine("Indtast venligst din alder: ");
            userAge = Convert.ToByte(Console.ReadLine()); //Bruger input gives i int form. Derfor skal der konverteres til det rette format.
            Console.WriteLine("Jeg hedder " + userName + " og er " + userAge + " år gammel.");
            Console.Read();
            Var();
        }
        private static void VarOpg6()
        {
            Console.Clear();
            double radius;
            double pi = Math.PI; //Math.PI metoden indeholder værdien af pi. Ved at gemme denne i en variabel kan vi nedenfor bruge PI i en ligning.
            Console.Write("Du vil gerne udregne arealet af en cirkel.\nIndtast venligst cirklens radius i cm:");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Arealet af cirklen er: " + Math.Pow(radius, 2) * pi + "cm^2"); //Math.Pow allows you to calculate a variable to the power of whichever you entered.
            Console.ReadKey();
            Var();
        }

        private static void Strings()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til String-opgaverne";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║ [3] - Opgave 3                      ║
 ║ [4] - Opgave 4                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: StringsOpg1(); break;
                case ConsoleKey.D2: StringsOpg2(); break;
                case ConsoleKey.D3: StringsOpg3(); break;
                case ConsoleKey.D4: StringsOpg4(); break;
                case ConsoleKey.UpArrow: Var(); break;
                case ConsoleKey.DownArrow: Aritmetiske(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Strings();
        }
        private static void StringsOpg1()
        {
            Console.Clear();
            int userAge = 42;
            string userName = "Bente Bent";
            double userSalary = 123.456;

            Console.Write(userAge + "\n" + userName + "\n" + userSalary); // \n går til en ny linje.
            Console.ReadKey();
        }
        private static void StringsOpg2()
        {
            Console.Clear();
            int userAge = 42;
            string userName = "Bente Bent";
            double userSalary = 123.456;
            userAge = 24;
            userName = "Bent Bente";
            userSalary = 654.321;
            Console.Write("\n" + userAge + "\n" + userName + "\n" + userSalary);
            Console.ReadKey();
            Strings();
        }
        private static void StringsOpg3()
        {
            Console.Clear();
            string variabel = "I dag har vi den 24. December";
            Console.Write(variabel);
            Console.ReadKey();
            Strings();
        }
        private static void StringsOpg4()
        {
            Console.Clear();
            double userCash = 200.50;
            string userHas = "Jeg har";
            string userBank = "kr. i banken";
            Console.Write(userHas + " " + userCash + userBank);
            Console.ReadKey();
            Strings();
        }

        private static void Aritmetiske()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Aritmetik-opgaverne";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: AritOpg1(); break;
                case ConsoleKey.UpArrow: Strings(); break;
                case ConsoleKey.DownArrow: VarUd(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Aritmetiske();
        }
        private static void AritOpg1()
        {
            Console.Clear();
            double gange = 2 + 1 * 2;
            double parantes = (2 + 1) * 2;
            double division = 5d / 2d;
            double modulus = 8 % 3;
            double minus = 1 - 5;
            Console.Write(gange + "\n" + parantes + "\n" + division + "\n" + modulus + "\n" + minus); //Alle regnestykkerne der udregnes ovenfor udskrives på hver sin linje. 
            Console.ReadKey();
            Aritmetiske();
        }

        private static void VarUd()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Variabler i udtryk";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: VarUdOpg1(); break;
                case ConsoleKey.D2: VarUdOpg2(); break;
                case ConsoleKey.UpArrow: Aritmetiske(); break;
                case ConsoleKey.DownArrow: BoolskeVar(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Strings();
        }
        private static void VarUdOpg1()
        {
            Console.Clear();
            int var1 = 5;
            int var2 = 7;
            int var3 = 11;
            int result;
            result = (var1 * var2 / var1 + var3 % var1);
            Console.Write(result);
            Console.ReadKey();
            VarUd();
        }
        private static void VarUdOpg2()
        {
            Console.Clear();
            int userSalary = 25;
            int userDebt = -10;
            int userSavings = 20;
            int result;
            result = (userDebt + 5 + userSalary * 14 - userSavings * 14); //Ligningen udregnes med de fastlagte værdier. Resultatet gemmes i 'result'
            Console.Write(result); //'result' udskrives.
            Console.ReadKey();
            VarUd();
        }

        private static void BoolskeVar()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Variabler";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║ 
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: BoolOpg1(); break;
                case ConsoleKey.UpArrow: VarUd(); break;
                case ConsoleKey.DownArrow: IfElse(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            BoolskeVar();
        }
        private static void BoolOpg1()
        {
            Console.Clear();
            int var1 = 202;
            int var2 = 1200;
            bool value = var1 > var2; //En booleansk værdi bruges til at fastlægge om et udsagn er korrekt(Sand/falsk)
            Console.Write(value);
            Console.ReadKey();
            BoolskeVar();
        }

        private static void IfElse()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til If-else Opgaver";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║ [3] - Opgave 3                      ║
 ║ [4] - Opgave 4                      ║
 ║ [5] - Opgave 5                      ║
 ║ [6] - Opgave 6                      ║
 ║ [7] - Opgave 7                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: IfElseOpg1(); break;
                case ConsoleKey.D2: IfElseOpg2(); break;
                case ConsoleKey.D3: IfElseOpg3(); break;
                case ConsoleKey.D4: IfElseOpg4(); break;
                case ConsoleKey.D5: IfElseOpg5(); break;
                case ConsoleKey.UpArrow: BoolskeVar(); break;
                case ConsoleKey.DownArrow: Switch(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Strings();
        }
        private static void IfElseOpg1()
        {
            Console.Clear();
            int tal1;
            int tal2;
            int result;
            tal1 = 42;
            tal2 = 64;
            result = (tal1 + tal2);
            if (result > 100) //hvis resultatet af det ovenstående regnestykke er større end 100 vil programmet køre gennem koden i denne 'if'
            {
                Console.Write("Summen er større en 100!");
            }
            else if (result < 100) //Hvis resultatet er mindre ser den bort fra ovenstående kode og kører i stedet denne.
            {
                Console.Write("Summen er mindre end 100.");
            }
            else //Hvis ingen af de ovenstående udsagn er korrekte vil programmet som default køre dette stykke kode.
            {
                Console.Write("Summen er 100");
            }
            Console.ReadKey();
            IfElse();
        }
        private static void IfElseOpg2()
        {
            Console.Clear();
            byte userAge;
            Console.Write("Indtast venligst din alder: ");
            userAge = Convert.ToByte(Console.ReadLine());
            if (userAge > 57) //Et if-else statement kan bruges til at udføre en handling afhængig af et input. Hvis 'if' delens condition bliver mødt, ignorere den 'else-if' og 'else'.
            {
                Console.Write("Du er for gammel..");
            }
            else
            {
                Console.Write("Du er ikke for gammel..");
            }
            Console.ReadKey();
            IfElse();
        }
        private static void IfElseOpg3()
        {
            Console.Clear();
            byte userAge;
            Console.Write("Indtast venligst din alder:");
            userAge = Convert.ToByte(Console.ReadLine()); //Jeg illustrere brugen af 'Byte' integraltypen for at vise denne kan bruges i et begrænset omfang. 
            if (userAge > 60) //Denne er gyldig da et menneskes alder højest sansynligt ikke overstiger 255.
            {
                Console.Write("Du er for gammel");
            }
            else if (userAge >= 50)
            {
                Console.Write("Du er hverken for gammel eller for ung");
            }
            else
            {
                Console.Write("Du er for ung.");
            }
            Console.ReadKey();
            IfElse();
        }
        private static void IfElseOpg4()
        {
            Console.Clear();
            string userName;
            string userAccount = "Yoshicide";
            string userPass = "Pass1234";
            string userAccount2;
            string userPass2;
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Clear();
            Console.Write("Please enter your account name ");
            userAccount2 = Console.ReadLine();
            Console.Clear();
            Console.Write("Please enter your chosen password. ");
            userPass2 = Console.ReadLine();
            Console.Clear();

            if (userAccount == userAccount2 && userPass == userPass2) //Brugerinputtet sammenlignes med de gemte værdier. Hvis begge sammenligninger matcher vil dette stykke udskrives.
            {
                Console.WriteLine(" Welcome, " + userName + "!");
            }
            else // Hvis bare en enkelt ikke matcher, vil du få at vide at én af dine entries er forkerte.
            {
                Console.Write("Brugernavn eller password er forkert.");
            }
            Console.ReadKey();
            IfElse();
        }
        private static void IfElseOpg5()
        {
            Console.Clear();
            string userName;
            string userAccount = "Yoshicide";
            string userPass = "Pass1234";
            string userAccount2;
            string userPass2;
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Clear();

            Console.Write("Please enter your account name: ");
            userAccount2 = Console.ReadLine();
            Console.Clear();
            if (userAccount == userAccount2)//I modsætning til forrige opgave sammenligner denne først dit indtastedebrugernavn, hvis denne matcher vil du have mulighed for at taste koden.
            {
                Console.Write("Please enter your password: ");
                userPass2 = Console.ReadLine();
                Console.Clear();

                if (userPass == userPass2)
                {
                    Console.WriteLine("Welcome, " + userName);
                }
                else
                {
                    Console.WriteLine("The password you entered is wrong.");
                }
            }
            else //Hvis brugernavnet ikke matcher vil du blive givet besked, og har derved ikke mulighed for at taste din kode.
            {
                Console.WriteLine("The account name you entered is wrong.");
            }
            Console.ReadKey();
            IfElse();
        }
        private static void IfElseOpg6()
        {
            Console.Clear();
            double userDistance;


            Console.Write("Hvor mange kilometer kører du sammenlagt til og fra arbejde?\n");
            userDistance = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (userDistance <= 24)
            {
                Console.WriteLine("Du får ikke noget fradrag.");
                Console.ReadKey();
            }
            else if (userDistance >= 25)
            {
                Console.WriteLine("Du får " + (userDistance - 24) * 1.93 + "kr. i befordringsfradrag.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Du får " + 96 * 1.93 + (userDistance - 120) * 0.97 + "kr. pr. dag.");
                Console.ReadKey();
                IfElse();
            }

        }
        private static void IfElseOpg7()
        {
            Console.Clear();

            IfElse();
        }

        private static void Switch()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Variabler";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: SwitchOpg1(); break;
                case ConsoleKey.D2: SwitchOpg2(); break;
                case ConsoleKey.UpArrow: IfElse(); break;
                case ConsoleKey.DownArrow: Loop(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
        }
        private static void SwitchOpg1()
        {
            Console.Clear();
            Console.Write("Indtast et tal fra 1-6:");

            ConsoleKeyInfo Keypressed;
            Keypressed = Console.ReadKey(true);
            Console.Clear();
            switch (Keypressed.Key) //Denne switchcase får dig til at indtaste et tal mellem 1 og 6. tastes 4 har du 'vundet'. Tastes et tal over 6 eller et andet tegn vil du blive givet besked. 
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Du har indtastet tallet {0}", 1);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Du har indtastet tallet {0}", 2);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Du har indtastet tallet {0}", 3);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.SetCursorPosition(48, 16);
                    Console.WriteLine("TILLYKKE DU HAR VUNDET!");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Du har indtastet tallet {0}", 5);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Du har indtastet tallet {0}", 6);
                    Console.ReadKey();
                    break;
                default: //Hvis ingen af de ovenstående switch-case entries imødekommes vil programmet udskrive dets 'default'. I dette tilfælde er det en fejlbesked.
                    Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6.");
                    Thread.Sleep(10000);
                    Environment.Exit(0);
                    break;
            }
            SwitchOpg1();
        }
        private static void SwitchOpg2()
        {
            Console.Clear();
            Console.CursorVisible = false; //Gør cursoren usynlig, da der bruges et 'X' i stedet.
            double[] userPrices = new double[] { 95, 55, 120, 105, 70, 10, 420 }; //Dette er priser der udskrives senere sammen med den valgte drink.
            //Et double array, hvor hver entry i rækken oprettes og bliver tildelt en double værdi. Det første entry (95) har array placeringen[0], det næste [1] osv.
            string[] userDrinks = new string[] { "Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur", "Red Rum" }; //Ligeledes tildeles hver arrayentry en string værdi.
            string userChosenDrink = ""; //Denne efterlades blank da den bruges til at checke før brugerinput
            int coordX; //X- og Y-koordinaterne skal bruges til at sætte cursorposition. 
            int coordY;

            ConsoleKey KeyPressed;

            foreach (var item in userDrinks) //For hver entry i arrayet vil dette foreach loop skrives et '[ ]' Denne bruges som rammen 'X'et skrives i. 'item' oprettes samtidig.
            {
                Console.Write("[ ] ");
                Console.WriteLine(item);
            }

            Console.SetCursorPosition(1, 0);
            SetPos(); //Denne metode kaldes på flere gange. Den bruges til at finde positionere cursoren for at finde placeringen til det næste 'X' der skal skrives.
            Console.Write("X");
            Console.SetCursorPosition(coordX, coordY); //Her sættes cursoren på de koordinater der er returneret fra 'SetPos' metoden.

            while (userChosenDrink == "") //Så længe at 'userChosenDrink' har en 'null' værdi, vil den brugerdefinerede cursor være aktiv.
            {
                KeyPressed = Console.ReadKey(true).Key;
                if (KeyPressed == ConsoleKey.DownArrow)
                {
                    SetPos();
                    Console.Write(" "); //Skriver et 'mellemrum'. Dette er for at slette det tidligere placerede 'X'. 
                    Console.SetCursorPosition(coordX, coordY);
                    if (Console.CursorTop == userDrinks.Length - 1) //Hvis Y positionen er den sidste i arrayet vil cursoren gå til det første entry, altså tilbage til første række. 
                    {                                               //Ydermere, hvis arrayet udviddes vil denne ikke skulle ændres, da det ikke er efter et statisk antal linjer.
                        Console.SetCursorPosition(1, 0);
                        SetPos();
                        Console.Write("X");
                        Console.SetCursorPosition(coordX, coordY);
                    }
                    else
                    {
                        Console.SetCursorPosition(1, Console.CursorTop + 1); //Hvis det ikke er den sidste entry vil programmet pr. default bevæge sig én linje ned.
                        SetPos();
                        Console.Write("X");
                        Console.SetCursorPosition(coordX, coordY);
                    }
                }
                else if (KeyPressed == ConsoleKey.UpArrow)
                {
                    SetPos();
                    Console.Write(" ");
                    Console.SetCursorPosition(coordX, coordY);
                    if (Console.CursorTop == 0)
                    {
                        Console.SetCursorPosition(1, userDrinks.Length - 1); //Hvis du fra første entry forsøger at gå op vil du blive sendt til sidste entry i arrayet.
                        SetPos();
                        Console.Write("X");
                        Console.SetCursorPosition(coordX, coordY);
                    }
                    else
                    {
                        Console.SetCursorPosition(1, Console.CursorTop - 1); //Her bevæges der opad i array entries.
                        SetPos();
                        Console.Write("X");
                        Console.SetCursorPosition(coordX, coordY);
                    }
                }
                else if (KeyPressed == ConsoleKey.Enter) //Trykkes der 'Enter' i stedet for benyttelse af piltasterne vælges der en drink.
                {
                    userChosenDrink = userDrinks[coordY]; //Værdien i arrayet skrives til 'userChosenDrink' afhængig af hvilken entry i dit array du er.
                    Console.SetCursorPosition(0, userDrinks.Length + 1); //For at holde dynamisk udviddelse i menuen lægger vi 1 til antallet af entries og skriver derefter den relevante tekst.
                    Console.Write("Du har valgt en " + userChosenDrink + ", den koster " + userPrices[coordY] + "kr.-");
                }
            }
            Console.ReadKey(true);
            void SetPos() //Dette er den metode der kaldes på for at ændre placering. 'CursorLeft' er cursorens position på Y-aksen og 'CursorTop' er dens position på X-aksen
            {
                coordX = Console.CursorLeft;
                coordY = Console.CursorTop;
            }
            Switch();
        }

        private static void Loop()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Loopopgaverne";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║ [3] - Opgave 3                      ║
 ║ [4] - Opgave 4                      ║
 ║ [5] - Opgave 5                      ║
 ║ [6] - Opgave 6                      ║
 ║ [7] - Opgave 7                      ║
 ║ [8] - Opgave 8                      ║
 ║ [9] - Opgave 9                      ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: LoopOpg1(); break;
                case ConsoleKey.D2: LoopOpg2(); break;
                case ConsoleKey.D3: LoopOpg3(); break;
                case ConsoleKey.D4: LoopOpg4(); break;
                case ConsoleKey.D5: LoopOpg5(); break;
                case ConsoleKey.D6: LoopOpg6(); break;
                case ConsoleKey.D7: LoopOpg7(); break;
                case ConsoleKey.D8: LoopOpg8(); break;
                case ConsoleKey.D9: LoopOpg9(); break;
                case ConsoleKey.UpArrow: Switch(); break;
                case ConsoleKey.DownArrow: UdKon(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Loop();
        }
        private static void LoopOpg1()
        {
            //Her illustreres hvordan du med While of For loop kan tælle til 1+ på 2 forskellige måder.
            Console.Clear();
            int i = 1;
            Console.Write("While loop:");

            while (i < 11) //Imens 'i' er mindre end 11 vil koden inden for nedenstående parametre blive executed. Den stopper hvis udsagnet i næste instans ville være falsk.
            {
                Console.Write("\n" + i++);
                Thread.Sleep(500);
            }
            Console.WriteLine("\nFor loop.");
            if (i > 9) 
                for (int o = 1; o < 11; o++)
                {
                    Console.WriteLine(o);
                    Thread.Sleep(500);
                }
            Console.ReadKey();
            Loop();
        }
        private static void LoopOpg2()
        {
            Console.Clear();
            int i = 100;
            Console.Write("While loop:");

            while (i > 0)
            {
                Console.Write("\n" + i--);
                Thread.Sleep(100);
            }
            Console.WriteLine("\nFor loop.");
            if (i < 2)
                for (int o = 100; o > 0; o--)
                {
                    Console.WriteLine(o);
                    Thread.Sleep(100);
                }
            Console.ReadKey();
            Loop();
        }
        private static void LoopOpg3()
        {
            Console.Clear();
            int[] userNumber = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 }; // Der oprettes et int array med navnet userNumber. Her sættes værdierne til hvert array element.
            for (int i = 0; i < userNumber.Length; i++) //For hvert element i vores array skrives en writeline med den tilsvarende værdi.
            {
                Console.WriteLine(userNumber[i]);
            }
            Console.ReadLine();
            Loop();
        }
        private static void LoopOpg4()
        {
            Console.Clear();
            int i = 20;
            Console.Write("While loop:");

            while (i > 0)
            {
                Console.Write("\n" + i--);
                Thread.Sleep(100);
            }
            Console.WriteLine("\nFor loop.");
            if (i < 2)
                for (int o = 20; o > 0; o--)
                {
                    Console.WriteLine(o);
                    Thread.Sleep(100);
                }
            Console.ReadKey();
            Loop();
        }
        private static void LoopOpg5()
        {
            Console.Clear();
            int[] userNumber = { 0, 7, 14, 21, 28, 35, 42, 49, 56, 63, 70 };
            for (int i = 0; i < userNumber.Length; i++)
            {
                Console.WriteLine(i + "\t*\t7\t=\t" + userNumber[i]); //Her benyttes \t til at benytte tabulator egenskaben. Dette gøres for at få teksten i et ens format.
            }
            Console.ReadLine();
            Loop();
        }
        private static void LoopOpg6()
        {
            Console.Clear();
            int userInput;
            int userLength;
            Console.Write("Indtast et tal for den tabel du ønsker: ");
            userInput = Convert.ToInt16(Console.ReadLine());
            Console.Write("Indtast et tal for længden du ønsker på din tabel: ");
            userLength = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < userLength + 1; i++)
            {
                int result = i * userInput;
                Console.WriteLine("{0,2} * {1,1} = {2,2}", i, userInput, result);

            }
            Console.ReadLine();
            Loop();
        }
        private static void LoopOpg7()
        {
            // I nedenstående forloop tegnes en ramme hvis størrelse dikteres af koden. Derefter tegnes hjørnerne. I dette eksempel er der brugt ASCII kode.
            Console.Clear();
            for (int i = 21; i < 30; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("═");
                Console.SetCursorPosition(i, 13);
                Console.Write("═");
                Console.SetCursorPosition(20, i - 17);
                Console.Write("║");
                Console.SetCursorPosition(30, i - 17);
                Console.Write("║");
            }
            Console.SetCursorPosition(20, 4);
            Console.Write("╔");

            Console.SetCursorPosition(30, 13);
            Console.Write("╝");

            Console.SetCursorPosition(20, 13);
            Console.Write("╚");

            Console.SetCursorPosition(30, 4);
            Console.WriteLine("╗");
            Console.ReadKey();
            Loop();
        }
        private static void LoopOpg8()
        {
            //Der tegnes en ramme på samme måde som i ovenstående projekt. Her tilføjes der et navn til midten af kassen ved brug af faste koordinater.
            Console.Clear();
            for (int i = 21; i < 30; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("═");
                Console.SetCursorPosition(i, 13);
                Console.Write("═");
                Console.SetCursorPosition(20, i - 17);
                Console.Write("║");
                Console.SetCursorPosition(30, i - 17);
                Console.Write("║");
            }
            Console.SetCursorPosition(20, 4);
            Console.Write("╔");

            Console.SetCursorPosition(30, 13);
            Console.Write("╝");

            Console.SetCursorPosition(20, 13);
            Console.Write("╚");

            Console.SetCursorPosition(30, 4);
            Console.WriteLine("╗");
            Console.SetCursorPosition(23, 8);
            Console.Write("Laze");
            Console.ReadKey();
            Loop();
        }
        private static void LoopOpg9()
        {
            Console.Clear();
            int x, y;
            Console.WriteLine("Indtast venligst dit navn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Indtast den ønskede højde på rammen");
            y = Convert.ToInt32(Console.ReadLine()); //Der indtastes brugerdefinerede X- og Y koordinater. 
            Console.WriteLine("Indtast den ønskede bredde på rammen");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int y1 = 0; y1 < y; y1++) //Dette loop skriver de vertikale linjer og stopper når den brugerdefinerede størrelse er nået.
            {
                Console.SetCursorPosition(0, y1 + 1);
                Console.Write("║");
                Console.SetCursorPosition(x, y1 + 1);
                Console.Write("║");
            }
            for (int x1 = 0; x1 < x; x1++)//Dette loop skriver de horisontale linjer og stopper når den brugerdefinerede størrelse er nået.
            {
                Console.SetCursorPosition(x1 + 1, 0);
                Console.Write("═");
                Console.SetCursorPosition(x1 + 1, y);
                Console.Write("═");
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");

            Console.SetCursorPosition(x, y);
            Console.Write("╝");

            Console.SetCursorPosition(0, y);
            Console.Write("╚");

            Console.SetCursorPosition(x, 0);
            Console.WriteLine("╗");
            Console.SetCursorPosition(x / 2 - 2, y / 2); // Da selve rammen er dynamisk skal placeringen også være det. Vi dividere koortinaterne med 2 for at få midten. 
            Console.Write(userName); // For bedre at centrere teksten har jeg valgt at trække 2 fra x-koordinatet.
            Console.ReadKey();
            Loop();
        }

        private static void UdKon()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Udvidet kontrolstruktur";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║ [3] - Opgave 3                      ║
 ║ [4] - Opgave 4                      ║
 ║ [5] - Opgave 5                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: UdKonOpg1(); break;
                case ConsoleKey.D2: UdKonOpg2(); break;
                case ConsoleKey.D3: UdKonOpg3(); break;
                case ConsoleKey.D4: UdKonOpg4(); break;
                case ConsoleKey.D5: UdKonOpg5(); break;
                case ConsoleKey.UpArrow: Loop(); break;
                case ConsoleKey.DownArrow: MetIn(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            UdKon();
        }
        private static void UdKonOpg1()
        {
            Console.Clear();
            for (int i = 0; i < 11; i++)
            {
                int result = (i * 3);
                Console.WriteLine(result);
                if (result == 21)
                {
                    Console.WriteLine("Loopen er nu stoppet");
                    Console.ReadKey();
                    break;
                }

            }
            Console.ReadKey();
            UdKon();
        }
        private static void UdKonOpg2()
        {
            Console.Clear();
            int i = 0;
            while (i < 10)
            {
                i++;
                int result = i * 4;

                if (result == 16)
                {
                    continue;
                }

                Console.WriteLine(result);
            }
            Console.ReadKey();
            UdKon();
        }
        private static void UdKonOpg3()
        {
            Console.Clear();
            double userDistance;


            Console.Write("Hvor mange kilometer kører du sammenlagt til og fra arbejde?\n");
            userDistance = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (userDistance <= 24)
            {
                Console.WriteLine("Du får ikke noget fradrag.");
                Console.ReadKey();
            }
            else if (userDistance >= 25 && userDistance < 100)
            {
                Console.WriteLine("Du får " + (userDistance - 24) * 1.54 + "kr. i befordringsfradrag.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Du får " + 96 * 1.93 + (userDistance - 120) * 0.77 + "kr. pr. dag.");
                Console.ReadKey();
                UdKon();
            }

        }
        private static void UdKonOpg4()
        {
            Console.Clear();
            double userIncome;
            Console.WriteLine("Indtast din indkomst: ");
            userIncome = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (userIncome < 42000)
            {
                Console.WriteLine("Du skal ikke betale skat, da din indkomst er under 42.000kr.");
                Console.ReadLine();
            }
            if (userIncome > 42000 && userIncome < 280000)
            {
                double userOutcome = userIncome * 0.3;
                Console.WriteLine("Du skal betale en bundskat på 30%. Din indkomst efter skat er {0}kr.", userOutcome);
                Console.ReadLine();
            }
            if (userIncome > 280000 && userIncome < 390000)
            {
                double userOutcome = userIncome * 0.36;
                Console.WriteLine("Du skal betale mellemskat på yderligere 6%. Din indkomst efter skat er {0}kr.", userOutcome);
                Console.Clear();
            }
            else
            {
                double userOutcome = userIncome * 0.51;
                Console.WriteLine("Du skal betale en yderligere topskat på 15%. Du har betalt  {0}kr.", userOutcome);
                Console.Clear();
                UdKon();
            }

        }
        private static void UdKonOpg5()
        {
            Console.Clear();
            double userInput;
            double rente;
            Console.Write("Indtast hvor mange penge du har på din konto: ");
            userInput = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (userInput < 25000 && userInput > 1)
            {
                rente = (userInput * 0.25) / 100;
                Console.Write("Du vil få {0:0.00} udbetalt i rente i slutningen af året.", rente); //{0:0.00} formateringen bruges til at sltte antallet af decimaler der udskrives til 2.
                Console.ReadKey();
            }
            if (userInput >= 25000 && userInput < 150000)
            {
                rente = (userInput * 1.25) / 100;
                Console.Write("Du vil få {0:0.00} udbetalt i rente i slutningen af året.", rente);
                Console.ReadKey();
            }
            if (userInput >= 150000)
            {
                rente = (150000 * 1.25 / 100) + (userInput - 150000) * 0.5 / 100;
                Console.Write("Du vil få {0:0.00} udbetalt i rente i slutningen af året.", rente);
                Console.ReadKey();
                UdKon();
            }
        }

        private static void MetIn()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Metoder og Instanser";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣
 ║ [1] - Opgave 1                      ║
 ║ [2] - Opgave 2                      ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: MetInOpg1(); break;
                case ConsoleKey.D2: MetInOpg2(); break;
                case ConsoleKey.UpArrow: UdKon(); break;
                case ConsoleKey.DownArrow: RetPa(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            MetIn();
        }
        private static void MetInOpg1()
        {
            Console.Clear();
            SherlockHolmes();
            Console.ReadKey();
            MetIn();
        }
        private static void PrintInfo()
        {
            Console.Write("Jeg er en bog.");
        }
        private static void SherlockHolmes()
        {
            PrintInfo();
        }

        private static void MetInOpg2()
        {
            Console.Clear();
            SherlockHolmes2(); 
            Console.ReadKey();
            MetIn();
        }
        private static void PrintInfo2()
        {
            Console.Write("Jeg er en bog.");
        }
        private static void SherlockHolmes2()
        {
            bool boing = HarRåd2();
            if (boing == true) //Afhængig af hvilken booleansk værdi den nedenstående metode returnere vil der skrives ét eller andet.
            {
                Console.WriteLine("Jeg har råd til bogen.");
            }
            else
            {
                Console.WriteLine("Jeg har ikke råd til bogen.");
            }
            PrintInfo2();
        }
        public static bool HarRåd2()
        {
            int userMoney;
            int userPrice = 150;

            Console.Write("Indtast det beløb du har at købe for: ");
            userMoney = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (userMoney < userPrice) //Brugerinputtet sammenlignes med bogens statiske pris. Hvis brugerens penge er lig eller overstiger bogens pris vil dette returnere den booleanske værdi 'true'.
            {
                return false; //return bruges til at returnere værdien false eller true til det field der kaldte denne metode.
            }
            else
            {
                return true;
            }
        }

        private static void RetPa()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Returtyper og Parametre";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║ Siden at alle 4 opgaver bygger      ║
 ║ videre på hinanden har jeg lagt dem ║
 ║ sammen i en stor opgave.            ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: RetPaOpg1(); break;
                case ConsoleKey.UpArrow: MetIn(); break;
                case ConsoleKey.DownArrow: InsVar(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            RetPa();
        }
        private static void RetPaOpg1()
        {
            Console.Clear();
            double remainingGas = Bil.RemainingGas(15);
            Bil.Startet(); //For at kunne trække på metoderne i de andre klasser specificere jeg først hvilken class jeg er i (Bil.Startet. I dette eksempel referere 'Bil' til klassen.
            Bil.Slukket();
            Bil.FillGas(2.5, true);
            Console.WriteLine("You have {0} liter gas left in your tank.", remainingGas);
            Console.ReadKey(true);
            RetPa();
        }
        public class Bil
        {
            public static void Startet()
            {
                Console.WriteLine("Motoren er startet.");

            }
            public static void Slukket()
            {
                Console.WriteLine("Motoren er slukket.");
            }
            public static void FillGas(double liters, bool isDiesel) //Værdierne der dikteres i main vores originale klasse (Bil.FillGas(2.5, true)). 
            {
                string Gas = "";
                if (isDiesel == true)
                {
                    Gas = "diesel";
                }
                else
                {
                    Gas = "benzin";
                }
                Console.WriteLine("Filled tank with: {0} liter of {1}.", liters, Gas);
            }
            public static double RemainingGas(double tal1)
            {
                return tal1;
            }
        }

        private static void InsVar()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Instansvariabler";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: InsVarOpg1(); break;
                case ConsoleKey.UpArrow: RetPa(); break;
                case ConsoleKey.DownArrow: NedArv(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            InsVar();
        }
        private static void InsVarOpg1()
        {
            Console.Clear();
            Bog.SherlockHolmes2();
            Console.ReadKey();
            InsVar();
        }
        public class Bog
        {
            public static void SherlockHolmes2()
            {
                bool boing = HarRåd();
                if (boing == true)
                {
                    Console.WriteLine("{0} koster {1}kr.\nDu har råd til bogen!.", bookName, bookPrice);
                }
                else
                {
                    Console.WriteLine("{0} koster {1}kr.\nDu har ikke råd til bogen.", bookName, bookPrice);
                }
            }
            public static bool HarRåd()
            {
                Bog o = new Bog(); //Der oprettes et nyt objekt
                o.getPrice = 150; //I objektet oprettes der én int og én string objektreference.
                o.getName = "Harry Potter: And the Philosopher's Stone\nAf J.K. Rowling";
                int userMoney;

                Console.Write("Indtast det beløb du har at købe for: ");
                userMoney = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (userMoney <= o.getPrice) //Der kaldes på objektreferencen for at få returneret en booleansk værdi.
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static int bookPrice; 
            public int getPrice
            {
                get { return bookPrice; }
                set { bookPrice = value; }
            }

            public static string bookName;
            public string getName
            {
                get { return bookName; }
                set { bookName = value; }
            }
        }

        private static void NedArv()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Nedarvning";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: NedArvOpg1(); break;
                case ConsoleKey.UpArrow: InsVar(); break;
                case ConsoleKey.DownArrow: ConSt(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            NedArv();
        }
        private static void NedArvOpg1()
        {
            Console.Clear();
            Furniture.NedArvV2();
            NedArv();
        }
        public class Furniture
        {
            public static void NedArvV2()
            {
                Chair c = new Chair(); //Der oprettes klassereferencer 
                Computer C = new Computer();
                Console.WriteLine("Stolen er {0}cm bred, {1}cm dyb. Den har en siddehøjde på {2}cm og ryghøjde på {3}.", c.width, c.depth, c.seatHeight, c.backHeight);
                Console.WriteLine("Computeren indeholder følgende dele:\n{0}\n{1}", C.cpu, C.gpu);
                Console.ReadKey();
            }
            public class Chair : Furniture //Der oprettes en en underklasse til Furniture der er istand til at nedarve(inherit) værdier fra hovedklassen.
            {
                public double width = 50;
                public double seatHeight = 110;
                public double backHeight = 160;
                public double depth = 60;
            }
            public class Computer : Furniture
            {
                public string cpu = "Intel Core i7-9700K";
                public string gpu = "NVIDIA Quadro GV100";
            }
        }

        private static void ConSt()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Constructors";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: ConStOpg1(); break;
                case ConsoleKey.UpArrow: NedArv(); break;
                case ConsoleKey.DownArrow: Arr(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            ConSt();
        }
        private static void ConStOpg1()
        {
            Console.Clear();
            Bog2.SherlockHolmes2();
        }
        public class Bog2
        {
            public Bog2()
            {
                getPrice = 150;
                getName = "Henry";
            }
            public static void SherlockHolmes2()
            {
                bool boing = HarRåd();
                if (boing == true)
                {
                    Console.WriteLine("{0} koster {1}kr.\nDu har råd til bogen!.", bookName, bookPrice);
                }
                else
                {
                    Console.WriteLine("{0} koster {1}kr.\nDu har ikke råd til bogen.", bookName, bookPrice);
                }
                Console.ReadKey();
            }
            public static bool HarRåd()
            {
                Bog2 o = new Bog2();
                o.getPrice = 150;
                o.getName = "Harry Potter: And the Philosopher's Stone\nAf J.K. Rowling";
                int userMoney;

                Console.Write("Indtast det beløb du har at købe for: ");
                userMoney = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (userMoney < o.getPrice)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static int bookPrice;
            public int getPrice
            {
                get { return bookPrice; } 
                set { bookPrice = value; }
            }

            public static string bookName;
            public string getName
            {
                get { return bookName; }
                set { bookName = value; }
            }            
        }

        private static void Arr()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Arrays";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: ArrOpg1(); break;
                case ConsoleKey.UpArrow: ConSt(); break;
                case ConsoleKey.DownArrow: GenArr(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            Arr();
        }
        private static void ArrOpg1()
        {
            Console.Clear();
            int[] array = new int[4];
            array[0] = -2;
            array[1] = -1;
            array[2] = 0;
            array[3] = 10;
            int sum = array.Sum(); //Jeg tager her summen af alle array elementer og skriver den til 'sum'

            int[] array2 = { -2, -1, 0, 10 };
            Console.WriteLine(array[1]);
            Console.WriteLine(array[3]);
            Console.WriteLine(sum);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[3]);
            Console.ReadKey();
            Arr();
        }

        private static void GenArr()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Gennemløb af Arrays";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: GenArrOpg1(); break;
                case ConsoleKey.UpArrow: Arr(); break;
                case ConsoleKey.DownArrow: PPP(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            GenArr();
        }
        private static void GenArrOpg1()
        {
            Console.Clear();
            int[] a = new int[6];
            a[0] = 1;
            a[1] = 2;
            a[2] = 4;
            a[3] = 8;
            a[4] = 16;
            a[5] = 32;
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += a[i];
                Console.WriteLine(a[i]);// Ved at skrive (a[i]) i stedet for (a) kan jeg udskrive hvert element i arrayet.
                Thread.Sleep(200);
            }
            Console.WriteLine("Summen er: " + a.Sum());

            string[] b = new string[5];
            b[0] = "\nDette";
            b[1] = "Er";
            b[2] = "Ikke";
            b[3] = "Helt";
            b[4] = "Rigtigt... Kappa";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i]); 
                Thread.Sleep(200);
            }
            Console.ReadKey();
            GenArr();
        }        

        private static void PPP()
        {
            Console.Clear();
            ConsoleKeyInfo KeyPressed;
            Console.Title = "Menu til Public, Private og Protected";
            Console.Write(@" ╔═════════════════════════════════════╗
 ║ Vælg opgave nummer                  ║
 ╠═════════════════════════════════════╣    
 ║ [1] - Opgave 1                      ║     
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ║                                     ║
 ╠═════════════════════════════════════╣
 ║                                     ║  
 ║ Esc - Gå til hovedmenuen            ║
 ╠═════════════════════════════════════╣
 ║ Indtast Valg:                       ║
 ╚═════════════════════════════════════╝");
            Console.SetCursorPosition(16, 17);
            KeyPressed = Console.ReadKey(true);
            switch (KeyPressed.Key)
            {
                case ConsoleKey.D1: PPPOpg1(); break;
                case ConsoleKey.UpArrow: GenArr(); break;
                case ConsoleKey.DownArrow: Var(); break;
                case ConsoleKey.Escape: Menu(); break;
            }
            PPP();
        }
        private static void PPPOpg1()
        {
            Console.Clear();
            string[] a = new string[4]; //Jeg opretter 4 strings (0-3) og tildeler hver string en værdi nedenfor.
            a[0] = "Hvad betyder Private? \nPrivate access modifier tillader kun brug af en given værdi inde i klassen der indeholder denne.\nDen er den mest restriktive access modifier, se rapporten for uddybning.\n";
            a[1] = "Hvad betyder Protected? \nProtected access modifier tillader brugen af en given værdi i klassen der indeholder denne samt dens derriven classes.\n";
            a[2] = "Hvad betyder public? \nPublic access modifier tillader brugen af en given værdi i alle klasser og deriven classes.\n";
            a[3] = "Hvorfor har vi denne indkapsling? \nVi bruger encapsulation for at undgå at dataen bliver corrupt eller ændret.";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
                Thread.Sleep(200);
            }
            Console.ReadKey();
            PPP();
        }
    }
}

