using System;
using TrasixDataStructureAndAlgorithm.DataStructures;
using TrasixDataStructureAndAlgorithm.DataStructures.LinkedList;
using TrasixDataStructureAndAlgorithm.Algorithms;
using TrasixDataStructureAndAlgorithm.Algorithms;
namespace TrasixDataStructureAndAlgorithm.DataStructures.BinaryTree;

class Program
{
    public static void Main(string[] args)
    {
        // 
        string choice = "y";
        
        while (choice == "y" || choice =="Y")
        {
            try
            {
                Console.WriteLine("Please select valid option : ");
                Console.WriteLine("1 . Store data : ");
                Console.WriteLine("2 . Sort data : ");
                Console.WriteLine("3 . Search data : ");
                Console.WriteLine("Enter your choice (1/2/3):");
                int selection = Convert.ToInt32(Console.ReadLine());



                switch (selection)
                {
                    case 1:
                        int selectionDatastrucure;
                        do
                        {
                            Console.WriteLine("Please select datastrucuture : ");
                            Console.WriteLine("1 . Stack : ");
                            Console.WriteLine("2 . Queue : ");
                            Console.WriteLine("3 . Linked List : ");
                            Console.WriteLine("4 . ArrayList : ");
                            Console.WriteLine("5 . Binary tree : ");
                            Console.WriteLine("6 . Exit ");
                            Console.WriteLine("Enter your choice (1/2/3/4/5/6):");
                            selectionDatastrucure = Convert.ToInt32(Console.ReadLine());
                            switch (selectionDatastrucure)
                            {
                                case 1:
                                    int selectedStackOperation;
                                    Stack stack=null;
                                    do
                                    {
                                        Console.WriteLine("Please select operation : ");
                                        Console.WriteLine("1 . Create Stack : ");
                                        Console.WriteLine("2 . push : ");
                                        Console.WriteLine("3 . pop : ");
                                        Console.WriteLine("4 . Check Is stack Full ? : ");
                                        Console.WriteLine("5 . Check Is stack empty ? : ");
                                        Console.WriteLine("6 . Fetch stack content : ");
                                        Console.WriteLine("7 . Exit ");
                                        Console.WriteLine("Enter your choice (1/2/3/4/5/6):");
                                        selectedStackOperation = Convert.ToInt32(Console.ReadLine());
                                        switch (selectedStackOperation)
                                        {

                                            case 1:
                                                if (stack == null)
                                                {
                                                    Console.WriteLine("Please eneter the size of stack you want to create");
                                                    int size = Convert.ToInt32(Console.ReadLine());
                                                    stack = new Stack(size);
                                                    Console.WriteLine("Please enter the data you want to store");
                                                    while (!stack.isStackFull())
                                                    {
                                                        int dataT = Convert.ToInt32(Console.ReadLine());
                                                        stack.push(dataT);
                                                    }
                                                    Console.WriteLine("Stack is full, you cannot push any data ");
                                                }
                                                break;
                                            case 2:
                                                if (stack != null)
                                                { 
                                                   Console.WriteLine("Please enter data to be push");
                                                    int data = Convert.ToInt32(Console.ReadLine());
                                                    stack.push(data);
                                                }
                                                break;
                                            case 3:
                                                if(stack!=null)
                                                    Console.WriteLine(""+ stack.pop()+" popped from stack");
                                                break;
                                            case 4:
                                                if(stack!= null)
                                                {
                                                    String message = stack.isStackFull() ? "Stack is Full" : "Stack is not full";
                                                    Console.WriteLine(message);
                                                }
                                                break;
                                            case 5:
                                                if(stack!=null)
                                                {
                                                    String messageFull = stack.isStackEmpty() ? "Stack is empty" : "Stack is not empty";
                                                    Console.WriteLine(messageFull);
                                                }
                                                break;
                                            case 6:
                                                if(stack!=null)
                                                    stack.fetchStackContent();
                                                break;
                                            case 7:
                                                break;
                                            default:
                                                Console.WriteLine("Please select valid operation");
                                                break;
                                        }

                                    }
                                    while (selectedStackOperation != 7);
                                    break;
                                case 2:
                                    
                                    int selectedQueueOperation;
                                    Queue<int> queue = null;
                                    do
                                    {
                                        Console.WriteLine("Please select operation : ");
                                        Console.WriteLine("1 . Create Queue : ");
                                        Console.WriteLine("2 . push : ");
                                        Console.WriteLine("3 . pop : ");
                                        Console.WriteLine("4 . Check Is Queue Full ? : ");
                                        Console.WriteLine("5 . Check Is Queue empty ? : ");
                                        Console.WriteLine("6 . Fetch Queue content : ");
                                        Console.WriteLine("7 . Exit ");
                                        Console.WriteLine("Enter your choice (1/2/3/4/5/6/7):");
                                        selectedQueueOperation = Convert.ToInt32(Console.ReadLine());
                                        switch (selectedQueueOperation)
                                        {
                                            case 1:
                                                Console.WriteLine("Please enter size of queue: ");
                                                int qSize = Convert.ToInt32(Console.ReadLine());
                                                queue = new Queue<int>(qSize+1);
                                                Console.WriteLine("Enter the data for queue ");
                                                int i = 0;
                                                while(i<qSize)
                                                {
                                                    int qData = Convert.ToInt32(Console.ReadLine());
                                                    queue.pushToQueue(qData);
                                                    i++;
                                                }
                                                Console.WriteLine("Queue is full");
                                                break;
                                            case 2:
                                                Console.WriteLine("Please enter the data to be push");
                                                int queueData = Convert.ToInt32(Console.ReadLine());
                                                queue.pushToQueue(queueData);
                                                break;
                                            case 3:
                                                Console.WriteLine(""+queue.popFromQueue()+" is popped from queue");
                                                break;
                                            case 4:
                                                string queueMessage = queue.isQueueFull() ? "Queue is Full" : "Queue is not full";
                                                Console.WriteLine(queueMessage);
                                                break;
                                            case 5:
                                                string queueMessageEmpty = queue.isQueueEmpty() ? "Queue is Empty" : "Queue is not Empty";
                                                Console.WriteLine(queueMessageEmpty);
                                                break;
                                            case 6:
                                                queue.fetchQueueData();
                                                break;
                                            case 7:
                                                break;
                                            default:
                                                Console.WriteLine("Select valid choice");
                                                break;
                                        }
                                    }
                                    while (selectedQueueOperation != 7);
                                    break;
                                case 3:
                                    int selectedLinkedOperation;
                                    LinkedListC linkedListC = null;
                                    do
                                    {
                                        Console.WriteLine("Please select operation : ");
                                        Console.WriteLine("1 . Create linked List : ");
                                        Console.WriteLine("2 . Add element at end : ");
                                        Console.WriteLine("3 . Add element at beginig : ");
                                        Console.WriteLine("4 . Add at given position : ");
                                        Console.WriteLine("5 . Delete element at end : ");
                                        Console.WriteLine("6 . Delete element at beginig : ");
                                        Console.WriteLine("7 . Delete at given position : ");
                                        Console.WriteLine("8 . Update element at given position : ");
                                        Console.WriteLine("9 . Traverse Linked List: ");
                                        Console.WriteLine("10 . Find data in Linked List");
                                        Console.WriteLine("11 . Exit ");
                                        Console.WriteLine("Enter your choice (1/2/3/4/5/6/7/8/9/10/11):");
                                        selectedLinkedOperation = Convert.ToInt32(Console.ReadLine());
                                        switch (selectedLinkedOperation)
                                        {
                                            case 1:
                                                linkedListC = new LinkedListC();
                                                Console.WriteLine("please enter the size of Linked List");
                                                int linkedListSize = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("please Enter the Data to be store");
                                                for (int i = 0; i < linkedListSize; i++)
                                                {
                                                    int data = Convert.ToInt32(Console.ReadLine());
                                                    linkedListC.insertAtEnd(data);
                                                }
                                                Console.WriteLine("Linked List of size "+linkedListSize+" is created ");
                                                break;
                                            case 2:
                                                Console.WriteLine("Please enter data that is to be added at end :");
                                                int dataToBeAddAtEnd = Convert.ToInt32(Console.ReadLine());
                                                if(linkedListC!=null)
                                                {
                                                    linkedListC.insertAtEnd(dataToBeAddAtEnd);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                break;
                                            case 3:
                                                Console.WriteLine("Please enter data that is to be added at Start :");
                                                int dataToBeAddAtBegining = Convert.ToInt32(Console.ReadLine());
                                                if (linkedListC != null)
                                                {
                                                    linkedListC.insertAtBeginning(dataToBeAddAtBegining);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                break;
                                            case 4:
                                                Console.WriteLine("Please enter data that is to be added :");
                                                int dataToBeAddAt = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Please enter indexat which data to be added :");
                                                int index = Convert.ToInt32(Console.ReadLine());
                                                if (linkedListC != null)
                                                {
                                                    linkedListC.insertAtPosition(index, dataToBeAddAt);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                break;
                                            case 5:
                                                if (linkedListC != null)
                                                {
                                                    linkedListC.deleteFromEnd();
                                                    Console.WriteLine("deleted SuccessFully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                // delete at end
                                                break;
                                            case 6:
                                                if (linkedListC != null)
                                                {
                                                    linkedListC.deleteFromBegining();
                                                    Console.WriteLine("deleted SuccessFully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                // delete at begining
                                                break;
                                            case 7:
                                                if (linkedListC != null)
                                                {
                                                    Console.WriteLine("Please Enter the position at which you want to delete data");
                                                    int position = Convert.ToInt32(Console.ReadLine());
                                                    linkedListC.deleteAtPosition(position);
                                                    Console.WriteLine("deleted SuccessFully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                // delete at given position
                                                break;
                                            case 8:
                                               if(linkedListC != null)
                                                {
                                                    Console.WriteLine("Please Enter the position at which you want to update");
                                                    int positionUpdate = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Please Enter the data : ");
                                                    int dataUpdate = Convert.ToInt32(Console.ReadLine());
                                                    linkedListC.updateAt(positionUpdate, dataUpdate);
                                                    Console.WriteLine("updated SuccessFully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                // update
                                                break;
                                            case 9:
                                                if(linkedListC != null)
                                                {
                                                    linkedListC.traverseLinkedList();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                //travers
                                                break;
                                            case 10:
                                                if (linkedListC != null)
                                                {
                                                    Console.WriteLine("Please Enter the data  to be find: ");
                                                    int dataFind = Convert.ToInt32(Console.ReadLine());
                                                    int flag = linkedListC.findElement(dataFind);
                                                    String findMessage = flag == -1 ? "Data Not found" : "Data found at" + flag;
                                                    Console.WriteLine(findMessage);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Firstly create a linked List");
                                                }
                                                //find
                                                break;
                                            case 11:
                                                break;
                                            default:
                                                Console.WriteLine("Please select valid choice");
                                                break;
                                        }
                                    }
                                    while(selectedLinkedOperation != 11);

                                        break;
                                case 4:
                                    //Console.WriteLine("Array List");
                                    int selectedArrayListOperation;
                                    ArrayList arrayList = null;
                                    do
                                    {
                                        Console.WriteLine("1. Create a Array List");
                                        Console.WriteLine("2 . Add data in ArrayList");
                                        Console.WriteLine("3 . Delete data from end ");
                                        Console.WriteLine("4 . Delete data at given position  ");
                                        Console.WriteLine("5 . get Capacity of ArrayList  ");
                                        Console.WriteLine("6 . Fetch List ");
                                        Console.WriteLine("7 .Exit");
                                        selectedArrayListOperation = Convert.ToInt32(Console.ReadLine());
                                        switch(selectedArrayListOperation)
                                        {
                                            case 1:
                                                arrayList = new ArrayList();
                                                Console.WriteLine("Enter the Size for intial arrayList");
                                                int arrayListSize = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Please enter the data");
                                                for (int i = 0; i < arrayListSize; i++)
                                                {
                                                    var arrayListData = Convert.ToInt32(Console.ReadLine());
                                                    arrayList.addElement(arrayListData);
                                                }
                                                Console.WriteLine("Array List created of size "+arrayListSize);
                                                break;
                                            case 2:
                                                if(arrayList != null)
                                                {
                                                    Console.WriteLine("Please enter the data");
                                                    int arrayListData = Convert.ToInt32(Console.ReadLine());
                                                    arrayList.addElement(arrayListData);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create ArrayList first");
                                                }
                                                break;
                                            case 3:
                                                if (arrayList != null)
                                                {
                                                    arrayList.deleteFromEnd();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create ArrayList first");
                                                }
                                                break;
                                            case 4:
                                                if (arrayList != null)
                                                {
                                                    Console.WriteLine("Please enter position");
                                                    int position = Convert.ToInt32(Console.ReadLine());
                                                    arrayList.deleteElementAt(position);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create ArrayList first");
                                                }
                                                break;
                                            case 5:
                                                if(arrayList!=null)
                                                    Console.WriteLine("Capacity of ArrayList is "+arrayList.getCapacity());
                                                break;
                                            case 6:
                                                if(arrayList!=null)
                                                    arrayList.FetchList();
                                                break;
                                            default:
                                                Console.WriteLine("Please enter valid choice");
                                                break;
                                        }
                                    }
                                    while(selectedArrayListOperation != 7);
                                    break;
                                case 5:
                                    int selectedArrayBTOperation;
                                    BinaryTree binaryTree = null;
                                    BinaryNode root = null;
                                    do
                                    {
                                        Console.WriteLine("1. Create a Binary Tree");
                                        Console.WriteLine("2 . Add node");
                                        Console.WriteLine("3 . Traverse Inorder ");
                                        Console.WriteLine("4 . Traverse Pre-Order  ");
                                        Console.WriteLine("5 . Traverse Post-Order  ");
                                        Console.WriteLine("6 . Traverse Level-Order ");
                                        Console.WriteLine("7 .Exit");
                                        selectedArrayListOperation = Convert.ToInt32(Console.ReadLine());
                                        switch (selectedArrayListOperation)
                                        {
                                            case 1:
                                                //ArrayList nodes = new ArrayList();
                                                int[] nodes = null;
                                                binaryTree = new BinaryTree();
                                                Console.WriteLine("Please enter the number of nodes you want to store includig 'null' nodes");
                                                int numberOfNodes = Convert.ToInt32(Console.ReadLine());
                                                nodes = new int[numberOfNodes];
                                                Console.WriteLine("Please enter the nodes in Pre-Order  and -1 for null values ");
                                                for (int i = 0; i < numberOfNodes; i++)
                                                {
                                                    int node = Convert.ToInt32(Console.ReadLine());
                                                    nodes[i]=node;
                                                }
                                                root = binaryTree.createBinaryTree(nodes);
                                                Console.WriteLine("Binary Tree created ");
                                                break;
                                            case 2:
                                                if (binaryTree != null)
                                                {
                                                    Console.WriteLine("Please enter the node data");
                                                    int nodeData = Convert.ToInt32(Console.ReadLine());
                                                    binaryTree.addNode(nodeData);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create Binary tree first");
                                                }
                                                break;
                                            case 3:
                                                if (binaryTree != null && root!=null)
                                                {
                                                    binaryTree.inOrderTraversal(root);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create Binary tree first");
                                                }
                                                break;
                                            case 4:
                                                if (binaryTree != null && root != null)
                                                {
                                                    binaryTree.preOrderTraversal(root);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create Binary tree first");
                                                }
                                                break;
                                            case 5:
                                                if (binaryTree != null && root != null)
                                                {
                                                    binaryTree.postOrderTraversal(root);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create Binary tree first");
                                                }
                                                break;
                                            case 6:
                                                if (binaryTree != null && root != null)
                                                {
                                                    binaryTree.levelOrderTraversal(root);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("please create Binary tree first");
                                                }
                                                break;
                                            case 7:
                                                break;
                                            default:
                                                Console.WriteLine("Please enter valid choice");
                                                break;
                                        }
                                    }
                                    while (selectedArrayListOperation != 7);

                                    //Console.WriteLine("Binary tree");
                                    break;
                                default:
                                    Console.WriteLine("Please select valid option");
                                    break;
                            }
                        }
                        while (selectionDatastrucure != 6);
                        break;
                    case 2:
                        int sortChoice;
                        Console.WriteLine("Please enter the number of elements you want to sort");
                        int arraySize = Convert.ToInt32(Console.ReadLine());
                        int[] unsortedArray = new int[arraySize];
                        //Console.WriteLine("Enter the data");
                        Random randomNumberGenerator = new Random();
                        for (int i = 0; i < arraySize; i++)
                        {
                            unsortedArray[i] = randomNumberGenerator.Next(0,10);
                        }
                        Sorts sort = new Sorts(unsortedArray);
                        do
                        {
                            Console.WriteLine("Please select the sorting algorithm to sort");
                            Console.WriteLine("1 . Quick sort : ");
                            Console.WriteLine("2 . Selection sort");
                            Console.WriteLine("3 . Insertion sort");
                            Console.WriteLine("4 .Exit");
                            Console.WriteLine("Please select your choice (1/2/3/4):");
                            sortChoice = Convert.ToInt32(Console.ReadLine());
                            switch (sortChoice)
                            {
                                case 1:

                                    var firstTime = DateTime.Now;
                                    sort.quickSort(0, unsortedArray.Length - 1);
                                    var secondTime = DateTime.Now;
                                    var diff = secondTime.Subtract(firstTime).Ticks;
                                    Console.WriteLine("time taken by algo " + diff);
                                    /* Console.WriteLine("Unsorted array :");
                                     foreach (int i in unsortedArray)
                                     {
                                         Console.Write(i);
                                     }
                                     Console.WriteLine(" ");
                                     Console.WriteLine("Sorted array :");
                                     sort.fetch();*/
                                    break;
                                case 2:
                                    var firstTimeInsertion = DateTime.Now;
                                    sort.insertionSort();
                                    var secondTimeInsertion = DateTime.Now;
                                    var diffInsertion = secondTimeInsertion.Subtract(firstTimeInsertion).Ticks;
                                    Console.WriteLine("time taken by algo " + diffInsertion);
                                    // Console.WriteLine("Unsorted array :");
                                    /*foreach (int i in unsortedArray)
                                    {
                                        Console.Write(i);
                                    }*/
                                    /*Console.WriteLine(" ");
                                    Console.WriteLine("Sorted array :");
                                    sort.fetch();*/
                                    break;
                                case 3:
                                    var firstTimeSelection = DateTime.Now;
                                    sort.selectionSort();
                                    var secondSelection = DateTime.Now;
                                    var diffSelection = secondSelection.Subtract(firstTimeSelection).Ticks;
                                    Console.WriteLine("time taken by algo " + diffSelection);
                                    /*Console.WriteLine("Unsorted array :");
                                    foreach (int i in unsortedArray)
                                    {
                                        Console.Write(i);
                                    }
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Sorted array :");
                                    sort.fetch();*/
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Please enter valid choice");
                                    break;
                            }
                        }
                        while(sortChoice != 4);
                        break;
                    case 3:
                        Console.WriteLine("Select valid option"); 
                        Console.WriteLine("1 . Array is sorted ");
                        Console.WriteLine("2. Array is unsorted ");
                        Console.WriteLine("3.Exit");
                        Console.WriteLine("3.Please selct (1/2/3):");
                        int searchingOption = Convert.ToInt32(Console.ReadLine());
                        switch (searchingOption)
                        {
                            case 1:
                                Console.WriteLine("Please enter the number of elements array have");
                                int searchingArraySize = Convert.ToInt32(Console.ReadLine());
                                int[] sortedArray = new int[searchingArraySize];
                                Console.WriteLine("Enter the data");
                                for (int i = 0; i < searchingArraySize; i++)
                                {
                                    sortedArray[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                Search search = new Search(sortedArray);
                                Console.WriteLine("Please enter data to search");
                                int dataToSearch = Convert.ToInt32(Console.ReadLine());
                                int flag = search.binarySearch(dataToSearch);
                                String searchMessage = flag == -1 ? "Data not found" : "Data found at" + flag;
                                Console.WriteLine(searchMessage);
                                break;
                            case 2:
                                Console.WriteLine("Please enter the number of elements array have");
                                int searchingArraySizeUnsorted = Convert.ToInt32(Console.ReadLine());
                                int[] unSortedArray = new int[searchingArraySizeUnsorted];
                                Console.WriteLine("Enter the data");
                                for (int i = 0; i < searchingArraySizeUnsorted; i++)
                                {
                                    unSortedArray[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                Search searchUnsorted = new Search(unSortedArray);
                                Console.WriteLine("Please enter data to search");
                                int dataToSearchUnsorted = Convert.ToInt32(Console.ReadLine());
                                int flagUnsorted = searchUnsorted.sequentialSearch(dataToSearchUnsorted);
                                String searchMessageUnsorted = flagUnsorted == -1 ? "Data not found" : "Data found at" + flagUnsorted;
                                Console.WriteLine(searchMessageUnsorted);
                                break;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("Please select valid choice");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("please select valid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue ?(Y/N) : ");
                var tempChoice = Console.ReadLine();
                choice = tempChoice;
            }
            catch (Exception)
            {

                Console.WriteLine("Enter valid inputs");
            }

        }
    }
}