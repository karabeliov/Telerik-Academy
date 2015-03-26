namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Frog : Animals, ISound
    {
        private string song;

        public Frog(string name, string sex, int age, string song) 
            : base(name, sex, age)
        {
            this.Song = song;
        }

        public string Song
        {
            get
            {
                return this.song;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Song of animal cannot be emty");
                }

                this.song = value;
            }
        }
    }
}
