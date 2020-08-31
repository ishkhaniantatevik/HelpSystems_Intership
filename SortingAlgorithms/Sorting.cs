using System;

namespace SortingAlgorithms
{
    public  abstract class Sorting
    {
        public abstract int[] Sort(int[] unsortedArray);

        public virtual void Print(int[] sortedArray)
        {
            foreach (var i in sortedArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        
    }
}
