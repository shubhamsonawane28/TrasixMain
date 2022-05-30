using System;


namespace TrasixDataStructureAndAlgorithm.DataStructures
{
    internal class Queue <Type>
    {
        int front = 0;
        int back = -1;
        public Type[] queue;
        int queueSize;
        int queElementCount=0;

        public Queue(int queueSize)
        {
            this.queueSize = queueSize;
            this.queue = new Type[queueSize];
        }
        public bool isQueueFull()
        {
            return queElementCount == queueSize-1;
        }
        public bool isQueueEmpty()
        {
            return back==-1;
        }
        public Type getFirstElement()
        {
            return queue[front];
        }
        public void pushToQueue(Type queueItem)
        {
            if(!isQueueFull())
            {
                queue[++back] = queueItem;
                queElementCount++;
            }
            else
                Console.WriteLine("Queue is full");
        }
        public Type popFromQueue ()
        {
            //Type returnvalue = this.queue[front];
            if(!isQueueEmpty())
            {
                Type data = queue[0];
                for (int i = 0; i <= back; i++)
                {
                    queue[i] = queue[i+1];
                }
                back--;
                queElementCount--;
                return data;
            }
            else
                Console.WriteLine("Queue is empty");
            return default(Type) ;
        }
        public void fetchQueueData()
        {
            for (int i = 0; i < queElementCount; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
