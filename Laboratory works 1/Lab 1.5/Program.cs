using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */

    class Program
    {
        public enum PasswordStrength
        {
            Easy,
            Normal,
            Hard
        }
        static string generatePassword(PasswordStrength passwordStrenght, string unsecurePassword)
        {
            // easy lozinkata treba da ima do 6 znaci ( samo mali bukvi )
            // normal lozinkata treba da ima od 6 do 10 znaci (da sodrzhi golemi bukvi i
            // brojki
            // hard loznikata treba da ima povekje od 10 znaci i da sodrzhi mali , golemi
            // bukvi i specijalni znaci
            StringBuilder password = new StringBuilder();
            Random rand = new Random();
            const string SpecialCharacters = "!@#$%^&*()";

            if (passwordStrenght == PasswordStrength.Easy)
            {
                int length = rand.Next(3, 6);
                for (int i = 0; i < length; i++)
                {
                    char c = new Char();
                    c = unsecurePassword[rand.Next(unsecurePassword.Length)];
                    password.Append(((rand.Next(32) % 2 == 0) && (Char.IsLower(c))) ? c : Char.ToUpper(c));
                }
            }
            else if (passwordStrenght == PasswordStrength.Normal)
            {
                int length = rand.Next(6, 10);
                for (int i = 0; i < length; i++)
                {
                    char c = new Char();
                    c = unsecurePassword[rand.Next(unsecurePassword.Length)];
                    if ((rand.Next(32) % 2 == 0) && (Char.IsLower(c)))
                    {
                        password.Append(Char.ToUpper(c));
                    }
                    else
                    {
                        password.Append(c);
                    }
                }
            }

            else
            {
                int length = rand.Next(10, 15);
                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 0)
                    {
                        password.Append(SpecialCharacters[rand.Next(SpecialCharacters.Length)]);
                        // nekoja logika pak, za generirranje na znak od const nizata gore
                    }
                    else
                    {
                        char c = new Char();
                        c = unsecurePassword[rand.Next(unsecurePassword.Length)];
                        password.Append(((rand.Next(32) % 2 == 0) && (Char.IsLower(c))) ? c : Char.ToUpper(c));
                        // nekoja moja logika za generiranje na random mala ili golema    
                    }
                }
            }
            return password.ToString();
        }
        static void Main(string[] args)
        {
            string passLine = " lozinka1 test2 pogodok ";
            Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            PasswordStrength e = PasswordStrength.Hard;  //Lesno, Normalno ili Tesko ???

            foreach (string unsecurePass in parts)
            {
                Console.Out.WriteLine(String.Format("Generirana lozinka za \"{0}\" e slednata: {1}", unsecurePass, generatePassword(e, unsecurePass)));
            }
            Console.ReadKey();
        }
    }
}
