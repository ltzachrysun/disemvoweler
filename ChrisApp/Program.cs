using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myFunction(5, 6);
            myArray();
            Console.ReadKey();
        }

        static void myFunction(int num1, int num2)
        {
            Console.WriteLine("Hi there");
            var finalNum = num1 + num2;
            Console.WriteLine(finalNum);
        }

        static void myArray()
        {
            string[] myArray = { "ball", "bat", "glove", "hat", "helmet" };

            foreach (var item in myArray)
            {
                Console.WriteLine("a;lksehdf");
            }
        }
    }
}
