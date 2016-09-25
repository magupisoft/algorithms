using System;

namespace Magupisoft {
    public class MergeSorter{
        public int[] MergeSort(int[] unsortedNumbers){
            
            // If array is length 1, return array with single element
            if(unsortedNumbers.Length <= 1){
                return unsortedNumbers;
            }

            // Split up array for the middle 
            var middleIndex = unsortedNumbers.Length / 2;
            
            var leftArray = new int[middleIndex];
            var rightArray = new int[unsortedNumbers.Length - middleIndex];

            // Get Left array (we could use a for loop for creating manually a new array from start to middleindex position)
            // System.Array.Copy(..) does that job 
            Array.Copy(sourceArray: unsortedNumbers, destinationArray: leftArray, length: middleIndex);

            // Get Right array
            Array.Copy(sourceArray: unsortedNumbers, sourceIndex: middleIndex, 
                       destinationArray: rightArray, destinationIndex: 0, length: rightArray.Length);
            
            // Call recursively MergeSort fot splitting up array until it gets one element
            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            // Merge left and right arrays
            return Merge(leftArray, rightArray);
        }

        private int[] Merge(int[] left, int[] right){
            var leftLength = left.Length;
            var rightLength = right.Length;

            // Result array is the sum of left and right array in an ordered way
            var result = new int[leftLength + rightLength]; 
            
            int i = 0, j = 0, k = 0; // i = left index, j = right index, k = result index
            // Compare left array to right array and put result in the result array
            while(i < leftLength && j < rightLength){
                if(left[i] <= right[j]){ 
                    result[k++] = left[i++];
                }else{
                    result[k++] = right[j++];
                }
            }
            
            // Put into result array the tail from left array
            while(i < leftLength){
                result[k++] = left[i++];
            }

            // Put into result array the tail from right array
            while(j < rightLength){
                result[k++] = right[j++];
            }

            return result;
        }
    }
}