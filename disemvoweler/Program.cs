using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //the vowels 
            string vowels = "aeiou";

            Console.WriteLine("Insert string to be disemvoweled");
            string input = Console.ReadLine();
            char[] removed = new Char[50];
            int count = 0;

            //
            string step1 = input.Replace("a", string.Empty);
            string step2 = step1.Replace("e", string.Empty);
            string step3 = step2.Replace("i", string.Empty);
            string step4 = step3.Replace("o", string.Empty);
            string step5 = step4.Replace("u", string.Empty);
            string step6 = step5.Replace(" ", string.Empty);

            for (int x = 0; x < input.Length; x++)
            {
                //
                if (input[x] == 'a'||input[x] == 'e'||input[x] == 'i'||input[x] == 'o'||input[x] == 'u')
                {
                    removed[count] = input[x];
                    count++;
                }

            }

            //
            Console.Write("OUTPUT: " + step6 + '\n');
            Console.Write("REMOVED: " + new string(removed));



            Console.ReadKey();

        }
    }
}
