using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //step1-Enter first number,save as Num1
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            //step2-Enter second number,save as Num2
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            //step3-Enter third number,save as Num3
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());
            //step4-Add Num1,Num2 and Num3,save as Sum
            int sum = num1 + num2 + num3;
            //step5-Display Sum
            Console.WriteLine("addition of 3 numbers is=" + sum);
            Console.ReadKey();

        }
    }
}
