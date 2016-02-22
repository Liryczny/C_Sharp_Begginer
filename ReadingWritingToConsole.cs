using System;
public class ReadingWritingToConsole
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Please enter your first name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your second name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", FirstName,LastName);
            
        }
    }

