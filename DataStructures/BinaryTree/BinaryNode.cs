using System;


namespace TrasixDataStructureAndAlgorithm.DataStructures.BinaryTree
{
    internal class BinaryNode
    {
        int data;
        BinaryNode leftNode;
        BinaryNode rightNode;

        public BinaryNode(int data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public void setLeftNode(BinaryNode leftNode)
        {
            this.leftNode = leftNode;
        }
        public void setRightNode(BinaryNode rightNode)
        {
            this.rightNode = rightNode;
        }
        public int getData()
        {
            return data;
        }
        public BinaryNode getLeftNode()
        {
            return leftNode;
        }
        public BinaryNode getRightNode()
        {
            return rightNode;
        }
    }
}
