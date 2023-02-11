using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe");

            // teste dla Git

            var number = Getnumber();

            Console.WriteLine("Podaj znak działania '+','-','*','/'");

            var mark = GetMark();

            Console.WriteLine("Podaj drugą liczbe");

            var number2 = Getnumber();

            var result = 0;

            switch (mark)
            {
                case "+":
                    result = number + number2;
                    break;
                case "-":
                    result = number - number2;
                    break;
                case "*":
                    result = number * number2;
                    break;
                case "/":
                    result = number / number2;
                    break;
            }

            Console.WriteLine($"\n{number} {mark} {number2} = {result}");


        }

        private static string GetMark()
        {
            if ((Console.ReadLine()!= "+") || (Console.ReadLine() != "-") || (Console.ReadLine() != "*") || (Console.ReadLine() != "/"))
            {
                Console.WriteLine("Zły znak działania");
            };
            return Console.ReadLine();
        }

        private static int Getnumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int Number1))
            {
                Console.WriteLine("Zła wartość podaj liczbę");

                Number1=int.Parse(Console.ReadLine());
            };
            return Number1;
        }
    }
}
