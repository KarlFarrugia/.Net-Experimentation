using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApplication.Algorithms
{
    class SelectionSort
    {
        readonly int[] arr = new int[10]
        {
            1, 5, 4, 11, 20, 8, 2, 98, 90, 16
        };

        private void _SelectionSort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Execute()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _SelectionSort(arr);
            watch.Stop();
            var elapsedTicks = watch.Elapsed;

            //Console.WriteLine("Sorted Values:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            Console.WriteLine("Selection Sort took {0} to complete", elapsedTicks);
        }

        public SelectionSort()
        {
            
        }
    }
}
