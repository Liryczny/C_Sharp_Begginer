using System;

public class Student
{
    private int ID;
    private string Name;
    private int PassMark = 35;
    public string City{get;set;}
    public string Email{get;set;}
    public int passMark
    {
        get
        {
            return this.PassMark;
        }
        
    }
    public string name
    {
        set{
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this.Name = value;
        }
        get
        {
            //ternary operator
            return string.IsNullOrEmpty(this.Name) ? "No name" : this.Name;
        }
       
    }
    public int Id
    {
        set{
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }
            this.ID = value;
        }

        get
        {
            return this.ID;
        }
        
    }


}
class Program
{
    static void Main(string[] args)
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.name = "Michal";

        Console.WriteLine("Student ID = {0}", C1.Id);
        Console.WriteLine("Student Name = {0}", C1.name);
        Console.WriteLine("PassMark = {0}", C1.passMark);

    }
}
