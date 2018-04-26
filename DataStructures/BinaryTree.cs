using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructures
{
  public   class BinaryTree<T1,T2> 
    {
       int count;
       TreeNode<T1,T2> root;

        //Получаем значение по ключу 
        public  T2 Get(T1 key)
        {
            TreeNode<T1, T2> x = root;

            while (x!=null)
            {
                if ((x as IComparable).CompareTo(key) < 0)
                {
                    x = x.Left;
                }
                else if ((x as IComparable).CompareTo(key) > 0)
                {
                    x = x.Right;
                }
                else
                {
                    return x.Value;
                }
            }

            return default(T2);
        }


        //http://www.c-sharpcorner.com/UploadFile/ddb212/generic-binary-search-tree-with-keyed-values-using-C-Sharp/
        //https://stackoverflow.com/questions/10366402/binary-search-tree-in-c-sharp-implementation
        public  void insert(T1 key, T2 value) 
        {
            TreeNode<T1,T2> current = root;
            TreeNode<T1, T2> parent = null;

            while (current!=null)
            {
                parent = current;
                if ((current.Key as IComparable).CompareTo(key)<0)
                {
                    current = current.Right;
                }
                else
                {
                    current = current.Left;
                }
            }

            TreeNode<T1, T2> Node = new TreeNode<T1, T2>(key,value);

            if (parent!=null)
            {
                if ((current.Key as IComparable).CompareTo(key) < 0)
                    parent.Left = Node;
                else
                    parent.Right = Node;
            }
            else
            {
                root = Node;
            }
            Node.Parent = parent;

            count++;
        }

        public  void delete(T1 key)
        {
            TreeNode<T1, T2> temp = root;

            while (temp!=null)
            {
                if ((temp.Key as IComparable).CompareTo(key) < 0)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
        }

    }
}
