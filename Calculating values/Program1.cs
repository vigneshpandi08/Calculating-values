using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Calculating_values
{
    class Program1
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            Console.WriteLine("Enter the n1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the n2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of two numbers:" + cal.Addition(n1, n2));
            Console.WriteLine("Subtraction of two numbers:" + cal.Subtraction(n1, n2));
            Console.WriteLine("Multiplication of two numbwers:" + cal.Multiplication(n1, n2));
            Console.WriteLine("Division of two numbers:" + cal.Division(n1, n2));
            Console.ReadLine();
        }
    }
}
