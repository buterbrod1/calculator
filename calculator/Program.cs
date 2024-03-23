using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstVa, secondVa;
            string action;

            Console.WriteLine("Введите число 1:");
            firstVa = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2:");
            secondVa = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберете операцию:");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstVa + secondVa);
                    break;
                case "-":
                    Console.WriteLine(firstVa - secondVa);
                    break;
                case "*":
                    Console.WriteLine(firstVa * secondVa);
                    break;
                case "/":
                    Console.WriteLine(firstVa / secondVa);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
