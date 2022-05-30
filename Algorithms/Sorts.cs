using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasixDataStructureAndAlgorithm.Algorithms
{
    internal class Sorts
    {


        int[] container;

        public Sorts(int [] tempContainer)
        {
            container = tempContainer;
        }

        public void quickSort(int low,int high)
        {
            if(low<high)
            {
                int pivotPoint = partionioning(low,high); 

                quickSort(low, pivotPoint - 1);
                quickSort(pivotPoint+1,high);
            }
        }
        private int partionioning(int low , int high)
        {
            int pivot = container[high];
            int pivotPointer = low-1; 

            for(int iterartor = low; iterartor <= high-1; iterartor++ )
            {
                if( container[iterartor] <= pivot )
                {
                    pivotPointer++;
                    swap(pivotPointer, iterartor);
                }

            }
            swap(pivotPointer+1, high);
            return pivotPointer + 1;
        }
        private void swap( int firstNumber, int secondnumber)
        {
            int temp = container[firstNumber];
            container[firstNumber] = container[secondnumber];
            container[secondnumber] = temp;
        }
        public void insertionSort()
        {
            int n = container.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = container[i];
                int j = i - 1;
                while (j >= 0 && container[j] > key)
                {
                    container[j + 1] = container[j];
                    j = j - 1;
                }
                container[j + 1] = key;
            }
        }
        public void  selectionSort()
        {
            int n = container.Length;
            for (int i = 0; i < n - 1; i++)
            {
                
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (container[j] < container[min_idx])
                        min_idx = j;

                int temp = container[min_idx];
                container[min_idx] = container[i];
                container[i] = temp;
            }
        }
        public void fetch()
        {
            foreach(int i in container)
            {
                Console.Write(" "+i);
            }
        }
    }
}
