namespace tastFrom5to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
    {
        private const int DEFAULT_SIZE = 16;
        private int index = 0;
        private T[] list;
        
        public GenericList()
        {
            this.list = new T[DEFAULT_SIZE];
        }

        public GenericList(int size)
            : this()
        {
            if (size < 0)
            {
                throw new IndexOutOfRangeException("Size must be bigger then zero");
            }

            this.list = new T[size];
        }

        public void Add(T element)
        {
            if (index == list.Length)
            {
                Resize();
            }

            list[index] = element;
            index++;
        }

        private void Resize()
        {
            int size = list.Length * 2;
            T[] newList = new T[size];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            list = newList;
        }

        public T ElementAt(int position)
        {
            if (position < 0 || position > list.Length - 1 )
            {
                throw new IndexOutOfRangeException("Invalid position");
            }

            return list[position];
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position > list.Length - 1)
            {
                throw new IndexOutOfRangeException("Invalid position");
            }

            list[position] = default(T);
        }

        public void InsertAt(int position, T value)
        {
            if (position < 0 || position > index)
            {
                throw new IndexOutOfRangeException("Invalid position");
            }

            list[position] = value;
        }

        public void Clean()
        {
            Array.Clear(list, 0, list.Length);
        }

        public int GetIndex(T value)
        {
            return list.ToList().IndexOf(value);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < index; i++)
            {
                result.Append(list[i] + ", ");
            }

            return result.ToString().TrimEnd(',', ' ');
        }

        public int Capacity 
        { 
            get
            {
                return list.ToList().Capacity;
            }
        }

        public int Count
        {
            get
            {
                return index;
            }
        }

        public T Min() 
        {
            T[] newList = new T[index];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }

            T min = newList.Min();

            return min;
        }

        internal T Max()
        {
            T[] newList = new T[index];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }

            T max = newList.Max();

            return max;
        }
    }
}
