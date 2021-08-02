using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Napisati program koji izračunava iznos poreza za unijetu platu. Ako je bruto plata veća
od iznosa 1000 porez je 20%, inače je porez 15%.*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            do
            {
                Console.WriteLine("Unesite platu: ");
                p = double.Parse(Console.ReadLine());
            } while (p < 0);
            if (p <= 1000)
            Console.WriteLine("Porez na platu iznosi " + (p * 0.15));
            else
            Console.WriteLine("Porez na platu iznosi " + (p * 0.2));
            Console.ReadKey();
        }
    }
}
