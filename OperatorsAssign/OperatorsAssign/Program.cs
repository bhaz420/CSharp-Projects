using System;

namespace EmployeeManagement
{
    public class Employee
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

        // Overloading the == operator to compare Employee objects by ID
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.ID == emp2.ID;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;
        }
    }

    class Program
    {
        static void Main(string[] args)
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