

namespace TrasixDataStructureAndAlgorithm.DataStructures.LinkedList
{
    internal class Node
    {
        private int data;
        private Node nextNode;

        public void setData(int data)
        {
            this.data = data;
        }
        public int getData()
        {
            return this.data;
        }
        public void setNextNode(Node nextNode)
        {
            this.nextNode = nextNode;
        }
        public Node getNextNode()
        {
            return (this.nextNode);
        }
    }
}
