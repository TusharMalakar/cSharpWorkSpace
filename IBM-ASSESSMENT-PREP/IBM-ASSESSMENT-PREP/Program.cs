using System;
using System.Linq;
using System.Collections.Generic;

namespace IBM_ASSESSMENT_PREP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String word = "AABBCCCBAT";
            Dictionary<Char, String> pairs = new Dictionary<Char, String>(); // HashMap
            foreach (Char _char in word)
            {
                if (!pairs.ContainsKey(_char))
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
            List<List<Int16>> Triangle = new List<List<Int16>>();
            var row1 = new List<Int16>();
            row1.Add(5);
            Triangle.Add(row1);
            var row2 = new List<Int16>();
            row2.Add(2);
            row2.Add(1);
            row2.Add(6);
            Triangle.Add(row2);
            var row3 = new List<Int16>();
            row3.Add(9);
            row3.Add(10);
            row3.Add(4);
            Triangle.Add(row3);
            var minToLeaf = new Graph().ShortesPath(Triangle);
            Console.WriteLine(minToLeaf);

            //------Hacker Rank----//
            Algorithms alFun = new Algorithms();
            alFun.fizzBuzz(15);
            var list1 = new List<int>() {1,3,5};
            var list2 = new List<int>(){ 3,5,7};
            alFun.getMinCost(list1, list2);
            var list3 = new List<int>() { 1,2,3, 4, 5 };
            alFun.rotateList(4, list3);

            // ----- AVL TREE ------ //
            AvlTree avl = new AvlTree();
            avl.Insert(4);
            avl.Insert(3);
            avl.Insert(2);
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
                if(child.Data <= parent.Data)
                {
                    parent.LeftChild = InsertRecursive(parent.LeftChild, child);
                }
                else
                {
                    parent.RightChild = InsertRecursive(parent.RightChild, child);
                }
            }

            // Update Height
            if(parent.LeftChild != null && parent.RightChild != null)
                parent.Height = 1 +(parent.LeftChild.Height >= parent.RightChild.Height ? parent.LeftChild.Height : parent.RightChild.Height);
            else if (parent.LeftChild != null && parent.RightChild == null)
                parent.Height = 1 + parent.LeftChild.Height;
            else if (parent.LeftChild == null && parent.RightChild != null)
                parent.Height = 1 + parent.RightChild.Height;

            //***************************************************************************************//
            /*** FIX NULL EXCEPTIONS */
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
            AvlNodeModel nodeLeftChild = node.LeftChild;
            AvlNodeModel nodeLeftRightChild = nodeLeftChild.RightChild;

            // Perform Rotation
            nodeLeftChild.RightChild = node; 
            node.LeftChild = nodeLeftRightChild;
            
            // Update heights  
            node.Height = node.LeftChild.Height >= node.RightChild.Height ? (node.LeftChild.Height + 1):  (node.RightChild.Height + 1);
            nodeLeftChild.Height = nodeLeftChild.LeftChild.Height >= nodeLeftChild.RightChild.Height ? (nodeLeftChild.LeftChild.Height + 1) : (nodeLeftChild.RightChild.Height + 1);
            return node;
        }

        AvlNodeModel RotateLeft(AvlNodeModel node)
        {
            /*** FIX NULL EXCEPTIONS */
            AvlNodeModel nodeRightChild = node.RightChild;
            /*** FIX NULL EXCEPTIONS */
            AvlNodeModel nodeRightLeftChild = nodeRightChild.LeftChild;

            // Perform Rotation
            nodeRightChild.LeftChild = node;
            node.RightChild = nodeRightLeftChild;

            // Update Height
            node.Height = node.LeftChild.Height >= node.RightChild.Height ? (node.LeftChild.Height + 1) : (node.RightChild.Height + 1);
            nodeRightChild.Height = 1 + (nodeRightChild.LeftChild.Height >= nodeRightChild.RightChild.Height ? nodeRightChild.LeftChild.Height : nodeRightChild.RightChild.Height);

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
            if(head.Next == null)
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

    public class Graph
    {
        public Int16 ShortesPath(List<List<Int16>> matrix)
        {
            Int16 minToLeaf = 0;
            foreach (var row in matrix)
            {
                minToLeaf += row.Any() ? row.Min() : (Int16)0;
            }
            return minToLeaf;
        }
    }

    public class Algorithms
    {
        public List<Object> ReverseList(List<Object> ObjList)
        {
            // STACK : LAST IN FIRST OUT (LIFO)
            Stack<Object> stack = new Stack<Object>();
            ObjList.ForEach(obj => {
                stack.Push(obj);
            });
            return stack.ToList();
        }

        public List<Object> StayInQueue(List<Object> ObjList)
        {
            // QUEUE : FIRST IN FIRST OUT (FIFO)
            Queue<Object> queue = new Queue<Object>();
            ObjList.ForEach(obj => {
                queue.Enqueue(obj);
                queue.Dequeue();
            });
            return queue.ToList();
        }

        public  void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(i);
                if (i % 3 == 0 && i % 5==0)
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
                else if(i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int getClosest(int num, List<int> nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            nums.ForEach(num_ => {
                pairs.Add(num_, Math.Abs((num_ - num)));
            });
            return pairs.OrderBy(pair => pair.Value).FirstOrDefault().Key;
        }

        public long getMinCost(List<int> crew_id, List<int> job_id)
        {
            var minCost = 0;
            crew_id.ForEach(crew => {
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
    }
}
