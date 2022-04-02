using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace IBM_ASSESSMENT_PREP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = RemoveInvalidParenthesis("(v)())()");
            var res = "123".ToCharArray();
            Algorithms.countingValleys(12, "DDUUDDUDUUUD");
            String word = "AABBCCCBAT";
            Dictionary<Char, String> pairs = new Dictionary<Char, String>(); // HashMap
            foreach (Char _char in word)
            {
                if (!pairs.ContainsKey(_char)) //
                {
                    // add new key and value
                    pairs.Add(_char, _char.ToString());
                }
                else
                {
                    // update value for a key
                    pairs[_char] = pairs[_char] + _char.ToString();
                }
            };
            foreach (var pair in pairs)
            {
                if (pairs[pair.Key].Length >= 3)
                {
                    pairs.Remove(pair.Key);
                }
                else
                {
                    Console.WriteLine(pairs[pair.Key]);
                }
            };


            //------------------= RECURSIVE BST / BSTNODE  =----------------//
            BST bst = new BST();
            bst.Insert(2);
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(4);

            //----------------= LINKEDLIST =------------------//
            LinkedList lList = new LinkedList();
            //lList.AddFirst(6);
            //lList.AddFirst(9);
            //lList.AddFirst(3);
            lList.AddLast(16);
            lList.AddLast(13);
            lList.PrintLinkedList(lList.list);

            /**
	         * Given a triangle, find the minimum path sum from top to bottom. Each step
	         * you may move to adjacent numbers on the row below.	 * 
	         * For example, given the following triangle 
	         * [ 
	         *   [2], 
	         *  [3,4], 
	         * [6,5,7],
	         *[4,1,8,3] 
	         * ] 	  
	         * The minimum path sum from top to bottom is 11 (i.e., 2 + 3 +
	         * 5 + 1 = 11).
	         */
            List<List<int>> Triangle = new List<List<int>>();
            var row1 = new List<int>();
            row1.Add(5);
            Triangle.Add(row1);
            var row2 = new List<int>();
            row2.Add(2);
            row2.Add(1);
            row2.Add(6);
            Triangle.Add(row2);
            var row3 = new List<int>();
            row3.Add(9);
            row3.Add(10);
            row3.Add(4);
            Triangle.Add(row3);
            var minToLeaf = new Graph().ShortesPath(Triangle);
            Console.WriteLine(minToLeaf);

            //------Hacker Rank----//
            Algorithms alFun = new Algorithms();
            alFun.fizzBuzz(15);
            var list1 = new List<int>() { 1, 3, 5 };
            var list2 = new List<int>() { 3, 5, 7 };
            alFun.getMinCost(list1, list2);
            var list3 = new List<int>() { 1, 2, 3, 4, 5 };
            alFun.rotateList(4, list3);
            List<int> unSortedList = new List<int>() { 5, 3, 8, 0, 0, 2, 19 };
            alFun.InsertionSort(unSortedList);

            // ----- AVL TREE ------ //
            AvlTree avl = new AvlTree();
            avl.Insert(4);
            avl.Insert(3);
            avl.Insert(2);
        }

        /// <summary>
        /// Remove Odd paranthesis of a task
        /// task = ((A+)B) => (A+B)
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns>correct stringInput</returns>
        public static IEnumerable<string> RemoveInvalidParenthesis(string stringInput)
        {
            if (string.IsNullOrEmpty(stringInput)) return null;

            // Using Breath-First-Search Algorithm
            HashSet<string> visited = new HashSet<string>();
            visited.Add(stringInput);
            string temp;


            if (IsValidString(stringInput))
            {
                Console.WriteLine("We have a valid string : => " + stringInput);
            }

            for (int i = 0; i < stringInput.Length; i++)
            {
                if (!IsParenthesis(stringInput[i])) continue;

                //Removing parenthesis from inputString 
                // and pushing into queue if not visited
                temp = stringInput.Substring(0, i) + stringInput.Substring(i + 1);
                if (!visited.Contains(temp))
                {
                    visited.Add(temp);
                }
            }

            return visited.Where(item => IsValidString(item)); ;
        }

        private static bool IsValidString(string _string)
        {
            int count = 0;
            foreach (char _char in _string)
            {
                if (_char == '(')
                {
                    count++;
                }
                else if (_char == ')')
                {
                    count--;
                }

                if (count < 0)
                    return false;
            }
            return count == 0;
        }

        private static bool IsParenthesis(char _char)
        {
            return _char == '(' || _char == ')';
        }


        public class GreedyAlgorithm
        {
            public class StandardGreedyAlgorithm
            {
                public void ActivitySelectionProblem()
                {

                }
                public void EgyptianFraction()
                {

                }
                public void JobSequenceProblem()
                {

                }
                public void JobSequenceProlemOfDisjointSet()
                {

                }
                public void JobSequenceProblemOfLossMinimization()
                {

                }
                public void JobSequenceProblemOfLossMinimizaitionStrategy()
                {

                }
                public void HuffmanCoding()
                {

                }
                public void EfficientHuffmanCodingForSortedInput()
                {

                }
                public void HuffmanDecoding()
                {

                }
                public void WaterConnectionProblem()
                {

                }
                public void PolicemneCatchTrives()
                {

                }
                public void MinimumSwapsForBracketBalancing()
                {

                }
                public void FitingShelvesProblem()
                {

                }
                public void AssignMiceToHoles()
                {

                }
            }

            public class GreedyAlgorithmInGraph
            {
                public void KruskalMinimumSpanningTree()
                {

                }
                public void PrimMinimumSpanningTree()
                {

                }
                public void BrouvkaMinimumSpanningTree()
                {

                }
                public void ReverseDeleteForMST()
                {

                }
                public void DijkastraShortestPath()
                {

                }
                public void DialAlgorithm()
                {

                }
                public void DijkstraAlgorithForAdjacencyList()
                {

                }
                public void PrimMST_ForAdjacencyList()
                {

                }
                public void CorrectnessOfGreedyAlgorithm()
                {

                }
                public void MinimumCostOfConnection()
                {

                }
                public void MaxFlowProblemIntroduction()
                {

                }
                public void NumberOfSingleCycleComponentsInUndirectedGraph()
                {

                }
            }

            public class GreedyAlgorithmInArray
            {
                public void MinimumProductSubsetOfArray()
                {

                }
                public void MaximunProductSubsetOfArray()
                {

                }
                public void MinimumSumOfProductOfArray()
                {

                }
            }
            public class GreedyAlgorithInOS
            {
                public void FirstFitAlgorithmInMemoryManagement()
                {

                }
                public void BestFitAlgorithmInMemoryManagement()
                {

                }
                public void WorstFitAlgorithmInMemoryManagement()
                {

                }
                public void NextFitAlgorithmInMemoryManagement()
                {

                }
                public void ShortestJobFirstScheduling()
                {

                }
                public void SchedulingPriorityTasks()
                {

                }
            }
            public class ApproximateGreedyAlgorithmForNP_Complete
            {
                public void SetCoverProblem()
                {

                }
                public void BinPackingProblem()
                {

                }
                public void GraphColoring()
                {

                }
                public void K_CenterProblem()
                {

                }
                public void ShortestSuperStringProblem()
                {

                }
            }
        }

        public class Search
        {
            Sorting listSort = new Sorting();
            List<int> unSortedList = new List<int>() { 7, 3, 2, 8, 5, 11 };

            /// <summary>
            /// Find element comparing every item
            /// </summary>
            /// <param name="num"></param>
            /// <returns>O(n)</returns>
            public int LinearSearch(int num)
            {
                return unSortedList.Find(item => item == num);
            }

            /// <summary>
            /// Binary Search is a searching algorithm used in a sorted array by repeatedly dividing the search interval in half. The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n). 
            /// </summary>
            /// <param name="sortedList"></param>
            /// <param name="num"></param>
            /// <returns>index of the input at O(nLog(n))</returns>
            public int BinarySearchOnSortedList(List<int> sortedList, int startIndex, int endIndex, int num)
            {
                if (sortedList.Any() && sortedList.Count() > 1)
                {
                    int middleIndex = startIndex + (endIndex - startIndex) / 2;
                    if (sortedList[middleIndex] == num) return middleIndex;

                    if (sortedList[middleIndex] > num)
                        return BinarySearchOnSortedList(sortedList, startIndex, middleIndex - 1, num);
                    return BinarySearchOnSortedList(sortedList, middleIndex + 1, endIndex, num);
                }
                return -1;
            }


            /// <summary>
            /// Searching in graph. eg, {2,0,3,1}  : 
            ///   ( 0 )-->( 1 ) 
            ///    ||
            ///   ( 2 )-->( 3 )
            /// </summary>
            /// <param name="num"></param>
            /// <returns></returns>
            public int BreathFirstSearchOnGraph(int num)
            {

                return 0;
            }
            public int DepthFirstSearch(int num)
            {
                //this.unSortedList
                return 0;
            }
        }

        public class Sorting
        {

            /// <summary>
            /// Merge Sort is a Divide and Conquer algorithm. It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves. The merge() function is used for merging two halves. The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one. See the following C implementation for details.
            /// n*n > n*log(n) => n > log(n) 
            /// When n=10 > log(n)~2.3
            /// When n=1,000,000 > log(n)~13.8
            /// </summary>
            /// <param name="list"></param>
            /// <returns>Sortedlist with O(nLog(n))</returns>
            public List<int> MegreSort(List<int> list, int leftIndex, int rightIndex)
            {
                if (leftIndex < rightIndex)
                {
                    int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                    MegreSort(list, leftIndex, middleIndex);
                    MegreSort(list, middleIndex + 1, rightIndex);
                    Merge(list, leftIndex, middleIndex, rightIndex);
                }
                return list;
            }
            private List<int> Merge(List<int> list, int leftIndex, int middleIndex, int rightIndex)
            {
                // Copy data to two sub-lists
                var leftList = list.GetRange(leftIndex, middleIndex);
                var rightList = list.GetRange(middleIndex + 1, rightIndex);

                int i = 0, j = 0, k = leftIndex;
                // Initial index of merged
                while (i < leftList.Count() && j < rightList.Count())
                {
                    if (leftList.ElementAt(i) <= rightList.ElementAt(j))
                    {
                        list[k] = leftList.ElementAt(i);
                        i++;
                    }
                    else
                    {
                        list[k] = rightList.ElementAt(i);
                        j++;
                    }
                    k++;
                }

                //merge remaining leftList
                while (i < leftList.Count())
                {
                    list[k] = leftList.ElementAt(i);
                    i++;
                    k++;
                }
                //merge remaining rightList
                while (j < rightList.Count())
                {
                    list[k] = rightList.ElementAt(i);
                    j++;
                    k++;
                }

                return list;
            }


            /// <summary>
            /// Like Merge Sort, QuickSort is a Divide and Conquer algorithm. It picks an element as pivot and partitions the given array around the picked pivot. 
            /// n*n > n*log(n) => n > log(n) 
            /// When n=10 > log(n)~2.3
            /// When n=1,000,000 > log(n)~13.8
            /// </summary>
            /// <param name="list"></param>
            /// <returns>Sortedlist with O(nLog(n))</returns>
            public List<int> QuickSort(List<int> list)
            {

                return list;
            }


            /// <summary>
            /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
            /// </summary>
            /// <param name="list"></param>
            /// <returns>Sortedlist with O(n^2)</returns>
            public List<int> BubbleSort(List<int> list)
            {
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    bool swapped = false;
                    for (int j = 0; j < list.Count() - 1 - i; j++)
                    {
                        if (list[j] > list[j + 1])
                        {
                            int temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    // if no swap is happening, its sorted: then break
                    if (!swapped) break;
                }
                return list;
            }
            public List<int> RecusiveBubbleSort(List<int> list, int sortFrom)
            {
                bool swapped = false;
                for (int j = 0; j < list.Count() - 1 - sortFrom; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swapped = true;
                    }
                }

                // if no swap is happening, its sorted: then break
                if (!swapped) return list;


                RecusiveBubbleSort(list, sortFrom + 1);
                return list;
            }

            /// <summary>
            /// Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part
            /// </summary>
            /// <param name="list"></param>
            /// <returns>sortedList with O(n^2)</returns>
            public List<int> InsertionSort(List<int> list)
            {
                int n = list.Count();
                for (int i = 1; i < n; ++i)
                {
                    int key = list[i];
                    int j = i - 1;

                    while (j >= 0 && list[j] > key)
                    {
                        list[j + 1] = list[j];
                        j = j - 1;
                    }
                    list[j + 1] = key;
                }
                return list;
            }

            /// <summary>
            /// Find min of unsorted portion, replace with front value
            /// </summary>
            /// <param name="list"></param>
            /// <returns></returns>
            public List<int> SelectionSort(List<int> list)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    int minIndex = i;
                    for (int j = 0; j < list.Count(); j++)
                    {
                        if (list[j] < list[minIndex])
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        int temp = list[i];
                        list[i] = list[minIndex];
                        list[minIndex] = temp;
                    }
                }
                return list;
            }

            public List<int> PigonHoleSort(List<int> list)
            {
                return list;
            }
            public List<int> TreeSort(List<int> list)
            {
                return list;
            }
            public List<int> OddEvenSort(List<int> list)
            {
                return list;
            }
            public List<int> ShellSort(List<int> list)
            {
                return list;
            }

        }

        public class CollectionImplementaion
        {
            List<int> list = new List<int>();
            // Does not allow duplicate or null key or value
            Hashtable hashTable = new Hashtable();
            //allows one null key and any number of duplicate value
            Dictionary<int, string> hashMap = new Dictionary<int, string>();
            // can't add duplicate value 
            //Return 'TRUE' on successful add. can be use to filter duplicate
            HashSet<int> hashSet = new HashSet<int>();
            //can be use for rotation
            Queue<int> queue = new Queue<int>();

            public void ImpleFun()
            {
                CollectionImplementaion instance = new CollectionImplementaion();
                instance.list.Add(1);
                instance.list.BinarySearch(2);
            }
        }

        public class AvlNodeModel
        {
            public int Height { get; set; }
            public int Data { get; set; }
            public AvlNodeModel? LeftChild { get; set; }
            public AvlNodeModel? RightChild { get; set; }
            public AvlNodeModel(int data)
            {
                this.Height = 1;
                this.Data = data;
                this.LeftChild = null;
                this.RightChild = null;
            }
        }

        public class AvlTree
        {

            public AvlNodeModel Parent { get; set; }
            public void Insert(int data)
            {
                this.Parent = this.InsertRecursive(this.Parent, new AvlNodeModel(data));
            }
            private AvlNodeModel InsertRecursive(AvlNodeModel parent, AvlNodeModel child)
            {
                // Insert In The Tree
                if (parent == null)
                {
                    parent = child;
                    return parent;
                }
                else
                {
                    if (child.Data <= parent.Data)
                    {
                        parent.LeftChild = InsertRecursive(parent.LeftChild, child);
                    }
                    else
                    {
                        parent.RightChild = InsertRecursive(parent.RightChild, child);
                    }
                }

                // Update Height
                if (parent.LeftChild != null && parent.RightChild != null)
                    parent.Height = 1 + (parent.LeftChild.Height >= parent.RightChild.Height ? parent.LeftChild.Height : parent.RightChild.Height);
                else if (parent.LeftChild != null && parent.RightChild == null)
                    parent.Height = 1 + parent.LeftChild.Height;
                else if (parent.LeftChild == null && parent.RightChild != null)
                    parent.Height = 1 + parent.RightChild.Height;

                // Rotations: There are 4 cases 
                //Left Left Case 
                int balanceFactor = GetBalanceFactor(parent);
                if (balanceFactor > 1 && child.Data < parent.LeftChild.Data)
                    return RotateLeft(parent);
                // Right Right Case  
                if (balanceFactor < -1 && child.Data > parent.RightChild.Data)
                    return RotateRight(parent);
                // Left Right Case  
                if (balanceFactor > 1 && child.Data > parent.LeftChild.Data)
                {
                    parent.LeftChild = RotateLeft(parent.LeftChild);
                    return RotateRight(parent);
                }
                // Right Left Case  
                if (balanceFactor < -1 && child.Data < parent.RightChild.Data)
                {
                    parent.RightChild = RotateRight(parent.RightChild);
                    return RotateLeft(parent);
                }
                return parent;
            }
            private int GetBalanceFactor(AvlNodeModel node)
            {
                if (node.LeftChild != null && node.RightChild != null)
                    return node.LeftChild.Height - node.RightChild.Height;
                else if (node.LeftChild != null && node.RightChild == null)
                    return node.LeftChild.Height;
                else if (node.LeftChild == null && node.RightChild != null)
                    return node.RightChild.Height;
                else
                    return 0;
            }

            AvlNodeModel RotateRight(AvlNodeModel node)
            {
                AvlNodeModel nodeLeftChild = node.RightChild;
                AvlNodeModel nodeLeftRightChild = nodeLeftChild.RightChild;

                // Perform Rotation
                nodeLeftChild.RightChild = node;
                node.LeftChild = nodeLeftRightChild;

                // Update Height
                //node.LeftChild.Height = node.LeftChild.LeftChild.Height >= node.LeftChild.RightChild.Height ? (node.LeftChild.LeftChild.Height + 1) : (node.LeftChild.RightChild.Height + 1);
                //node.RightChild.Height = node.RightChild.LeftChild.Height >= node.RightChild.RightChild.Height ? (node.RightChild.LeftChild.Height + 1) : (node.RightChild.RightChild.Height + 1);
                node.Height = node.LeftChild.Height >= node.RightChild.Height ? (node.LeftChild.Height + 1) : (node.RightChild.Height + 1);
                return node;
            }

            AvlNodeModel RotateLeft(AvlNodeModel node)
            {
                AvlNodeModel nodeRightChild = node.LeftChild;
                AvlNodeModel nodeRightLeftChild = nodeRightChild.LeftChild;

                // Perfor Rotations
                node.LeftChild = nodeRightLeftChild;
                node.RightChild = nodeRightChild;

                // Update Height
                node.Height = node.LeftChild.Height >= node.RightChild.Height ? (node.LeftChild.Height + 1) : (node.RightChild.Height + 1);
                return node;
            }
        }



        public class BST
        {
            public BSTNode Patent { get; set; }

            public void Insert(int key)
            {
                Patent = InsertRecursive(Patent, key);
            }

            BSTNode InsertRecursive(BSTNode parent, int key)
            {
                // BASE CASE: WHEN ROOT IS NULL
                if (parent == null)
                {
                    parent = new BSTNode();
                    parent.Value = key;
                    return parent;
                }
                // INDUCTIVE CASE: WHEN ROOT IS NOT NULL
                if (key < parent.Value)
                    parent.LeftChild = InsertRecursive(parent.LeftChild, key);
                else if (key > parent.Value)
                    parent.RightChild = InsertRecursive(parent.RightChild, key);

                return parent;
            }

        }

        public class BSTNode
        {

            public BSTNode? LeftChild { get; set; }
            public BSTNode? RightChild { get; set; }
            public int Value { get; set; }

        }

        public class LinkedList
        {
            public ListNode list { get; set; }
            public void AddFirst(Object data)
            {
                ListNode newNode = new ListNode();
                newNode.Data = data;
                newNode.Next = list;
                list = newNode;

            }
            public void AddLast(Object data)
            {
                if (list == null)
                {
                    list = new ListNode();
                    list.Data = data;
                    list.Next = null;
                }
                else
                {
                    ListNode newNode = new ListNode();
                    newNode.Data = data;
                    ListNode current = list;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public void PrintLinkedList(ListNode head)
            {

                while (head.Next != null)
                {
                    Console.WriteLine(head.Data);
                    head = head.Next;
                }
                if (head.Next == null)
                {
                    Console.WriteLine(head.Data);
                }
            }
        }

        public class ListNode
        {
            public Object Data { get; set; }
            public ListNode? Next { get; set; }

        }

        public class GraphNode
        {
            private int id { get; set; }
            private LinkedList<GraphNode> adjacent = new LinkedList<GraphNode>();

            public GraphNode(int _id)
            {
                this.id = _id;
            }


            /// <summary>
            /// It goes all the way to the leaf node of a child node to find a value.
            /// then it check the next child node and its subs till leaf
            /// </summary>
            public void DepthFirstSearch()
            {

            }

            /// <summary>
            /// It compare level by level 
            /// then it goes to the next level to find a value
            /// </summary>
            public bool BreathFirstSearch(GraphNode source, GraphNode destination)
            {
                LinkedList<GraphNode> nextToVisit = new LinkedList<GraphNode>();
                HashSet<int> visited = new HashSet<int>();
                nextToVisit.AddLast(source);

                while (nextToVisit.Any())
                {
                    // Get and Remove first node of nextToVist LinkedList
                    GraphNode node = nextToVisit.First();
                    nextToVisit.RemoveFirst();

                    // if node matches with destination, we have path
                    if (node == destination)
                        return true;

                    // Add id to visited HashSet if id visited once
                    if (visited.Contains(node.id))
                        continue;
                    visited.Add(node.id);

                    foreach (GraphNode child in node.adjacent)
                    {
                        nextToVisit.AddLast(child);
                    }

                }
                return false;
            }

        }
        public class Graph
        {
            public int ShortesPath(List<List<int>> matrix)
            {
                int minToLeaf = 0;
                foreach (var row in matrix)
                {
                    minToLeaf += row.Any() ? row.Min() : (int)0;
                }
                return minToLeaf;
            }
        }

        public class Algorithms
        {
            public List<int> SelectionSort(List<int> list)
            {
                // Selection Sort Time Complexity: Worst and Best => n^2

                // The selection sort algorithm sorts an array by repeatedly finding the 
                // minimum element (considering ascending order) from unsorted part and 
                // putting it at the beginning. The algorithm maintains two subarrays in a given array..
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    for (int j = i + 1; j < list.Count(); j++)
                    {
                        // Find the minimum element in unsorted array 
                        if (list[j] < list[i])
                        {
                            // Swap the found minimum element with the first element 
                            int temp = list[j];
                            list[j] = list[i];
                            list[i] = temp;
                        }
                    }
                }
                return list;
            }
            public List<int> BubbleSort(List<int> list)
            {
                // Bubble Sort Time Complexity: Worst => n^2 and Best => n
                //Bubble Sort repeatedly swap the adjacent elements if they are in wrong order.
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    // 5, 3, 2
                    // first => 3,2,5 

                    // After first the last index is sorted that's
                    // we can ignore the last index for the follow-up iterations
                    for (int j = 0; j < list.Count() - i - 1; j++)
                    {
                        // Compare index j with all j+1
                        // if j is greater than j+1: swap
                        if (list[j] > list[j + 1])
                        {
                            // swap list[j+1] and list[i] 
                            int temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                }
                return list;
            }

            public List<int> InsertionSort(List<int> list)
            {
                // Insertion Sort Time Complexity: Worst => n^2 and Best => n

                // Insertion sort is a simple sorting algorithm that works 
                // similar to the way you sort playing cards in your hands. 
                // The array is virtually split into a sorted and an unsorted part. 
                // Values from the unsorted part are picked and placed at the correct position in the sorted part.
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    /* Move elements of arr[0..i-1], that are 
                   greater than key, to one position ahead 
                   of their current position */
                    int key = list[i];
                    int j = i - 1;
                    while (j >= 0 && list[j] > key)
                    {
                        list[j + 1] = list[j];
                        j = j - 1;
                    }
                    list[j + 1] = key;
                }
                return list;
            }
            public List<Object> ReverseList(List<Object> ObjList)
            {
                // STACK : LAST IN FIRST OUT (LIFO)
                Stack<Object> stack = new Stack<Object>();
                ObjList.ForEach(obj =>
                {
                    stack.Push(obj);
                });
                return stack.ToList();
            }

            public List<Object> StayInQueue(List<Object> ObjList)
            {
                // QUEUE : FIRST IN FIRST OUT (FIFO)
                Queue<Object> queue = new Queue<Object>();
                ObjList.ForEach(obj =>
                {
                    queue.Enqueue(obj);
                    queue.Dequeue();
                });
                return queue.ToList();
            }

            public void fizzBuzz(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    //Console.WriteLine(i);
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 != 0 && i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            private static int getClosest(int num, List<int> nums)
            {
                Dictionary<int, int> pairs = new Dictionary<int, int>();
                nums.ForEach(num_ =>
                {
                    pairs.Add(num_, Math.Abs((num_ - num)));
                });
                return pairs.OrderBy(pair => pair.Value).FirstOrDefault().Key;
            }

            public long getMinCost(List<int> crew_id, List<int> job_id)
            {
                var minCost = 0;
                crew_id.ForEach(crew =>
                {
                    var job = getClosest(crew, job_id);
                    job_id.Remove(job);
                    minCost += Math.Abs(job - crew);
                });
                return minCost;
            }

            public void rotateList(int d, List<int> list)
            {
                var queue = new Queue<int>();
                if (d < list.Count())
                {
                    for (int i = d; i < list.Count(); i++)
                    {
                        queue.Enqueue(list[i]);
                    }
                }
                for (int i = 0; i < d; i++)
                {
                    queue.Enqueue(list[i]);
                }
                var qList = queue.ToList();
                string result = qList[0].ToString();
                for (int i = 1; i < qList.Count(); i++)
                {
                    result += " " + qList[i];
                }
                Console.WriteLine(result);

            }

            public static int countingValleys(int steps, string path)
            {
                int seaLevel = 0;
                int vallyTraverse = 0;
                bool countVally = true;
                foreach (Char step in path)
                {
                    if (step == 'D')
                    {
                        seaLevel -= 1;
                    }
                    else
                    {
                        seaLevel += 1;
                    }
                    if (seaLevel == -1 && countVally)
                    {
                        vallyTraverse += 1;
                        countVally = false;
                    }
                    if (seaLevel == 0)
                    {
                        countVally = true;
                    }
                }
                return vallyTraverse;
            }

        }
    }
}
