using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        //base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}

public class FullTimeEmployee : Employee
{

}
public class MethodHiding
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmployee();
            //PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            //((Employee)PTE).PrintFullName();
            PTE.PrintFullName();
            
        }
    }

