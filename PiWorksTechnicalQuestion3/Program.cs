using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiWorksTechnicalQuestion3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("Value before relocation");
            Console.WriteLine("Number 1 = {0}", number1);
            Console.WriteLine("Number 2 = {0}", number2);


            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("___________________________________");
            Console.WriteLine("Value after relocation");
            Console.WriteLine("Number 1 = {0}", number1);
            Console.WriteLine("Number 2 = {0}", number2);

            Console.ReadKey();

        }
    }
}
