using EmployeeManagement;
using System;

namespace EmployeeManagement
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    internal class Program
    {

        // Creating an employee object
        Employee employee1 = new Employee(1, "John", "Doe");

        // Accessing and printing employee properties
        Console.WriteLine("Employee ID: " + employee1.ID);
            Console.WriteLine("First Name: " + employee1.FirstName);
            Console.WriteLine("Last Name: " + employee1.LastName);

            // You can create more Employee objects and perform operations as needed

            Console.ReadKey(); // Keep the console window open
        }

    // Overloading the == operator to compare Employee objects by ID
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        return emp1.ID == emp2.ID;
    }

    // Override the Equals method for proper comparisbon
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
            return false;

        Employee other = (Employee)obj;
        return this.ID == other.ID;
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee(1, "John", "Doe");
        Employee employee2 = new Employee(2, "Jane", "Smith");
        Employee employee3 = new Employee(1, "John", "Doe"); // Duplicate of employee1

        Console.WriteLine("employee1 == employee2: " + (employee1 == employee2)); // Should print false
        Console.WriteLine("employee1 == employee3: " + (employee1 == employee3)); // Should print true

        Console.ReadKey(); // Keep the console window open

            private class Program
    {
        private static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee employee1 = new Employee(1, "John", "Doe");
            Employee employee2 = new Employee(2, "Jane", "Smith");

            // Compare the two Employee objects using the overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            // Display the results
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);     // Should print "false"
            Console.WriteLine("Are employee1 and employee2 not equal? " + areNotEqual); // Should print "true"

            Console.ReadKey(); // Keep the console window open
        }
    }
}

}

