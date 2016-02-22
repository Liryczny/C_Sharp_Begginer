using System;
 public class IfStatements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            if (userNumber == 10 || userNumber == 20)
            {
                Console.WriteLine("Your number is 10 or 20");
            }
        }
    }

