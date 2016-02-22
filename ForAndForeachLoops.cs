using System;
 public class ForAndForeachLoops
    {
        public static void Main(string[] args)
        {
            for (int d = 1; d <= 20; d++)
            {
                Console.WriteLine(d);
                
                if (d == 10)
                    break;          
            }
            
            Console.WriteLine();
            
            for (int e = 0; e <= 20; e++)
            {
                if (e % 2 == 1)
                    continue;

                Console.WriteLine(e);  
            }
            Console.WriteLine();

            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            int[] Nums = { 201, 202, 203 };

            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();

            for (int j = 0; j < Nums.Length; j++)
            {
                Console.WriteLine(Nums[j]);
            }

            Console.WriteLine();

            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }



        }
    }
