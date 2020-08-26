using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;




namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of an array that you want to sort");
            int size = Convert.ToInt32(Console.ReadLine());
            
            int[] unsortedArray = new int[size];
            Random random = new Random();
            Console.WriteLine("Original array elements:" );
            for(int i = 0; i< unsortedArray.Length;i++)
            { 
                unsortedArray[i] = random.Next(0,100);
                Console.Write(unsortedArray[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter the algorithms you want to use to sort your array");

            string algorithms = Console.ReadLine();

            if (algorithms == "All")
            {
                
                var watch1 = new System.Diagnostics.Stopwatch();
                watch1.Start();
                var sortedBubbleSort = BubbleSorting.BubbleSort(unsortedArray);
                watch1.Stop();
                var time1 = watch1.ElapsedMilliseconds;
                
                Print(sortedBubbleSort);
                
                var watch2 = new System.Diagnostics.Stopwatch();
                watch2.Start();
                var sortedByInsertionSort = InsertionSorting.InsertionSort(unsortedArray);
                watch2.Stop();
                var time2 = watch2.ElapsedMilliseconds;
                Print(sortedByInsertionSort);
                
                var watch3 = new System.Diagnostics.Stopwatch();
                watch3.Start();
                var sortedByMergeSort = MergeSorting.MergeSort(unsortedArray);
                watch3.Stop();
                var time3 = watch3.ElapsedMilliseconds;
                Print(sortedByMergeSort);
                
                Console.WriteLine($"Execution Time for Bubble Sort: {time1} ms");
                Console.WriteLine($"Execution Time for Insertion Sort: {time2} ms");
                Console.WriteLine($"Execution Time for Merge Sort: {time3} ms");
            }

            string[] algs = algorithms.Split(',');

            foreach (var algorithm in algs)
            {
                switch (algorithm)
                {
                    case "1" :
                        var watch1 = new System.Diagnostics.Stopwatch();
                        watch1.Start();
                        var sortedBubbleSort = BubbleSorting.BubbleSort(unsortedArray);
                        watch1.Stop();
                        Console.WriteLine($"Execution Time for Bubble Sort: {watch1.ElapsedMilliseconds} ms");
                        Print(sortedBubbleSort);
                        break;
                    case "2" :
                        var watch2 = new System.Diagnostics.Stopwatch();
                        watch2.Start();
                        var sortedByInsertionSort = InsertionSorting.InsertionSort(unsortedArray);
                        watch2.Stop();
                        Console.WriteLine($"Execution Time for Insertion Sort: {watch2.ElapsedMilliseconds} ms");
                        Print(sortedByInsertionSort);
                        break;
                    case "3" :
                        var watch3 = new System.Diagnostics.Stopwatch();
                        watch3.Start();
                        var sortedByMergeSort = MergeSorting.MergeSort(unsortedArray);
                        watch3.Stop();
                        Console.WriteLine($"Execution Time for Merge Sort: {watch3.ElapsedMilliseconds} ms");
                        Print(sortedByMergeSort);
                        break;
 
                }
            }
            
        }
        public static void Print(int[] sortedArray)
        {
            foreach (var i in sortedArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
