namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Disciplines : IComment
    {
        private string name;
        private int numberLectures;
        private int numberExercises;

        public Disciplines()
        {
        }

        public Disciplines(string name, int numberLectures, int numberExercises)
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int NumberLectures 
        {
            get
            {
                return this.numberLectures;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Number of lectures cannot be negative number or zero");
                }

                this.numberLectures = value;
            }
        }

        public int NumberExercises 
        {
            get
            {
                return this.numberExercises;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of exercises cannot be negative number");
                }

                this.numberExercises = value;
            }
        }

        private List<string> comment = new List<string>();
        public void AddComment(string comment)
        {
            this.comment.Add(comment);
        }

        public string PrintComment()
        {
            return string.Join(", ", comment);
        }
    }
}
