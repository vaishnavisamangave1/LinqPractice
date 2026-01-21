using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public delegate int Mydel(int x,int y);
    public delegate string Mydel1(string x);
    public class Class1

    {
        //1. Define a custom delegate that takes two integers and returns their difference. Write code to use it.
        public static int  Diff(int x,int y)
        {
          return x - y;
        }
        //2. Create a method Calculate that accepts a delegate and two integers, then executes the delegate.
        public static int Calculate(Mydel m, int x, int y)
        {
            return m(x, y);
        }
        public static int Add(int x, int y) => x + y;
        public static int Sub(int x,int y) => x - y;
        public static int Mul(int x,int y) => x * y;

        public static int Div(int x, int y) => x / y;

        public static string UpperCase1(string s) => s.ToUpper();
        public static string LowerCase1(string s) => s.ToLower();

        public static string RevCase1(string s) => new string(s.Reverse().ToArray());


        public static string StringOps(Mydel1 m, string input)
        {
            return m(input);
        }


        static void Main()
        {
            //Class1 c=new Class1();
            //Mydel m = c.Diff;
            //int result = m(8, 2);
            //Console.WriteLine(result);

            //int diff1 = Calculate(Diff, 5, 3);
            //int diff1 = c.Calculate(Diff, 5, 3);
            //Console.WriteLine(diff1);

            //int result = Calculate(Add, 5, 8);
            //Console.WriteLine(result);

            //Mydel op;

            //Console.WriteLine("Choose Operation:");
            //Console.WriteLine("1. Addition");
            //Console.WriteLine("2. Subtraction");
            //Console.WriteLine("3. Multiplication");
            //Console.WriteLine("4. Division");

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        op = Add;
            //        break;

            //    case 2:
            //        op = Sub;
            //        break;

            //    case 3:
            //        op = Mul;
            //        break;

            //    case 4:
            //        op = Div;
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice");
            //        return;
            //}

            //Console.Write("Enter first number: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int n2 = int.Parse(Console.ReadLine());

            //double result = op(n1, n2);

            //Console.WriteLine("Result = " + result);


            // 4.Implement a delegate to handle string operations(e.g., uppercase, lowercase, reverse).

            string text = "Hello world";

            string  upper= StringOps(UpperCase1, text);

            Console.WriteLine(upper);

            string lower=StringOps(LowerCase1, text);
            Console.WriteLine(  lower);

            string rev=StringOps(RevCase1, text);
            Console.WriteLine(rev);







        }
    }
}
