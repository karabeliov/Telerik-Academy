namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat : Animals, ISound
    {
        private string song;

        public Cat()
        { 
        }
        public Cat(string name, string sex, int age, string song) 
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

            protected set
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
