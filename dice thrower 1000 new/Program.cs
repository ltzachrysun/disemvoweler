using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_thrower_1000_new
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("first)");
            ThrowDice("10d6");
            Console.WriteLine("second)");
            ThrowDice("3d20");
            Console.WriteLine("third)");
            ThrowDice("100d6");

            Console.ReadKey();

        }

        static void ThrowDice(string dicestring)
        {
            List<string> dicestringlist = dicestring.Split('d').ToList();
            int n = int.Parse(dicestringlist[0]);
            int m = int.Parse(dicestringlist[1]);
            Random randomNumberGenerator = new Random();
            for (int i = 1; i <= n; i++)
            {
                int randomNumber = randomNumberGenerator.Next(1, m + 1);
                Console.WriteLine(randomNumber);
            }

        }

    }
}
