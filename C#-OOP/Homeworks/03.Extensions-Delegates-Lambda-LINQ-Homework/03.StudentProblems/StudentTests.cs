using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.StudentProblems
{
    public class StudentTests
    {
        static void Main()
        {
            /*
             * Problem 3. First before last
             * Write a method that from a given array of students finds all students whose first name is before its 
             * last name alphabetically. Use LINQ query operators.
             */
            Student[] studentsArray = 
            {
                new Student("Penko", "Penkov", 19, 3782, new List<double>{2, 5, 3, 3}, "0889776523", "narkotrafikant@abv.bg", new Group(2, "Mathematics")),
                new Student("Genko", "Genkov", 29, 3411, new List<double>{2, 2, 2}, "0979786523", "narkozavisim@abv.bg", new Group(2, "Physics")),
                new Student("Strahil", "Chukov", 27, 2987, new List<double>{5, 4, 5, 6}, "0866776595", "narkoneponosim@abv.bg", new Group(2, "Physics")),
                new Student("Stamat", "Harabejov", 22, 2772, new List<double>{6, 5}, "0867226547", "narkobaron@abv.bg", new Group(2, "Informathics")),
                new Student("Genoveva", "Zvezdeva", 25, 3681, new List<double>{6, 6, 5, 6, 5}, "0886816573", "narkotrafikant@abv.bg", new Group(2, "Economics")),
            };

            FirstBeforeLast(studentsArray);          

            /*Problem 4. Age range
             * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
             */
            AgeRange(studentsArray);

            /*
             * Problem 5. Order students
             * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
             * Rewrite the same with LINQ.
             */
            OrderStudents(studentsArray);
            OrderStudentWithLINQ(studentsArray);

            /*
             * Problem 9. Student groups
             * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
             * Create a List<Student> with sample students. Select only the students that are from group number 2.
             * Use LINQ query. Order the students by FirstName.
             */
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Penko", "Penkov", 19, 378204, new List<double> { 2, 5, 3, 3 }, "0889776523", "narkotrafikant@abv.bg", new Group(49, "Physics")));
            studentList.Add(new Student("Genko", "Genkov", 29, 341104, new List<double> { 2, 2 }, "0979786523", "narkozavisim@gmail.com", new Group(2, "Mathematics")));
            studentList.Add(new Student("Strahil", "Chukov", 27, 298705, new List<double> { 5, 4, 5, 6 }, "0866776595", "narkoneponosim@abv.bg", new Group(57, "Informatics")));
            studentList.Add(new Student("Stamat", "Harabejov", 22, 277206, new List<double> { 6, 5 }, "02887665", "narkobaron@yahoo.com", new Group(2, "Economics")));

            StudentGroups(studentList);

            /*
             * Problem 10. Student groups extensions
             * Implement the previous using the same query expressed with extension methods.
             */

            StudentGroupsExtensions(studentList);

            /*
             * Problem 11. Extract students by email
             * Extract all students that have email in abv.bg.
             * Use string methods and LINQ.
             */
            ExtractStudentsByEmail(studentList);

            /*
             * Problem 12. Extract students by phone
             * Extract all students with phones in Sofia.
             * Use LINQ.
             */
            ExtractStudentsByPhone(studentList);

            /*
             * Problem 13. Extract students by marks
             * Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
             * Use LINQ.
             */
            ExtractStudentsByMarks(studentList);

            /*
             * Problem 14. Extract students with two marks
             * Write down a similar program that extracts the students with exactly two marks "2".
             * Use extension methods.
             */
            ExtractStudentsWithTwoMarks(studentList);

            /*
             * Problem 15. Extract marks
             * Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
             */
            ExtractMarks(studentList);

            /*
             * Problem 16.* Groups
             * Create a class Group with properties GroupNumber and DepartmentName.
             * Introduce a property GroupNumber in the Student class.
             * Extract all students from "Mathematics" department.
             * Use the Join operator.
             */
            Groups(studentList);

            /*
             * Problem 18. Grouped by GroupNumber
             * Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
             * Use LINQ.
             */
            GroupedByGroupNumber(studentList);

            /*
             * Problem 19. Grouped by GroupNumber extensions
             * Rewrite the previous using extension methods.
             */
            GroupedByGroupNumberExtensions(studentList);
        }

        private static void GroupedByGroupNumberExtensions(List<Student> studentList)
        {
            var groupedByGrNumberExtensions = studentList.OrderBy(st => st.GroupData.GroupNumber).ToArray();
            Console.WriteLine("\nSame as above with extension methods:");
            PrintResult(groupedByGrNumberExtensions);
        }

        private static void GroupedByGroupNumber(List<Student> studentList)
        {
            var groupedByGrNumber = from student in studentList
                                    orderby student.GroupData.GroupNumber
                                    select student;
            Console.WriteLine("\n Print out students grouped by Group Number:");
            PrintResult(groupedByGrNumber);
        }

        private static void Groups(List<Student> studentList)
        {
            string requiredDepartment = "Mathematics";
            var mathematiciansQuery = studentList.Where(st => st.GroupData.DepartmentName == requiredDepartment)
                                                 .Select(x => new { FirstName = x.FirstName, GrNum = x.GroupData.GroupNumber, Department = x.GroupData.DepartmentName })
                                                 .ToArray();
            Console.WriteLine("\nAll students from the \"{0}\" department", requiredDepartment);
            PrintResult(mathematiciansQuery);
        }

        private static void ExtractMarks(List<Student> studentList)
        {
            var twoThousandSixStudents = studentList.Where(st => st.Fn.ToString().Substring(4, 2) == "06")
                                                    .Select(x => new { Fullname = x.FirstName + " " + x.LastName, Fn = x.Fn, Marks = string.Join(", ", x.Marks) })
                                                    .ToArray();
            Console.WriteLine("\nExtract students that enrolled in 2006");
            PrintResult(twoThousandSixStudents);
        }

        private static void ExtractStudentsWithTwoMarks(List<Student> studentList)
        {
            var dumbStudentsQuery = studentList.Where(st => st.Marks.Where(m => m == 2).Count() == 2)
                                               .Select(x => new { Fullname = x.FirstName + " " + x.LastName, Marks = string.Join(", ", x.Marks) });

            Console.WriteLine("\nPrint out all the mazni dvoikadjii students/Fullname + Marks/");
            PrintResult(dumbStudentsQuery);
        }

        private static void ExtractStudentsByMarks(List<Student> studentList)
        {
            var excellentQuery = from student in studentList
                                 where student.Marks.Contains(6d)
                                 select new { Fullname = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };

            Console.WriteLine("\nPrint out all the excelents students/Fullname + Marks/");
            PrintResult(excellentQuery);
        }

        private static void ExtractStudentsByPhone(List<Student> studentList)
        {
            string sofiaCode = "02";
            var sofiaPhonesQuery = from student in studentList
                                   where student.Tel.ToString().Substring(0, 2) == sofiaCode
                                   select student;
            Console.WriteLine("\nPrint out students from Sofia");
            PrintResult(sofiaPhonesQuery);
        }

        private static void ExtractStudentsByEmail(List<Student> studentList)
        {
            string abvHosting = "abv.bg";
            var emailExtraction = studentList.Where(st => st.Email.ToString().Substring(st.Email.ToString().IndexOf('@') + 1) == abvHosting)
                                             .Select(x => new { Fullname = x.FirstName + " " + x.LastName, Email = x.Email})
                                             .ToArray();
            Console.WriteLine("\nPrint out student with abv.bg emails");
            PrintResult(emailExtraction);
        }

        private static void StudentGroupsExtensions(List<Student> studentList)
        {
            var firstNameOrderQueryExt = studentList.Where(st => st.GroupData.GroupNumber == 2)
                                                 .OrderBy(fname => fname.FirstName)
                                                 .ToArray();
        }

        private static void StudentGroups(List<Student> studentList)
        {
            var firstNameOrderQuery = from student in studentList
                                      where student.GroupData.GroupNumber == 2
                                      orderby student.FirstName
                                      select student;
            Console.WriteLine("\nPrint students with group num: 2 && sorted by First Name");
            PrintResult(firstNameOrderQuery);
        }

        private static void OrderStudentWithLINQ(Student[] studentsArray)
        {
            Console.WriteLine("\nFirts then last name in desc order / LINQ /:");
            var orderResultLinq = from student in studentsArray
                                  orderby student.FirstName descending, student.LastName descending
                                  select student;
            PrintResult(orderResultLinq);
        }

        private static void OrderStudents(Student[] studentsArray)
        {
            Console.WriteLine("\nFirts then last name in desc order / lambda expressions/:");
            var orderResult = studentsArray.OrderByDescending(fname => fname.FirstName)
                                           .ThenByDescending(lname => lname.LastName)
                                           .ToArray();
            PrintResult(orderResult);
        }

        private static void AgeRange(Student[] studentsArray)
        {
            Console.WriteLine("\nStudents with age between 18 and 24");
            var queryAgeResults = from student in studentsArray
                                  where student.Age >= 18 && student.Age <= 24
                                  select student;
            PrintResult(queryAgeResults);
        }

        private static void FirstBeforeLast(Student[] studentsArray)
        {
            Console.WriteLine("First name before last name alphabetically:");
            var queryNameResults = from student in studentsArray
                                   where student.FirstName.CompareTo(student.LastName) < 0
                                   select student;
            PrintResult(queryNameResults);
        }

        private static void PrintResult<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
