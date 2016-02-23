using System;

interface ICustomer1
{
    void Print();    
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}
public class Customer : ICustomer2
{
    public void Print()
    {
        Console.WriteLine("Interface Print Method");
    }
    public void Print2()
    {
        Console.WriteLine("Interface 2 Print Method");
    }
}
public class Interfaces
{
   public static void Main(string[] args)
   {
       Customer C1 = new Customer();
       C1.Print();
       C1.Print2();
   }
}

