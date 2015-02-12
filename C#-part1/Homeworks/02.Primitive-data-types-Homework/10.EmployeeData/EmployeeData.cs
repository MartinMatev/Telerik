using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        /*
        A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        First name
        Last name
        Age (0...100)
        Gender (m or f)
        Personal ID number (e.g. 8306112507)
        Unique employee number (27560000…27569999)
        Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
         */

        struct Employee
        {
            public string firstName;
            public string lastName;
            public byte age;
            public char gender;
            public long personalId;
            public long employeeNumber;
        }
        static void Main(string[] args)
        {
            Console.Title = "World Domination, Inc.";
            // Using a infinite loop to add multiple employee's data
            while (true)
            {
                try
                {
                    // Adds the data, keeping track with try{} catch{} for approriate format
                    Console.WriteLine("\nPlease type in the new employee data below!\n");
                    Employee newEmployee = new Employee();

                    Console.Write("Enter the employee first name: ");
                    newEmployee.firstName = Console.ReadLine();

                    Console.Write("Enter the employee last name: ");
                    newEmployee.lastName = Console.ReadLine();

                    Console.Write("Enter the employee age: ");
                    newEmployee.age = byte.Parse(Console.ReadLine());

                    Console.Write("Enter the employee gender (m or f): ");
                    newEmployee.gender = char.Parse(Console.ReadLine());

                    Console.Write("Enter the employee personalId (max. 19 chars long): ");
                    newEmployee.personalId = long.Parse(Console.ReadLine());

                    Console.Write("Enter the employee employeeNumber (max. 19 chars long): ");
                    newEmployee.employeeNumber = long.Parse(Console.ReadLine());

                    // Displays the entered data
                    Console.WriteLine("\nThe new employee data you just entered: \nFirst name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nID: {4}\nUnique Num: {5}", 
                        newEmployee.firstName, newEmployee.lastName, newEmployee.age, newEmployee.gender, newEmployee.personalId, newEmployee.employeeNumber);
                    Console.WriteLine("\nPress any key to continue, or type in \"exit\", without quotations to exit the application");

                    // Checks if the user types in the word "exit" after every employee's data submission and breaks the infinite loop if done so.
                    if (Console.ReadLine() == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Console.WriteLine("Please input the data in the right format!");
                }
            }
        }
    }
}
