using System;

public struct Customer
{
    private int _id;
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }
    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("ID = {0} && Name = {1}", _id, _name);
    }
}
    public class Structs
    {
        public static void Main(string[] args)
        {
            Customer C1 = new Customer(1001, "William");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.ID = 1002;
            C2.Name = "John";
            C2.PrintDetails();

            Customer C3 = new Customer{
                ID = 103,
                Name = "Rob"
            };

            C3.PrintDetails();
        }
    }

