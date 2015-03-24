using System;

namespace SchoolClasses
{
    // Disciplines have name, number of lectures and number of exercises
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string discName, int lecturesNum, int exercisesNum)
        {
            this.Name = discName;
            this.NumberOfLectures = lecturesNum;
            this.NumberOfExercises = exercisesNum;
        }

        public Discipline(string discName, int lecturesNum, int exercisesNum, string comment)
            : this(discName, lecturesNum, exercisesNum)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name of discipline cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures cannot be a negative number!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises cannot be a negative number !");
                }

                this.numberOfExercises = value;
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

        public override string ToString()
        {
            return string.Format("Discipline name = {0}, LecturesNum = {1}, Exr.Num = {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
