using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentDay3.Program;

namespace AssignmentDay3
{
    internal class Program
    {
        public class Line
        {
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            //public Line(double x1, double y1, double x2, double y2)
            //{
            //    X1 = x1;
            //    Y1 = y1;
            //    X2 = x2;
            //    Y2 = y2;
            //}

            public double Length()
            {
                return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            }
        }

        class Programs
        {
            static void Main(string[] args)
            {
                Line line1 = new Line(0, 7, 3, 4);
                Line line2 = new Line(3, 4, 7, 1);

                Console.WriteLine("Length of line 1: " + line1.Length());
                Console.WriteLine("Length of line 2: " + line2.Length());

                if (line1.Length() > line2.Length())
                    Console.WriteLine("Line 1 is longer than line 2.");
                else if (line1.Length() < line2.Length())
                    Console.WriteLine("Line 2 is longer than line 1.");
                else
                    Console.WriteLine("Line 1 and line 2 are equal in length.");
                Console.ReadLine();
            }
           
        }

       
    }
}
