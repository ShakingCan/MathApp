using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double sqrt, pow, abs, max, min;
            sqrt = Math.Sqrt(10.5);
            pow = Math.Pow(2, 3);
            abs = Math.Abs(-5.5);
            max = Math.Max(10, 20);
            min = Math.Min(10, 20);

            Console.WriteLine("square root:  " + sqrt);
            Console.WriteLine("Pow method:  " + pow);
            Console.WriteLine("Abs method: " + abs);
            Console.WriteLine("Max method: " + max);
            Console.WriteLine("Min method:  " + min);
        }
    }
}
