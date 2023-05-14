using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            float X1, X2, Y1, Y2;
            float LineLength;
            Console.WriteLine("please enter x1 number");
            float.TryParse(Console.ReadLine(), out X1);
            Console.WriteLine("please enter x2 number");
            float.TryParse(Console.ReadLine(), out X2);
            Console.WriteLine("please enter y1 number");
            float.TryParse(Console.ReadLine(), out Y1);
            Console.WriteLine("please enter y2 number");
            float.TryParse(Console.ReadLine(), out Y2);

            LineLength = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("length of line{0}:", LineLength);
            Console.ReadLine();


        }
    }
}
