using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class SchoolTests
    {
        static void Main()
        {
            // Creates an object of the Guid class (which generates UNIQUE only values)
            // Assining values to the Guid object is done by Guid.NewGuid();
            Guid uniqueStudentNum = new Guid();
            Guid uniqueClassName = new Guid();

            // Create a school object
            School mySchool = new School("Telerik");
            
            // Creating the student objects and forming a list
            Student ivancho =  new Student("Ivancho", 18, uniqueStudentNum = Guid.NewGuid());
            Student mariika = new Student("Mariika", 20, uniqueStudentNum = Guid.NewGuid());
            Student unishtojitelia = new Student("UNISHTOJITELIA", 13, uniqueStudentNum = Guid.NewGuid());

            List<Student> studnetsList = new List<Student>();
            studnetsList.Add(ivancho);
            studnetsList.Add(mariika);
            studnetsList.Add(unishtojitelia);

            // Create a list of disciplines
            Discipline mathematics = new Discipline("Mathematics", 5, 9);
            Discipline physics = new Discipline("Physics", 4, 7, "This is discipline with a comment");
            Discipline informatics = new Discipline("Informatics", 7, 10);

            // Generate teachers and add disciplines to their Listof Disciplines
            Teacher strahil = new Teacher("Strahil", 34);
            strahil.AddDisciplines(mathematics);
            strahil.AddDisciplines(informatics);

            Teacher pencho = new Teacher("Pencho", 48);
            pencho.Comment = "I am a teacher with positive comment!!!";
            pencho.AddDisciplines(physics);

            // Generate a list of teachers
            List<Teacher> teachersList = new List<Teacher>(){ strahil, pencho };

            // Generate a Class with unique identifier and Add the lists of students AND the list of teachers
            Classes myClass = new Classes(uniqueClassName = Guid.NewGuid());
            myClass.AddStudents(studnetsList);
            myClass.AddTeachers(teachersList);

            // Add a comment to the class
            myClass.Comment = "My class has a comment now.";

            // Add the class to the school
            mySchool.AddClasses(myClass);

            PrintResult(mySchool);
        }

        private static void PrintResult(School school)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(school.SchoolName);

            foreach (var currentClass in school.Classes)
            {
                result.AppendLine(" #Class unique identifier: " + currentClass.UniqueIdentifier);

                foreach (var teacher in currentClass.GetTeachers())
                {
                    result.Append(" #Teacher");
                    result.AppendLine(" - " + teacher);

                    foreach (var discipline in teacher.GetDisciplines())
                    {
                        result.AppendLine("     > " + discipline);
                    }
                }

                result.AppendLine(" #Students");
                foreach (var student in currentClass.GetStudents())
                {
                    result.AppendLine("     > " + student);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
