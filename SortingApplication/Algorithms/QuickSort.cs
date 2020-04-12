using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApplication.Algorithms
{
    class QuickSort
    {
        readonly int[] arr = new int[10]
        {
            1, 5, 4, 11, 20, 8, 2, 98, 90, 16
        };

        private void _QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                _QuickSort(arr, start, i - 1);
                _QuickSort(arr, i + 1, end);
            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        public void Execute()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _QuickSort(arr, 0, arr.Length - 1);
            watch.Stop();
            var elapsedTicks = watch.Elapsed;

            //Console.WriteLine("Sorted Values:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            Console.WriteLine("Quick Sort took {0} to complete", elapsedTicks);
        }

        public QuickSort()
        {
            
        }
    }
}
