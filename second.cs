using System;

namespace second.cs
{
    class second
    {
        static void Main(string[] args)
        {
            //Getting User Input and Building a Calculator
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product is " + (num1 + num2));

            //Building a Mad Lib
            string color, noun, carName;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter name of car: ");
            carName = Console.ReadLine();

            Console.WriteLine("Sky is " + color);
            Console.WriteLine(noun + " is fast");
            Console.WriteLine("I like " + carName);
            
            //methods
            Mymethod("Luks", 24);
            
            Console.ReadLine();
        }
        static void Mymethod(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
