using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
           
            Console.WriteLine("Välkommen till Blackjack");
            Console.WriteLine("Välj ett av alternativen");
            Console.WriteLine("1.Spela Blackjack");
            Console.WriteLine("2.Visa regler");
            Console.WriteLine("3.Visa senaste vinnare");
            Console.WriteLine("4.Avsluta programmet");
            int answer = int.Parse(Console.ReadLine());
            int kort1 = random.Next(1, 11);
            int kort2 = random.Next(1, 11);
            int kort3 = random.Next(1, 11);
            int kort4 = random.Next(1, 11);

            int dragning = random.Next(1, 11);
            int summa; 

            switch (answer)
            {
                case 1:
                    
                    
                    
                    Console.WriteLine("");
                    Console.WriteLine("Välkommen till blackjack");
                    Console.WriteLine("");
                    Console.WriteLine("Huset gav dig två kort" + " ditt första kort är värt " + kort1 + " ditt andra kort är värt " + kort2);
                    Console.WriteLine("Du har sammanlagt " + (kort1 + kort2));

                    Console.WriteLine("Huset fick kort blev " + "första kort " + kort3 + " andra kort " + kort4);
                    Console.WriteLine("Huset fick sammanlagt " + (kort3 + kort4));

                    Console.WriteLine("");
                    Console.WriteLine("Vill du dra ett till kort? J/N");
                    string choice = Console.ReadLine(); 
                    break;

            }


        }
    }
}