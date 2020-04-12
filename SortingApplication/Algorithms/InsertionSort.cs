using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApplication.Algorithms
{
    class InsertionSort
    {
        readonly int[] arr = new int[10]
        {
            1, 5, 4, 11, 20, 8, 2, 98, 90, 16
        };

        private void _InsertionSort(int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        public void Execute()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _InsertionSort(arr);
            watch.Stop();
            var elapsedTicks = watch.Elapsed;

            //Console.WriteLine("Sorted Values:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            Console.WriteLine("Insertion Sort took {0} to complete", elapsedTicks);
        }

        public InsertionSort()
        {
            
        }
    }
}
