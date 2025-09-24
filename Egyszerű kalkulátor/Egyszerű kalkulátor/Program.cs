using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyszerű_kalkulátor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string muvelet;
            int szam1, szam2;

            Console.Write("Adj meg egy számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy műveleti jelet (+,-,*,/): ");
            muvelet = Convert.ToString(Console.ReadLine());

            switch (muvelet)
            {
                case "+":
                    Console.WriteLine("Eredmény: " + (szam1 + szam2));
                    break;
                case "-":
                    Console.WriteLine("Eredmény: " + (szam1 - szam2));
                    break;
                case "*":
                    Console.WriteLine("Eredmény: " + (szam1 * szam2));
                    break;
                case "/":
                    if (szam2 == 0)
                    {
                        Console.WriteLine("Hiba: Nullával való osztás nem lehetséges.");
                    }
                    else
                    {
                        Console.WriteLine("Eredmény: " + (szam1 / szam2));
                    }
                    break;
                default:
                    Console.WriteLine("Érvénytelen bemenet!");
                    break;
            }
            Console.ReadKey();



        }
    }
}
