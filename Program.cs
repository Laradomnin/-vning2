
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
                        //fråga om ålder för person {i + 1}
                        Console.WriteLine($"Ange ålder per person {i+1} av {amount}");
                        var a = int.Parse(Console.ReadLine());
                        //tagit emot ålder
                        if (a < 21)
                            // if ()..om ålder mindre än 20, lägg på kostnad
                            tickets[i] = 90;
                        else if (a < 65)
                            tickets[i] = 120;
                        else tickets[i] = 80;                        
                        // else if ()..ålder mindre än 65, lägg på kostdnad
                        // else .. annars, lägg på pensionärpris
                         // Console.WriteLine($"Skriv in pris per biljett {i + 1} av {amount}");
                        //tickets[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine ("Summan per sällskap: "+tickets.Sum());
                    break;

            


            }
        }
    }
}
