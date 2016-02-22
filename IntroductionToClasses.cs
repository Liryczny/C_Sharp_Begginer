using System;

public class Customer
{
    string _firstName;
    string _lastName;
    public Customer()
        : this("No First Name Provided", "No last name provided")
    {

    }   
    //constructor it's called whenever the instance of class is created
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    //method
    public void PrintFullName()
    {
        Console.WriteLine("Full name = {0} {1}", this._firstName, this._lastName);
    }

    //destructor
    ~Customer()
    {
        //clean up code
    }
}
public class IntroductionToClasses
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("John","Doe");
            customer.PrintFullName();
            
            Customer customer1 = new Customer();
            customer1.PrintFullName();
        }
    }

