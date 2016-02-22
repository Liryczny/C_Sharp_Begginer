using System;
public class CommonOperators
{
   public static void Main(string [] args)
   {
      int i = 10;
      bool b = true;

      bool IsNumber10;

      int Numerator = 10;
      int Denominator = 2;

      int Number = 10;
      int AnotherNumber = 20;

      bool IsNumber11 = Number == 10 ? true : false;

      int Result = Numerator / Denominator;
      int Result1 = Numerator % Denominator;

      if (Number == 10 && AnotherNumber == 20)
      {
          Console.WriteLine("Hello");
      }

      if (Number == 10 || AnotherNumber == 20)
      {
          Console.WriteLine("Hello World");
      }

      if (Number == 10)
      {
          IsNumber10 = true;
      }
      else
      {
          IsNumber10 = false;
      }

      Console.WriteLine("Result = {0}",Result);
      Console.WriteLine("Result = {0}", Result1);
      Console.WriteLine("Number == 10 is {0}", IsNumber10);
      Console.WriteLine("Number == 10 is {0}", IsNumber11);
   }
}

