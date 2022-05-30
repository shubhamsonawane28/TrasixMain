using System;

namespace TrasixDataStructureAndAlgorithm.DataStructures
{
    internal class Stack
    {
        private int stackSize;
        private int stackTop = -1;

        private int[] stackContainer;
        public Stack(int size)
        {
            stackSize = size;
            stackContainer = new int[size];
        }
        public bool isStackEmpty()
        {
            return stackTop == -1;
        }
        public bool isStackFull()
        {
            return stackTop == stackContainer.Length-1;
        }
        public void seeStack()
        {
            for(int i = 0; i < stackContainer.Length; i++)
            {
                Console.WriteLine(stackContainer[i]);
            }
        }
        // resizing functionality will be added later
        public void push(int stackItem)
        {
            if(!isStackFull())
            {
                //if (isStackEmpty())
                    //stackTop++;

                stackContainer[++stackTop] = stackItem;
                //Console.WriteLine(stackContainer);
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }
        public int pop()
        {
            if(isStackEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return stackContainer[stackTop--];
            }
        }
        public void fetchStackContent()
        {
            if(!isStackEmpty())
            {
                
                for (int i = stackTop; i>= 0; i--)
                {
                    Console.WriteLine(stackContainer[i]);
                }
            }
        }
    }
}
