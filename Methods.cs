using System;
 public class Methods
    {
        public static void Main(string [] args)
        {
            Methods m = new Methods();
            m.EvenNumbers(30);
            int Sum = m.Add(10, 30);

            Console.WriteLine(Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public void EvenNumbers(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }
    }

