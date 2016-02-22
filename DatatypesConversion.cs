using System;
public class DatatypesConversion
{
   public static void Main(string [] args)
    { 
       //implicit conversion
        int o = 100;
        float d = o;

        //explicit conversion
        float f = 123.45F;
        int i = (int)f;

       //convert class
        int j = Convert.ToInt32(f);
        
       //converting string
        string strNumber = "155";
        int s = int.Parse(strNumber);

       //Try parse method
        string num = "222TG";
        int Result = 0;
        bool IsConversionSuccessful = int.TryParse(num, out Result);

        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(d);
        Console.WriteLine(s);

        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

    }
}

