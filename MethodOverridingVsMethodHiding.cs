using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a Base Class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am a Derived Class Print Method");
    }
}
    public class MethodOverridingVsMethodHiding
    {
        public static void Main(string [] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();
        } 
    }

