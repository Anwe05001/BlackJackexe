using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Uppgift_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du köra lite BlackJack?");
            Console.WriteLine();
            string Select = "";
            while (Select != "4")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("     1.Spela BlackJack ");
                Console.WriteLine("     2.Visa senaste vinnaren");
                Console.WriteLine("     3.Spelets regler");
                Console.WriteLine("     4.Avsluta programmet");
                Select = Console.ReadLine();

                Console.WriteLine();
                if (Select == "1")
                {
                    Console.WriteLine("Okej, Dra ett kort genom att skriva in bokstaven Y/y");
                    Console.WriteLine("Sluta dra kort genom att skriva bokstaven N/n");
                    String Dra = Console.ReadLine();
                    if (Dra == "Y" || "y");
                }
                else if (Select == "2")
                {
                    Console.WriteLine(SenasteVinnare);
                }
                else if (Select == "3")
                {
                    Console.WriteLine("Du ska dra ett slumpmässigt nummer och du ska vara så nära talet 21 som möjligt ");
                    Console.WriteLine("utan att överstiga det, närmaste nummret vinner");
                    Task.Delay(1200).Wait();
                }
                else if (Select == "4")
                {
                    Console.WriteLine("Tack för idag!");
                    Task.Delay(600).Wait();
                    break; 
                }
                Console.WriteLine();
            }
        }
    }
}