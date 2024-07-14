// Here is the Person class, a simple class with Name and Age properties, along with a Display method.
public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// An Employee class displayed here that inherits from Person and adds a Position property. It also has a DisplayEmployeeDetails method that calls the Display method from the Person class to show the inherited properties and then displays the additional Position property.

public class Employee : Person
{
    private string position;

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public void DisplayEmployeeDetails()
    {
        Display(); // Calls the Display method from the base class (Person)
        Console.WriteLine("Position: " + Position);
    }
}

// Finally, the Main Program and this creates an instance of Employee, sets the properties, and calls the method to display the details. This demonstrates the concept of inheritance, where the Employee class reuses and extends the Person class.
using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John Doe";
            employee.Age = 30;
            employee.Position = "Software Developer";

            employee.DisplayEmployeeDetails();
        }
    }
}
