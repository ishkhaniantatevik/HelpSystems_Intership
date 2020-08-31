using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace SortingAlgorithms
{
    public class MergeSorting : Sorting
    {
        public override int[] Sort(int[] unsortedList)
        {
            if (unsortedList.Length <= 1)
                return unsortedList;
            
            int midPoint = unsortedList.Length / 2;
            int[] left;
            int[] right;

             left = new int[midPoint];
            if (unsortedList.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint+1];
            }

            
            for (int i = 0; i < midPoint;i++)
            {
                left[i] = unsortedList[i];

            }
            int x = 0;
            for (int i = midPoint; i < unsortedList.Length; i++)
            {
                right[x] = unsortedList[i];
                ++x;
            }
            
            left = Sort(left);
            right = Sort(right);
            
            return Merge(left, right);
        }

        public static int[] Merge(int[] left,int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;  
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)  
                {  
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
        }
            
        
    }
}
