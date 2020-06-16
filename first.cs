using System;

namespace variables
{
    class first
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _");
            Console.WriteLine("| |");
            Console.WriteLine("| |    ____");
            Console.WriteLine("| |   /    |");
            Console.WriteLine("| |  /     |");
            Console.WriteLine("| | /      |");
            Console.WriteLine("| |/       |");
            Console.WriteLine("|          |");
            Console.WriteLine("|__________|");

            string characterName = "Tom";
            int characterAge;
            characterAge = 45;

            Console.WriteLine("Here is one man named " + characterName);
            Console.WriteLine("He is " + characterAge + " years old.");
            Console.WriteLine(characterName + " works in this factory.");
            Console.WriteLine("He liked his name " + characterName);
            Console.WriteLine("But he didn't like his " + characterAge + " age");

            string rečenica = characterName + " is very good man.";
            Console.WriteLine(rečenica);
            Console.WriteLine("It's true or false?");
            Console.WriteLine( rečenica.Contains("good") );

            string sentence = "His job is too hard";
            Console.WriteLine(sentence.Substring(14));
            Console.WriteLine(sentence.ToUpper());

            //int num = 5;
            Console.WriteLine("He is employed " +  Math.Pow(4, 2) + " years, but in this factory only " + Math.Sqrt(4) + " years");

            Console.ReadLine();


        }
    }
}
