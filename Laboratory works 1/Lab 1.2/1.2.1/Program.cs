using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
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
            Console.WriteLine("------ AVTOMATSKO GENERIRANJE ------ ");
            Console.WriteLine();
            Console.Write("Kolku broevi da se generiraat? ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[n];
                int min = int.MaxValue;
                int max = int.MinValue;
                double avg = 0;
                double sum = 0;
                int i;
                Random rand = new Random();
                for (i = 0; i < n; i++)
                {

                    numbers[i] = rand.Next(1, 1000);
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
                Console.WriteLine("Vo opseg [1,1000], vashite broevi se:");
                Console.WriteLine();
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

