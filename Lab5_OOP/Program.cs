using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            
            MyFrac[] fracs = { new MyFrac(5, 8), new MyFrac(1, 14), new MyFrac(10, 5), new MyFrac(4, 3) };
            Compare(fracs);

            Console.ReadKey();
        }

        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b); // ab 
            curr = curr.Add(curr); // ab + ab = 2ab 
                                   // I’m not sure how to create constant factor "2" in more elegant way, 
                                   // without knowing how IMyNumber is implemented 
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("\n=== Starting testing (a-b) and (a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
            T aMinusB = a.Subtract(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a - b) = " + aMinusB);
            T aPow = a.Multiply(a);
            Console.WriteLine("a^2 = " + aPow);
            T bPow = b.Multiply(b);
            Console.WriteLine("b^2 = " + bPow);
            T aSubsB = a.Subtract(b);
            Console.WriteLine("a^2-b^2 = " + aSubsB);
            T aPlusB = a.Add(b);
            Console.WriteLine("(a + b) = " + aPlusB);
            T res = aSubsB.Divide(aPlusB);
            Console.WriteLine("(a^2-b^2)/(a+b) = " + res);
            Console.WriteLine("=== Finishing testing (a-b) and (a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
        }

        static void Compare(MyFrac[] myFracs)
        {
            Console.WriteLine();

            foreach (MyFrac myFrac in myFracs)
            {
                Console.WriteLine(myFrac + " ");
            }

            Console.WriteLine();
            Array.Sort(myFracs);

            foreach (MyFrac myFrac in myFracs)
            {
                Console.WriteLine(myFrac + " Результат порівняння: " + myFrac.CompareTo(myFrac));
            }
        }
    }
}