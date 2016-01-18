namespace CompareSortAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortAlgorithms
    {
        static void Main()
        {
            //  result
            //  Array size:               1000     10000    100000

            //  Data set to all ones:
            //  Internal (lib)            0.00      0.01      0.03
            //  Quicksort                 0.02      0.27      3.18
            //  Radix sort                0.01      0.05      0.53
            //  Shellsort                 0.03      0.36      4.44
            //  Bubblesort                0.00      0.01      0.09
            //  Insertion sort            0.00      0.02      0.26

            //  Data ascending sequence:
            //  Internal (lib)            0.00      0.00      0.02
            //  Quicksort                 0.02      0.15      1.82
            //  Radix sort                0.02      0.18      2.10
            //  Shellsort                 0.03      0.37      4.44
            //  Bubblesort                0.00      0.01      0.09
            //  Insertion sort            0.01      0.03      0.27

            //  Data randomly shuffled:
            //  Internal (lib)            0.00      0.02      0.44
            //  Quicksort                 0.02      0.26      3.17
            //  Radix sort                0.02      0.17      2.08
            //  Shellsort                 0.04      0.73     11.57
            //  Bubblesort                0.69     69.70   >100.00
            //  Insertion sort            0.55     55.54   >100.00

            //  Data descending sequence:
            //  Internal (lib)            0.00      0.01      0.10
            //  Quicksort                 0.01      0.15      1.90
            //  Radix sort                0.02      0.17      2.06
            //  Shellsort                 0.03      0.50      6.39
            //  Bubblesort                0.95     94.77   >100.00
            //  Insertion sort            1.11   >100.00   >100.00

            Stopwatch timer = new Stopwatch();
            double[] a = new double[1000];
            for (int time = 0; time < 10; time++)
            {
                timer.Start();
                for (int i = 0; i <= 1000; i++)
                {
                }

                timer.Stop();

                Console.WriteLine("RunTime " + timer.Elapsed);
                timer.Restart();
            }
        }

        public static T[] PerformInsertionSort<T>(T[] inputarray, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (var counter = 0; counter < inputarray.Length - 1; counter++)
            {
                var index = counter + 1;
                while (index > 0)
                {
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
                    {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }

        public static void PerformSelectionSort<T>(T[] arr)
        {
            int i, j;
            int len = arr.Length;
            for (i = 0; i < len; i++)
            {
                int min = i;
                for (j = i + 1; j < len; j++)
                {
                    if ((dynamic)arr[j] < arr[min]) min = j;
                }

                T temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public static void PerformQuickSort<T>(T[] arr, int left, int right)
            where T : IComparable
        {
            int i = left, j = right;
            T pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                PerformQuickSort(arr, left, j);
            }

            if (i < right)
            {
                PerformQuickSort(arr, i, right);
            }
        }
    }
}
