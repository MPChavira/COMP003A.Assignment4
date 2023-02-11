/* 
 * Author: Michael Perez Chavira
 * Course: COMP003A-LO1
 * Purpose: Week 4 Assignment: Looping Statements
 */
using System.Globalization;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("Enter a positive whole number:");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }
            

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("Output all of the friends in array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while statement");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;

            do
            {
                Console.WriteLine(counter += 5);
            } while (counter <= 50);

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while statement");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisble by 2, output Foo");
            Console.WriteLine("If the number is divisble by 5, output Bar");
            Console.WriteLine("If the number is divisble by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;

            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }

                if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }

                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }

                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
               


            }

        }
    }
}