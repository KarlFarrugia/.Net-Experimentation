using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApplication.Algorithms
{
    class BubbleSort
    {
        readonly int[] arr = new int[10]
        {
            1, 5, 4, 11, 20, 8, 2, 98, 90, 16
        };

        private void _BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
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
            _BubbleSort(arr);
            watch.Stop();
            var elapsedTicks = watch.Elapsed;

            //Console.WriteLine("Sorted Values:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            Console.WriteLine("Bubble Sort took {0} to complete", elapsedTicks);
        }

        public BubbleSort()
        {
            
        }
    }
}
