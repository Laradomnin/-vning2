
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Övning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj 1 för att komma till meny/priser, 2 för önskemål,0 för att avsluta programm,3 för att räkna summa.");
            var meny = UInt32.Parse(Console.ReadLine());
            switch (meny)
            {
                case 0:
                    Console.WriteLine("Programmet avslutas ");
                    break;
                case 2:
                    Console.WriteLine("Ange dina önskemål.");
                    string w = Console.ReadLine();
                    for(int i = 0; i < 9; i++)
                    Console.WriteLine(w);
                    break;
                case 1:
                    Console.WriteLine("Hej,ange din ålder!");
                    var age = UInt32.Parse(Console.ReadLine());
                    if (age < 21)
                        Console.WriteLine("Ungdomspris 80 kr");
                    else if (age > 65)
                        Console.WriteLine("Pensionärspris 90 kr.");
                    else Console.WriteLine("Ordinarie pris 120 kr");
                    break;
                case 3:
                    Console.WriteLine("Hur många biljetter skall beställas?");
                    var amount = int.Parse(Console.ReadLine());
                    int[] tickets = new int[amount];
                    //läs in belopp för varje biljett
                    for (int i = 0; i < amount; i++)
                    {
                        Console.WriteLine($"Skriv in pris per biljett {i + 1} av {amount}");
                        tickets[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine ("Summan per sällskap: "+tickets.Sum());
                    break;


            }
        }
    }
}
