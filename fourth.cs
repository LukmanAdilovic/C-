using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace project.cs
{
    class fourth
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(4));

            //while loops
            int index = 3;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            //for loop
            int[] numbers = { 4, 8, 15, 16, 23, 42};
            for(int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


                Console.ReadLine();
        }
         //switch statements
          static string GetDay(int dayNum) { 
                string dayName;

                switch (dayNum)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                default:
                    dayName = "Invalid Day Number";
                    break;
                }
                
                return dayName;
            }
        
    }
}
