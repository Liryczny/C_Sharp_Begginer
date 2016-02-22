using System;
 public class WhileLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target");
            int target = int.Parse(Console.ReadLine());

            int Start = 0;
            string output = "";
            while (Start <= target)
            {
                output += Start + " ";
                Start += 2;
            }

            Console.WriteLine(output);
        }
    }
