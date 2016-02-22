using System;
public class Arrays
{
    public static void main(string[] args)
    {
        //first way of initializing
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 0;
        evenNumbers[1] = 2;
        evenNumbers[2] = 4;

        Console.WriteLine(evenNumbers[1]);
        
        //second way of initializing
        int[] oddNumbers = {1, 3, 5};

        Console.WriteLine(oddNumbers[1]);

    }
}

