namespace IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class IEnumerableList
    {
        public static T SumOfCollection<T>(this IEnumerable<T> collection) 
        {
            T result = (dynamic)0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOfCollection<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinElement<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T MaxElement<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        public static T AverageOfCollection<T>(this IEnumerable<T> collection)
        {
            return (dynamic)collection.SumOfCollection()/collection.Count();;
        }
    }
}
