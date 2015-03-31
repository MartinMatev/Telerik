using System;

namespace StudentClass
{
    class Tests
    {
        static void Main()
        {
            /*
             * Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
             * Use an enumeration for the specialties, universities and faculties.
             * Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
             */

            Student firstStudent = new Student("Ivan", "Ivanov", "Batkov", 829931828, new Address("BG", "BS", "Republikanska 58"), 2);
            firstStudent.University = University.BSU;
            firstStudent.Faculty = Faculty.Law;
            firstStudent.Specialty = Specialty.Law;

            Student secondStudent = new Student("Neven", "Krasimirov", "Stahimirov", 783861643, new Address("BG", "SF", "Malinov"), 4);
            secondStudent.University = University.UNWE;
            secondStudent.Faculty = Faculty.Economy;
            secondStudent.Specialty = Specialty.Economics;

            // Overriden ToString method
            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);

            // Overriden Equals
            Console.WriteLine("\nFirst student equals second ? - {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("First student equals first ? - {0}", firstStudent.Equals(firstStudent));

            // Overriden GetHashCode()
            Console.WriteLine("\nFrist Student GetHashCode result: {0}", firstStudent.GetHashCode());
            Console.WriteLine("Second Student GetHashCode result: {0}", secondStudent.GetHashCode());

            // "==" and "!=" operators
            Console.WriteLine("\nFirst student == second ? - {0}", firstStudent == secondStudent);
            Console.WriteLine("First student != second ? - {0}", firstStudent != secondStudent);

            // Problem 2. IClonable
            Object copyStudent = firstStudent.Clone();
            Console.WriteLine("\nDeep copy of first student: \n{0}", copyStudent);

            //Problem 3. IComparable
            Console.WriteLine("\nReturn 0 if equal, < 0 if First is before Second and > 0 if it's the other way around");
            Console.WriteLine("Result: {0}", firstStudent.CompareTo(secondStudent));
        }
    }
}
