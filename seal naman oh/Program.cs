using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace seal_naman_oh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] chars = new char[1000];
            List<int> holders = new List<int>();
            char loob = ' ';
            char uInput = ' ';
            int counter = 0;
            int present = 0;

            Console.WriteLine("Please input a single character: ");
            uInput = char.Parse(Console.ReadLine());

            for(int x =  0; x < chars.Length; x++)
            {
                loob = (char)rnd.Next(32,127);   
                chars[x] = loob;
            }
            
            foreach(char c in chars)
            {
                present++;
                if(uInput == c)
                {
                    holders.Add(present);
                    counter++;
                }
            }

            Console.WriteLine("Your input was found: " + counter + " times.");
            Console.WriteLine("These are the indexes it was present in: ");

            foreach (int h in holders)
            {
                Console.WriteLine(h);
            }
            Console.ReadKey();
        }
    }
}
