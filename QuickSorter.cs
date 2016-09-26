namespace Magupisoft{
    public class QuickSorter{
        public int[] QuickSort(int[] unsortedNumbers){

            var length = unsortedNumbers.Length;
            if(length < 1){
                return unsortedNumbers;
            }
            
            return Sort(unsortedNumbers, 0, length - 1);
        }

        private int[] Sort(int[] numbers, int first, int last){
            var i = first;
            var j = last;
            var pivot = numbers[(first + last) / +2];

            // Iterate while i less than j 
            while (i < j){

                // Iterate while value of "numbers[i]"  less than pivot, 
                // so position in "i" increment in 1 because is not needed to change,
                // (it is in the right side of the array given the current pivot value)
                while(numbers[i] < pivot) i++;
                
                // Iterate while value of numbers[j] is greater than pivot,
                // so pisition in "j" decriment in 1 because is not needed to change
                while(numbers[j] > pivot) j--;

                // if "i" is less or equal to "j", it means that indexes have croissed
                if(i <= j){
                    var temp = numbers[j];

                    // swap numbers[i] and numbers[j] values
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                    
                    // increment i and dicrement j
                    i++;
                    j--;
                }
                
                // The follow are the exit conditions:
                // if "first" less than "j", call Sort recursively
                if(first < j){
                    numbers = Sort(numbers, first, j);
                }
                // if "last" greater thant "i", call Sort recursively
                if(last >  i){
                    numbers = Sort(numbers, i, last);
                }
            }

            return numbers;
        }
    }
}