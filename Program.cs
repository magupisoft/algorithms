using System;
using Magupisoft;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var unsortedNumbers = new int[]{
                20, 1, 3, 49, 45, 23,
                56, 9, 5, 67, 89, 4,
                39, 7, 24, 25, 2, 0,
                28, 17, 11, 78, 6, 27,
                8, 34, 58, 99, 45, 39};

            Console.WriteLine("Merge Sort example:");
            var stopWatch = Stopwatch.StartNew();
            MergeSort(unsortedNumbers);
            stopWatch.Stop();
            Console.WriteLine("Merge Sort execution time: " + stopWatch.Elapsed.TotalMilliseconds + " ms");
        }

        private static void MergeSort(int[] numbers){        
            var sorter = new MergeSorter();
            var sortedNumbers = sorter.MergeSort(numbers);
            for(var i = 0; i < sortedNumbers.Length; i ++){
                Console.WriteLine(string.Format("Number at position [{0}] = {1}", i, sortedNumbers[i]));
            }
            Console.ReadKey();
        }
    }
}
