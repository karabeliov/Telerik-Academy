namespace tastFrom5to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class tastFrom5to7
    {
        static void Main()
        {
            GenericList<int> listInt = new GenericList<int>();
            GenericList<string> listString = new GenericList<string>(60);

            listInt.Add(5);
            listInt.Add(6);
            listInt.Add(7);
            listInt.Add(8);

            listString.Add("Generic");
            listString.Add("List");
            int takeElement = listInt.ElementAt(0);

            // list.InsertAt(1, 5);
            // list.RemoveAt(0);
            // list.Clean();
            // int index = list.GetIndex(5);
            // int capacity = list.Capacity;
            // int count = list.Count;

            int min = listInt.Min();
            int max = listInt.Max();

            string minString = listString.Min();
            string maxString = listString.Max();

            Console.WriteLine(listInt);

            Console.WriteLine(listString);
        }
    }
}
