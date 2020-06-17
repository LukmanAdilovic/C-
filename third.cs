using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace project.cs
{
    class third
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are  not male or not tall or both");
            }

            Console.WriteLine(GetMax(2, 10));

            Console.ReadLine();

            static int GetMax(int num1, int num2)
            {
                int result;
                if (num1 > num2)
                {
                    result = num1;
                }
                else{
                    result = num2;
                }
                return result;
            }
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string oper = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (oper == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (oper == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (oper == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }
        }
    }
}
