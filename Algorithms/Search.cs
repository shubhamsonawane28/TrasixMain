using System;

namespace TrasixDataStructureAndAlgorithm.Algorithms
{
    internal class Search
    {
        int[] container;

        public Search(int[] containerToBeSearched)
        {
            this.container = containerToBeSearched;
        }

        public int sequentialSearch(int data)
        {
            int index = -1;
            for(int i = 0; i < container.Length; i++)
            {
                if(data.Equals(container[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int binarySearch(int data)
        {
            int index = -1;

            int leftIndex = 0;
            int rightIndex = container.Length - 1;
            int midIndex = (leftIndex + rightIndex)/2;

            while(leftIndex<rightIndex)
            {
                if(container[midIndex]==data)
                {
                    index = midIndex;
                    break;
                }
                else if (container[midIndex] > data)
                {
                    rightIndex = midIndex;
                    midIndex = (leftIndex + rightIndex) / 2;
                }
                else
                {
                    leftIndex = midIndex;
                    midIndex = (leftIndex + rightIndex) / 2;
                }
            }
            return index;
        }
    }
}
