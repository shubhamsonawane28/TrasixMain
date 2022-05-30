using System;
using TrasixDataStructureAndAlgorithm.DataStructures;

namespace TrasixDataStructureAndAlgorithm.DataStructures.BinaryTree
{
    internal class BinaryTree
    {
        private BinaryNode rootElement;

        int  nodeValue = -1;
        static int nodeCount = 0;
        public int getCountOfNode()
        {
            return nodeCount;
        }
        public BinaryNode createBinaryTree(int[] nodes)
        {
            nodeValue++;
            if (nodes[nodeValue]==-1)
            {
                return null;
            }else if (nodeValue==0)
            {
                rootElement = new BinaryNode(nodes[nodeValue]);
                rootElement.setLeftNode(createBinaryTree(nodes));
                rootElement.setRightNode(createBinaryTree(nodes));
                nodeCount++;
                return rootElement;
            }
            else
            {
                BinaryNode tempNode = new BinaryNode(nodes[nodeValue]);
                tempNode.setLeftNode(createBinaryTree(nodes));
                tempNode.setRightNode(createBinaryTree(nodes));
                nodeCount++;
                return tempNode;

            }
        }
        public void preOrderTraversal(BinaryNode root)
        {
            if (root == null)
                return;
            Console.WriteLine(""+root.getData());
            preOrderTraversal(root.getLeftNode());
            preOrderTraversal(root.getRightNode());
        }
        public void inOrderTraversal(BinaryNode root)
        {
            if (root == null)
                return;
            inOrderTraversal(root.getLeftNode());
            Console.WriteLine("" + root.getData());
            inOrderTraversal(root.getRightNode());
        }
        public void postOrderTraversal(BinaryNode root)
        {
            if (root == null)
                return;
            postOrderTraversal(root.getLeftNode());
            postOrderTraversal(root.getRightNode());
            Console.WriteLine("" + root.getData());
        }
        public void levelOrderTraversal(BinaryNode root)
        {
            BinaryNode parentNode = rootElement;
            Queue<BinaryNode> levelElement = new Queue<BinaryNode>(BinaryTree.nodeCount);
            levelElement.pushToQueue(rootElement);

           while(!levelElement.isQueueEmpty())
            {
                if (parentNode.getLeftNode() != null && parentNode.getRightNode() != null)
                {
                    
                    levelElement.pushToQueue(parentNode.getLeftNode());
                    levelElement.pushToQueue(parentNode.getRightNode());
                    BinaryNode tempnode = levelElement.popFromQueue();
                    parentNode = levelElement.getFirstElement();
                    Console.WriteLine(tempnode.getData());
                }
                else if (parentNode.getLeftNode()!=null)
                {
                    levelElement.pushToQueue(parentNode.getLeftNode());
                    BinaryNode tempnode = levelElement.popFromQueue();
                    parentNode = levelElement.getFirstElement();
                    Console.WriteLine(tempnode.getData());
                }
                else  if(parentNode.getRightNode()!=null)
                {
                    levelElement.pushToQueue(parentNode.getRightNode());
                    BinaryNode tempnode = levelElement.popFromQueue();
                    parentNode = levelElement.getFirstElement();
                    Console.WriteLine(tempnode.getData());
                }
                else
                {
                    BinaryNode tempnode = levelElement.popFromQueue();
                    parentNode = levelElement.getFirstElement();
                    Console.WriteLine(tempnode.getData());
                }
                //we have
            }
          }
        public void addNode(int data)
        {
            nodeCount++;
            BinaryNode newNode = new BinaryNode(data);
  
                BinaryNode parentNode = findParentofMissingChild();
                if(parentNode.getLeftNode() == null)
                {
                    parentNode.setLeftNode(newNode);
                }else if(parentNode.getRightNode() == null)
                {
                    parentNode.setRightNode(newNode);
                }
        }
        private BinaryNode findParentofMissingChild()
        {
            //BinaryNode[] levelElement = new BinaryNode[nodeCount];
            BinaryNode parentNode = rootElement;
            Queue<BinaryNode> levelElement = new Queue<BinaryNode>(BinaryTree.nodeCount);
            levelElement.pushToQueue(rootElement);

            while(parentNode!=null)
            {
                if(parentNode.getLeftNode() == null || parentNode.getRightNode()==null)
                {
                    break;
                }
                else
                {
                    levelElement.pushToQueue(parentNode.getLeftNode());
                    levelElement.pushToQueue(parentNode.getRightNode());
                    levelElement.popFromQueue();
                    parentNode = levelElement.getFirstElement();  
                }
            }
            return parentNode;
        }
        
        private BinaryNode getSingleNode(BinaryNode node)
        {
            return node.getLeftNode()!=null ? node.getLeftNode() : node.getRightNode();
        }
        private bool isNodeLeafNode(BinaryNode nodeTobeDeleted)
        {
           return nodeTobeDeleted.getLeftNode() == null && nodeTobeDeleted.getRightNode() == null ? true : false;
        }
        private bool isNodeHave2Childrens(BinaryNode node)
        {
            return node.getLeftNode() != null && node.getRightNode() != null ? true : false;
        }
        private bool isNodeHaveSingleChild( BinaryNode nodeTobeDeleted)
        {
           return (nodeTobeDeleted.getLeftNode() != null && nodeTobeDeleted.getRightNode() == null) || (nodeTobeDeleted.getLeftNode() == null && nodeTobeDeleted.getRightNode() != null) ? true : false;
        }
        private bool isRightNode(BinaryNode node , int data)
        {
            return node.getRightNode().getData() == data ? true : false;
        }
        BinaryNode getChildWithMaxValue(BinaryNode root)
        {
            return root.getRightNode().getData()>=root.getLeftNode().getData() ? root.getRightNode() : root.getLeftNode();
        }
        private BinaryNode adjustTreeAndReturnNode(BinaryNode rootNode)
        {
            if(isNodeLeafNode(rootNode))
                return rootNode;
            else if(isNodeHaveSingleChild(rootNode))
            {
                return getSingleNode(rootNode);
            }
            else
            {
                rootNode = getChildWithMaxValue(rootNode);
                BinaryNode tempNode = adjustTreeAndReturnNode(rootNode);
                BinaryNode previousNode = rootNode;
                if(tempNode.getData() == rootNode.getLeftNode().getData())
                {
                    tempNode.setRightNode(rootNode.getRightNode());
                }
                else
                {
                    tempNode.setLeftNode(rootNode.getLeftNode());
                }
                return previousNode;
            }
            
        }
    }
}
