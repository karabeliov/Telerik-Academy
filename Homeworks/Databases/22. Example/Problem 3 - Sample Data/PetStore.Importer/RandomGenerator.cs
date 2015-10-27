namespace PetStore.Importer
{
    using System;

    public class RandomGenerator : IRandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private static RandomGenerator instance;

        private readonly Random random;

        private RandomGenerator()
        {
            this.random = new Random();
        }

        public static RandomGenerator Instance
        {
            get
            {
                return instance ?? (instance = new RandomGenerator());
            }
        }

        public DateTime GetRandomDate(int minDay, int minMonth, int minYear, double dayBeforeNow)
        {
            DateTime start = new DateTime(minYear, minMonth, minDay);
            DateTime before = DateTime.Today.AddDays(dayBeforeNow);
            Random gen = new Random();
            
            int range = (before - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string GetRandomString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Letters[this.GetRandomNumber(0, Letters.Length - 1)];
            }

            return new string(chars);
        }
    }
}
