using System;

namespace TrasixDataStructureAndAlgorithm.DataStructures
{
    internal class ArrayList
    {
        int curruntPosition;
        Object[] container;
        Object[] temContainer;

        public ArrayList()
        {
            curruntPosition = 0;
            container = new object[1];
        }
        private void adjustSize()
        {
            if (curruntPosition >= container.Length)
            {
                int newSize = container.Length * 2;
                temContainer = new object[newSize];
                for (int i = 0; i < container.Length; i++)
                {
                    temContainer[i] = container[i];
                }
                container = temContainer;
            }
            else if (curruntPosition <= container.Length / 2)
            {
                int newSize = container.Length / 2;
                temContainer = new object[newSize];
                for (int i = 0; i <= curruntPosition; i++)
                {
                    temContainer[i] = container[i];
                }
                container = temContainer;
            }
        }
        public void addElement(Object item)
        {
            if(curruntPosition >= container.Length)
            {
                adjustSize();
            }
            container[curruntPosition++] = item;
        }
        public int getCapacity()
        {
            return container.Length;
        }
        public void FetchList()
        {
            for (int i = 0; i < curruntPosition; i++)
            {
                Console.WriteLine(container[i]);
            }
        }
        public void deleteFromEnd()
        {
            container[--curruntPosition] = null;
            if(curruntPosition <= container.Length/2)
            {
                adjustSize();
            }
        }
        public void deleteElementAt(int index)
        {
            for(int i = index; i < curruntPosition; i++)
                container[i] = container[i+1];

            curruntPosition--;
        }
    }
}
