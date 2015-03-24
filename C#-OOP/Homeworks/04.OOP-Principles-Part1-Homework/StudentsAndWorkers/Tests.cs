using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    public class Tests
    {
        static void Main()
        {
            // Generating a List of students
            List<Student> students = new List<Student>();

            students.Add(new Student("Pencho", "Nikolov", 4.67));
            students.Add(new Student("Nikola", "Penchev", 6.00));
            students.Add(new Student("Ivan", "Ivanov", 5.67));
            students.Add(new Student("Ivon", "Bukareva", 5.89));
            students.Add(new Student("Nikoleta", "Lozanova", 3.67));
            students.Add(new Student("Stamat", "Korukchiev", 4.55));
            students.Add(new Student("Nikolay", "Nenov", 4.36));
            students.Add(new Student("Ivaylo", "Pehov", 3.20));
            students.Add(new Student("Beliana", "Djafarova", 5.26));
            students.Add(new Student("Subcho", "Subchev", 2.67));

            //// Generate a List of workers
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Pencho", "Nikolov", 1200m, 8, 5));
            workers.Add(new Worker("Nikola", "Penchev", 950m, 8, 5));
            workers.Add(new Worker("Ivan", "Ivanov", 2500.56m, 10, 4));
            workers.Add(new Worker("Ivon", "Bukareva", 1450.76m, 8, 5));
            workers.Add(new Worker("Nikoleta", "Lozanova", 1340m, 8, 6));
            workers.Add(new Worker("Stamat", "Korukchiev", 1287.57m, 6, 6));
            workers.Add(new Worker("Nikolay", "Nenov", 2460m, 6, 5));
            workers.Add(new Worker("Ivaylo", "Pehov", 640m, 7, 5));
            workers.Add(new Worker("Beliana", "Djafarova", 900m, 8, 3));
            workers.Add(new Worker("Subcho", "Subchev", 1730.22m, 7, 5));

            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var sortedStudents = students.OrderBy(x => x.Grade).ToList();
            Console.WriteLine("Students sorted by grades in ASC order:\n");
            Console.WriteLine(string.Join("\n", sortedStudents));

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            Console.WriteLine("\nWorkers sorted by money per hour:\n");
            Console.WriteLine(string.Join("\n", sortedWorkers));

            // Merge the lists and sort them by first name and last name.
            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            var resultQuery = mergedList.OrderBy(fn => fn.FirstName)
                                        .ThenBy(ln => ln.LastName)
                                        .ToList();
            Console.WriteLine("\nMerged lists, sorted by first name and then last:\n");
            Console.WriteLine(string.Join("\n", resultQuery));
        }
    }
}
