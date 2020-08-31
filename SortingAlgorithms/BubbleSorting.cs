using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public  class BubbleSorting : Sorting
    {
        public override int[] Sort(int[] unsortedArray)
        {
           
            int temp;
            for (int i = 0; i < unsortedArray.Length - 2; ++i)
            {
                for (int j = 0; j < unsortedArray.Length - 2; ++j)
                {
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        temp = unsortedArray[i + 1];
                        unsortedArray[i + 1] = unsortedArray[i];
                        unsortedArray[i] = temp;
                    }
                }
                
            }
            
            return unsortedArray;
        }
        
    }
}
