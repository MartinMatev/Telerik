
using System.Collections.Generic;
namespace _03.StudentProblems
{
    public class Student
    {
        // fields
        private string firstName;
        private string lastName;
        private byte age;
        private int fn;
        private List<double> marks;
        private string tel;
        private string email;
        private Group group;
        
        // constructors
        public Student(string firstName, string lastName, byte age, int fn, List<double> marks, string tel, string email, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Fn = fn;
            this.marks = new List<double>(marks);
            this.Tel = tel;
            this.Email = email;
            this.GroupData = group;
        }

        // properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public byte Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Fn
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public List<double> Marks
        {
            get { return new List<double>(this.marks);}
        }

        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public Group GroupData
        {
            get { return this.group; }
            set { this.group = value; }
        }

        // methods
        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2},Gr: {5}, Fn: {3}, Marks: {4}", firstName, lastName, age, fn, string.Join(", ", marks), group.GroupNumber);
        }
    }
}
