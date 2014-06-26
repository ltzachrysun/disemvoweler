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
            
            Console.WriteLine("insert text in string to be disemvoweled");
            //this function determines the user imput to be ran
            string input = Console.ReadLine();
            char[] removed = new Char[50];
            int count = 0;

            
            string step1 = input.Replace("a", string.Empty);
            step1 = step1.Replace("e", string.Empty);
            step1 = step1.Replace("i", string.Empty);
            step1 = step1.Replace("o", string.Empty);
            step1 = step1.Replace("u", string.Empty);
            step1 = step1.Replace(" ", string.Empty);
                

            for (int x = 0; x < input.Length; x++)
            {
                //telling the computer which characters to pull out.
                if (input[x] == 'a'||input[x] == 'e'||input[x] == 'i'||input[x] == 'o'||input[x] == 'u'||input[x] == 'A'||input[x] == 'E'||input[x] == 'I'||input[x] == 'O'||input[x] == 'U')
                {
                    removed[count] = input[x];
                    count++;
                }

            }

            //these lines print the product of the disenvoweler function.
            Console.WriteLine();
            Console.Write("output: " + step1 + '\n');
            Console.WriteLine();
            Console.Write("removed: " + new string(removed));



            Console.ReadKey();

        }
    }
}
