using System;

namespace StudentClass
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        // Constructor - University data will not be set with the constructor, but separately so it doesn't become ridiculously big
        public Student(string firstName, string middleName, string lastName, int ssn, Address address, byte course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Course = course;
        }


        public override string ToString()
        {
            return string.Format("Names: {0} {1} (SSN: {5}) - University: {2}, Faculty: {3}, Specialty: {4}", this.FirstName, this.LastName, this.University, this.Faculty, this.Specialty, this.Ssn);
        }
        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Student return false.
            Student student = obj as Student;
            if ((Object)student == null)
            {
                return false;
            }

            // Return true if the fields match:
            return EqualityCheck(student);
        }

        // MSDN: It is recommended that in addition to implementing Equals(object), any class also implement Equals(type) for their own type, to enhance performance
        public bool Equals(Student student)
        {
            if ((Object)student == null)
            {
                return false;
            }

            return EqualityCheck(student);
        }

        private bool EqualityCheck(Student student)
        {
            if (!(this.FirstName.Equals(student.FirstName))) return false;
            if (!(this.MiddleName.Equals(student.MiddleName))) return false;
            if (!(this.LastName.Equals(student.LastName))) return false;
            if (!(this.Ssn.Equals(student.Ssn))) return false;
            if (!(this.Address.Equals(student.Address))) return false;
            if (!(this.Course.Equals(student.Course))) return false;

            return true;
        }

        // Source: http://stackoverflow.com/questions/371328/why-is-it-important-to-override-gethashcode-when-equals-method-is-overridden
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + this.Ssn.GetHashCode();
            hash = (hash * 7) + this.Course.GetHashCode();

            return hash;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            // If both are null, or both are same instance, return true.
            if (Object.ReferenceEquals(firstStudent, secondStudent))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if ((Object)firstStudent == null || (Object)secondStudent == null)
            {
                return false;
            }

            // Return true if the fields match:
            return firstStudent.Ssn == secondStudent.Ssn;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent == secondStudent);
        }

        //Problem 2. ICloneable
        // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            Student deepCopy = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.Course);
            deepCopy.Email = this.Email;
            deepCopy.PhoneNumber = this.PhoneNumber;
            deepCopy.University = this.University;
            deepCopy.Faculty = this.Faculty;
            deepCopy.Specialty = this.Specialty;

            return deepCopy;
        }

        /*
         * Problem 3. IComparable
         * Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
         * and by social security number (as second criteria, in increasing order).
         */


        public int CompareTo(Student otherStudent)
        {
            var currentStFullName = string.Concat(this.FirstName, this.MiddleName, this.LastName);
            var otherStFullName = string.Concat(otherStudent.FirstName, otherStudent.MiddleName, otherStudent.LastName);

            var comparisonResult = currentStFullName.CompareTo(otherStFullName);

            if (comparisonResult == 0)
            {
                return this.Ssn.CompareTo(otherStudent.Ssn);
            }

            return comparisonResult;
        }
    }
}
