using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class TreeNode<T1,T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }

      public  TreeNode<T1,T2> Parent { get; set; }
      public  TreeNode<T1,T2> Left { get; set; }
      public  TreeNode<T1,T2> Right { get; set; }

        public TreeNode(T1 key, T2 value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
