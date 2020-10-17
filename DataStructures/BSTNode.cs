using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BSTNode
    {
        private int data { get; set; }
        BSTNode left { get; set; }
        BSTNode right { get; set; }



        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public BSTNode Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public BSTNode Right
        {
            get { return this.right; }
            set { this.right = value; }
        }
    }
}
