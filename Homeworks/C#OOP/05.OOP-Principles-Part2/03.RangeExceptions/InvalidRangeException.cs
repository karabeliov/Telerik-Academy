using System;
namespace _03.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;
        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public override string Message
        {
            get
            {
                return string.Format("{0} is out of the allowed range [{1}, {2}]", typeof (T).Name , Start, End);
            }
        }

        public T Start
        {
            get
            {
                return this.start;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
        }
    }
}
