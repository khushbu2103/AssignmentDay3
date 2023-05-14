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
            Console.WriteLine("please enter cordinates of line 1st");
            float AX1, AX2, AY1, AY2;
            float BX1, BX2, BY1, BY2;
            float LineLength1;
            float LineLength2;
            Console.WriteLine("please enter x1 number");
            float.TryParse(Console.ReadLine(), out AX1);
            Console.WriteLine("please enter x2 number");
            float.TryParse(Console.ReadLine(), out AX2);
            Console.WriteLine("please enter y1 number");
            float.TryParse(Console.ReadLine(), out AY1);
            Console.WriteLine("please enter y2 number");
            float.TryParse(Console.ReadLine(), out AY2);

            LineLength1 = (float)Math.Sqrt(Math.Pow(AX2 - AX1, 2) + Math.Pow(AY2 - AY1, 2));
            Console.WriteLine("length of line{0}:", LineLength1);
            Console.ReadLine();


            Console.WriteLine("please enter cordinates of line 2nd");
            Console.WriteLine("please enter x1 number");
            float.TryParse(Console.ReadLine(), out BX1);
            Console.WriteLine("please enter x2 number");
            float.TryParse(Console.ReadLine(), out BX2);
            Console.WriteLine("please enter y1 number");
            float.TryParse(Console.ReadLine(), out BY1);
            Console.WriteLine("please enter y2 number");
            float.TryParse(Console.ReadLine(), out BY2);

            LineLength2 = (float)Math.Sqrt(Math.Pow(BX2 - BX1, 2) + Math.Pow(BY2 - BY1, 2));
            Console.WriteLine("length of line1{0}:", LineLength2);

            if (LineLength1.Equals(LineLength2))

            {
                Console.WriteLine("line 1st is equals to line 2nd");
            }
            else
            {
                Console.WriteLine("line 1st is not equals to line 2nd");
            }
                 
                
            Console.ReadLine();


        }
    }
}
