using System;

namespace Methods
{
    class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(IPerson other)
        {
            DateTime firstDate, secondDate;

            try
            {
                firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            }
            catch (Exception)
            {
                throw new InvalidCastException("First data is not valid!");
            }

            try
            {
                secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            }
            catch (Exception)
            {

                throw new InvalidCastException("Second data is not valid!");
            }
            
            return firstDate < secondDate;
        }
    }
}
