using System;
public class Student
{
    private int ID;
    private string Name;
    private int PassMark = 35;

    public int GetPassMark()
    {
        return this.PassMark;
    }
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this.Name = name;
    }

    public string GetName()
    {
        //Ternary operator
        return string.IsNullOrEmpty(this.Name) ? "No name" : this.Name;
    }

    public void SetID(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID cannot be negative");
        }
        this.ID = Id;
    }
    public int GetID()
    {
        return this.ID;
    }

}
    public class Properties
    {
        public static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetID(103131);
            C1.SetName("John");
            
            Console.WriteLine("Student ID = {0}", C1.GetID());
            Console.WriteLine("Student Name = {0}", C1.GetName());
            Console.WriteLine("PassMark = {0}", C1.GetPassMark());

        }
    }
