using System;
public class MethodParameters
    {
        public static void Main(string [] args)
        {
            int i = 0;
            MethodParameters.SimpleMethod(ref i);
            Console.WriteLine(i);
            Console.WriteLine();

            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
            Console.WriteLine();

            int[] Numbers = {101,102,103};
            ParamsMethod();
            ParamsMethod(Numbers);
            ParamsMethod(1, 2, 3, 4, 5, 6);
        }

        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
                Sum = FN + SN;
                Product = FN * SN;
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }

