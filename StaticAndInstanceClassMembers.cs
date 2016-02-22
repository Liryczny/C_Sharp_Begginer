using System;

public class Circle
{
    static float _PI;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("Static Constructor Called");
        Circle._PI = 3.141F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("Instance Constructor Called");
        this._Radius = Radius;
    }

    //behaviour
    public float CalculateArea()
    {
        return this._Radius * Circle._PI * this._Radius;
    }
}
   public class StaticAndInstanceClassMembers
    {
        public static void Main(string [] args)
        {
            Circle c1 = new Circle(5);
            float Area1 = c1.CalculateArea();
            Console.WriteLine("Area = {0}",Area1);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
        }
    }

