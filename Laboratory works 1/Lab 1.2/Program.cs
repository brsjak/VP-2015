using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        /*
         ** author: Damjan Miloshevski
         ** contact: d.miloshevski@gmail.com;
         ** skype: damjan.milosevski
         ** phone: +38978566409;
         ** web: https://www.facebook.com/damjan.miloshevski
                 http://miloshevski.us.to/
       */
        static void Main(string[] args)
        {
            Console.WriteLine("------ PROGRAMA ZA BROEVI. VIZUELNO PROGRAMIRANJE - LAB. 1 ------");
            Console.WriteLine();
            Console.WriteLine("------ RACHNO VNESUVANJE ------ ");
            Console.WriteLine();
            Console.Write("Kolku broevi kje vnesete? ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                double[] numbers = new double[n];
                double min = double.MaxValue;
                double max = double.MinValue;
                double avg = 0;
                double sum = 0;
                int i;
                Console.WriteLine();
                Console.WriteLine("Vnesete gi vashite broevi:");
                Console.WriteLine();
                for (i = 0; i < n; i++)
                {
                    Console.Write("Broj {0} = ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    sum += numbers[i];
                    avg = sum / n;

                }
                Console.WriteLine();
                Console.WriteLine("Vashite broevi se:");
                for (i = 0; i < n; i++)
                {

                    Console.Write("{0} ", numbers[i]);

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(string.Format("Suma = {0:#.##} | Prosek = {1:#.##} | Minimum = {2:#.##} | Maximum = {3:#.##}", sum, avg, min, max));
                Console.WriteLine();
                Console.WriteLine("Pritisnete bilo koe kopce da izlezete.");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Pogreshen vlez. Ve molime startuvajte ja programata odnovo.");
                Console.WriteLine("Pritisnete bilo koe kopche da izlezete.");
            }
            Console.ReadKey();
        }
    }
}
