using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleAppPhoneRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            // (+380xx)xxx-xx-xx | xxx-xx-xx
            string pattern = @"((\(\+380[1-9]{2}\))*)[1-9]{3}-[1-9]{2}-[1-9]{2}";  
            List<string> inputs = new List<string>(); 
            List<string> results = new List<string>();  
            string phone, exit;
            while (true) 
            {
                Console.Write("Input initial sequence characters: ");
                phone = Console.ReadLine();
                inputs.Add(phone);
                MatchCollection matches = Regex.Matches(phone, pattern);  
                foreach (Match item in matches)
                    results.Add(item.ToString());

                Console.Write("Do you want to continue? yes/no: ");
                exit = Console.ReadLine();
                if (exit.ToLower() == "no" || exit.ToLower() == "n")
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("All sequences that user input: ");
            foreach (var item in inputs)
                Console.WriteLine(item);

            Console.Write("Quantity of number like : (+380xx)xxx-xx-xx | xxx-xx-xx IS EQUAL: ");
            Console.WriteLine(results.Count);
            Console.WriteLine("All founded phones: ");
            foreach (var item in results)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
