using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class InsertionSorting
    {
        public static int[] InsertionSort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length-1; i++) 
            {
                
                for (int j = i+1; j > 0; j--)
                {
                    if (unsortedArray[j - 1] > unsortedArray[j])
                    {
                        int temp = unsortedArray[j - 1];
                        unsortedArray[j - 1] = unsortedArray[j];
                        unsortedArray[j] = temp;
                    }
                }
                
            }    
            
            return unsortedArray;
        }
        
       
    }
}
