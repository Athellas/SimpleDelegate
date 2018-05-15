using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public static int Add(int x, int y) { return x + y; }
        public static int Substract(int x, int y) { return x - y; }
        public static int SquareNumber(int a) { return a * a; }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple delgate example *****\n");

            BinaryOp b = new BinaryOp(SimpleMath.Add);

            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            Console.ReadLine();
        }
    }
}
