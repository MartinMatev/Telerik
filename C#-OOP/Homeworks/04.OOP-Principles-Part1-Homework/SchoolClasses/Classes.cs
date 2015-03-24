using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolClasses
{
    public class Classes : IComment
    {
        private List<Teacher> teachers;
        private List<Student> students;
        // Guid is used for generating UNIQUE 128bit values
        private Guid uniqueIdentifier;
        private string comment;

        public Classes(Guid uniqueId)
        {
            this.UniqueIdentifier = uniqueId;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public Guid UniqueIdentifier
        {
            get
            {
                return this.uniqueIdentifier;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Cannot be null or empty!");
                }

                this.uniqueIdentifier = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void AddTeachers(List<Teacher> teachers)
        {
            this.teachers.AddRange(teachers);
        }

        public void AddStudents(List<Student> students)
        {
            this.students.AddRange(students);
        }

        public List<Teacher> GetTeachers()
        {
            return this.teachers.ToList();
        }

        public List<Student> GetStudents()
        {
            return this.students.ToList();
        }

        public override string ToString()
        {
            return this.UniqueIdentifier.ToString();
        }
    }
}
