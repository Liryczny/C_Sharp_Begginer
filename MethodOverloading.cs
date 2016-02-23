using System;
  public class MethodOverloading
  {
        public static void Main()
        {
            Add(123.4F, 1232.44F);
            Add(123, 123);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
  }

