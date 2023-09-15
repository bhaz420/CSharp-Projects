using System;

namespace MyConsoleApp
{
    // Define the IQuittable interface with the Quit() method
    interface IQuittable
    {
        void Quit();
    }

    // Employee class implementing the IQuittable interface
    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Console App!");

            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee("John", "Doe");

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // Define the IQuittable interface with the Quit() method
        interface IQuittable
        {
            void Quit();
        }

        // Employee class implementing the IQuittable interface
        class Employee : IQuittable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public void Quit()
            {
                Console.WriteLine($"{FirstName} {LastName} has quit the company.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {   

                // Create an object of type IQuittable using polymorphism
                IQuittable quittableEmployee = new Employee("John", "Doe");

                // Call the Quit() method on the IQuittable object
                quittableEmployee.Quit();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }


    }



