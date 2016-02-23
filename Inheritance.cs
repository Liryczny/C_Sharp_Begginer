using System;

public class ParentClass
{
    public ParentClass()
    {
         Console.WriteLine("ParentClass Constructor called");
    }

    //overloading 
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived Class controlling Parent class")
    {
        Console.WriteLine("ChildClass Constructor called");
    }
}

    public class Inheritance
    {
        public static void Main(string [] args)
        {
            ChildClass CC = new ChildClass();
        }
    }
