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
            lList.AddFirst(6);
            lList.AddFirst(9);
            lList.AddFirst(3);
            lList.AddLast(61);
            lList.AddLast(91);
            lList.AddLast(31);

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
        }
    }


    public class BST
    {
        public BSTNode Root { get; set; }

        public void Insert(int key)
        {
            Root = InsertRecursive(Root, key);
        }

        BSTNode InsertRecursive(BSTNode root, int key)
        {
            // BASE CASE: WHEN ROOT IS NULL
            if (root == null)
            {
                root = new BSTNode();
                root.Value = key;
                return root;
            }
            // INDUCTIVE CASE: WHEN ROOT IS NOT NULL
            if (key < root.Value)
                root.Left = InsertRecursive(root.Left, key);
            else if (key > root.Value)
                root.Right = InsertRecursive(root.Right, key);

            return root;
        }

    }

    public class BSTNode
    {

        public BSTNode? Left { get; set; }
        public BSTNode? Right { get; set; }
        public int Value { get; set; }

    }

    public class LinkedList
    {
        private ListNode list { get; set; }
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

    }
}
