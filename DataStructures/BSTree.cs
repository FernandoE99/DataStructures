using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class tree
    {

        BSTNode Root { get; set; }

        public void insert(int value) {

            BSTNode before = null, after = this.Root;
            while (after != null) {
                before = after;
                if (value < after.Data)
                {
                    after = after.Left;
                }
                else if (value > after.Data)
                {
                    after = after.Right;
                }
                else {
                    Console.WriteLine("That value already exists");
                }
            }

            BSTNode newNode = new BSTNode();
            newNode.Data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else {
                if (value < before.Data)
                {
                    before.Left = newNode;
                }
                else {
                    before.Right = newNode;
                }
            }
            Console.WriteLine("The noce was added successfully");
        }

        public BSTNode Find(int value) {
            return this.Find(value, this.Root);
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BSTNode Remove(BSTNode parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.Left = Remove(parent.Left, key);
            else if (key > parent.Data)
                parent.Right = Remove(parent.Right, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.Left == null)
                    return parent.Right;
                else if (parent.Right == null)
                    return parent.Left;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.Right);

                // Delete the inorder successor  
                parent.Right = Remove(parent.Right, parent.Data);
            }

            return parent;
        }
        private int MinValue(BSTNode node)
        {
            int minv = node.Data;

            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }

            return minv;
        }
        private int MaxValue(BSTNode node)
        {
            int maxV = node.Data;

            while (node.Right != null)
            {
                maxV = node.Right.Data;
                node = node.Right;
            }

            return maxV;
        }
        private int GetTreeDepth(BSTNode parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
        }
        private BSTNode Find(int value, BSTNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.Left);
                else
                    return Find(value, parent.Right);
            }
            return null;
        }
        public void TraversePreOrder(BSTNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.Left);
                TraversePreOrder(parent.Right);
            }
        }
        public void TraverseInOrder(BSTNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.Left);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.Right);
            }
        }
        public void TraversePostOrder(BSTNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.Left);
                TraversePostOrder(parent.Right);
                Console.Write(parent.Data + " ");
            }
        }

    }
}
