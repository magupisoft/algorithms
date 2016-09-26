using System;
using Magupisoft;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
         private static int[] unsortedNumbers = new int[]{
                20, 1, 3, 49, 45, 23,
                56, 9, 5, 67, 89, 4,
                39, 7, 24, 25, 2, 0,
                28, 17, 11, 78, 6, 27,
                8, 34, 58, 99, 4, 22 };
            
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Merge Sort example:");
            var numbersForMergeSort = new int[unsortedNumbers.Length];
            unsortedNumbers.CopyTo(numbersForMergeSort, 0);
            var stopWatch = Stopwatch.StartNew();
            MergeSort(numbersForMergeSort);
            stopWatch.Stop();
            Console.WriteLine("Merge Sort execution time: " + stopWatch.Elapsed.TotalMilliseconds + " ms");

            Console.WriteLine("\nQuick Sort example:");
            var numbersForQuickSort = new int[unsortedNumbers.Length];
            unsortedNumbers.CopyTo(numbersForQuickSort, 0);
            stopWatch = Stopwatch.StartNew();
            QuickSort(numbersForQuickSort);
            stopWatch.Stop();
            Console.WriteLine("Quick Sort execution time: " + stopWatch.Elapsed.TotalMilliseconds + " ms");
        }

        private static void MergeSort(int[] numbers){        
            var sorter = new MergeSorter();
            var sortedNumbers = sorter.MergeSort(numbers);
            for(var i = 0; i < sortedNumbers.Length; i ++){
                Console.WriteLine(string.Format("Number at position [{0}] = {1}", i, sortedNumbers[i]));
            }
            Console.ReadKey();
        }


        private static void QuickSort(int[] numbers){        
            var sorter = new QuickSorter();
            var sortedNumbers = sorter.QuickSort(numbers);
            for(var i = 0; i < sortedNumbers.Length; i ++){
                Console.WriteLine(string.Format("Number at position [{0}] = {1}", i, sortedNumbers[i]));
            }
            Console.ReadKey();
        }
    }
}
