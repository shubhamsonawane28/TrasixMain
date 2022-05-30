using System;


namespace TrasixDataStructureAndAlgorithm.DataStructures.LinkedList
{
    internal class LinkedListC
    {
        private static int nodeCount = 0;
        private Node node;
        private Node header = null;
        private Node tail = null;

        public int getNodeCount()
        {
            return nodeCount;
        }
        public void insertAtBeginning(int data)
        {
            LinkedListC.nodeCount++;
            this.node = new Node();
            if (this.header != null)
            {
               
                this.node.setData(data);
                this.node.setNextNode(this.header);
                this.header = this.node;
                LinkedListC.nodeCount++;
            }
            else
            {
                
                this.node.setData(data);
                this.node.setNextNode(null);
                this.header = this.node;
                this.tail = this.node;
                LinkedListC.nodeCount++;
            }
        }
        public void insertAtEnd(int data)
        {
           LinkedListC.nodeCount++;
           this.node = new Node();
           if(this.header != null)
            {
           
                this.node.setData(data);
                this.node.setNextNode(null);
                this.tail.setNextNode(this.node);
                this.tail = this.node;
                LinkedListC.nodeCount++;

            }
            else
            {
                
                this.node.setData(data);
                this.node.setNextNode(null);
                this.header = this.node;
                this.tail = this.node;
                LinkedListC.nodeCount++;
            }
        }
        public void insertAtPosition(int position,int data)
        {
            if(getNodeCount()+1>=position)
            {
                if(position==1)
                {
                    this.insertAtBeginning(data);
                }
                else if(position==(getNodeCount()+1))
                {
                    this.insertAtEnd(data);
                }
                else
                {
                    // create a node to insert and set data to it 
                    this.node = new Node();
                    this.node.setData(data);
                    this.node.setNextNode(null);

                    // traverse till the position 
                    int positionCounter = 1;
                    Node traversalPointer = this.header;
                    while (positionCounter != (position-1))
                    {
                        traversalPointer = traversalPointer.getNextNode();
                        positionCounter++;
                    }
                    // extract the address of nextnode and assign it to nextNode variable of newly created node
                    this.node.setNextNode(traversalPointer.getNextNode());
                    traversalPointer.setNextNode(this.node);
                    LinkedListC.nodeCount++;
                        // set nextNode data to the address of newly created node
                }
            }
            else
                Console.WriteLine("position number is exceding the length");
        }
        //deletion at begining 
        public void deleteFromBegining()
        {
            if(getNodeCount()==0 || this.header==null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                this.header = this.header.getNextNode();
            }
            LinkedListC.nodeCount--;
        }
        
        //deletion at end
        public void deleteFromEnd()
        {
            Node traversalPointer = this.header;

            while(traversalPointer.getNextNode().getNextNode()!=null)
            {
                traversalPointer = traversalPointer.getNextNode();
            }
            traversalPointer.setNextNode(null);
            LinkedListC.nodeCount--;
        }
        // deletion at given index
        public void deleteAtPosition(int position)
        {
            Node traversalPointer = this.header;
            if (position==1)
            {
                this.deleteFromBegining();
            }else if(position==getNodeCount())
            {
                this.deleteFromEnd();
            }
            else
            {
                
                int positionCounter = 1;
                while(positionCounter != position)
                {
                    traversalPointer=traversalPointer.getNextNode();
                    positionCounter++;
                }
                traversalPointer.setNextNode(traversalPointer.getNextNode().getNextNode());
                LinkedListC.nodeCount--;
            }
        }
        public void updateAt(int position,int data)
        {   if(getNodeCount()>=position)
            {
                int positionCounter = 1;
                Node traversalPointer = this.header;
                while (positionCounter != position)
                {
                    traversalPointer = traversalPointer.getNextNode();
                    positionCounter++;
                }
                traversalPointer.setData(data);
            }
            else
            {
                Console.WriteLine("Please provide valid position");
            }
        }
        public void traverseLinkedList()
        {
            Node traversalPointer = this.header;

            while(traversalPointer != null)
            {
                Console.WriteLine(traversalPointer.getData());
                traversalPointer = traversalPointer.getNextNode();
            }
        }
        public int findElement(int data)
        {
            Node traversalPointer = this.header;
            int positionOfElementTobeFound = 1;
            bool elementFoundFlag = false;
            while (traversalPointer != null)
            {
                if(traversalPointer.getData() == data)
                {
                    elementFoundFlag = true;
                    break;
                }
                traversalPointer = traversalPointer.getNextNode();
                positionOfElementTobeFound++;
            }
            
            return elementFoundFlag ? positionOfElementTobeFound : -1;

        }
    }
}
