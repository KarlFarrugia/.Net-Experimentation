using SortingApplication.Algorithms;
using System;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort mergeSort = new MergeSort();
            SelectionSort selectionSort = new SelectionSort();
            InsertionSort insertionSort = new InsertionSort();
            BubbleSort bubbleSort = new BubbleSort();
            CountingSort countingSort = new CountingSort();
            QuickSort quickSort = new QuickSort();

            mergeSort.Execute();
            selectionSort.Execute();
            insertionSort.Execute();
            bubbleSort.Execute();
            countingSort.Execute();
            quickSort.Execute();

            Console.ReadLine();
        }
    }
}
