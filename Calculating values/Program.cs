using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace Calculating_values
{
    class Program
    {
        static void Main(string[] args)
        {
        Calculation cal=new Calculation();
        Console.WriteLine("Enter the number1 value:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number2 value:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition:"+cal.Addition(n1,n2));
        Console.WriteLine("Subtraction:"+ cal.Subtraction(n1, n2));
        Console.WriteLine("Multiplication:"+ cal.Multiplication(n1, n2));
        Console.WriteLine("Division:"+ cal.Division(n1, n2));
        Console.ReadLine();
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            Console.WriteLine("number1 value:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number2 value:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition:" + cal.Addition(n1, n2));
            Console.WriteLine("Subtraction:" + cal.Subtraction(n1, n2));
            Console.WriteLine("Multiplication:" + cal.Multiplication(n1, n2));
            Console.WriteLine("Division:" + cal.Division(n1, n2));
            Console.ReadLine();
        }
    }
}
