using System;
using System.Collections.Generic;
using System.Text;


//Not finished
namespace EPAM_module_8
{
    class Node<T> where T : IComparable
    {
        public Node<T> LeftNode;
        public Node<T> RightNode;
        public T Value;
        public Node<T> Parent;

        public Node(T value)
        {
                Value = value;
        }

        public Node(T value, Node<T> parent)
        {
            Value = value;
            Parent = parent;
        }
    }

    class BinarySearchTree<T> where T: IComparable
    {
        public Node<T> root;
        Comparer<T> Comparer = Comparer<T>.Default;
        public delegate void PrintOrder(BinarySearchTree<T> tree);
        public BinarySearchTree(Node<T> node, Comparer<T> comparer = null)
        {
            root = node;
            if(Comparer!=null)
                Comparer = comparer;
        }
        
        public BinarySearchTree(Comparer<T> comparer = null)
        {
            if (Comparer != null)
                Comparer = comparer;
        }


        public void AddNode(T value)
        {
            if (root == null)
            {
                root = new Node<T>(value);
            }
            else
                AddNode(value, root);
        }

        void AddNode(T value, Node<T> node)
        {
            if(Comparer.Compare(value,node.Value)<0)
            {
                if (node.LeftNode == null)
                    node.LeftNode = new Node<T>(value, node);
                else
                    AddNode(value, node.LeftNode);
            }
            else if(Comparer.Compare(value,node.Value)>0)
            {
                if (node.RightNode == null)
                    node.RightNode = new Node<T>(value, node);
                else
                    AddNode(value, node.RightNode);
            }
        }

        public bool Search(T element)
        {
            if (root == null)
            {
                return false;
            }
            else
                return Search(element, root);
        }

        bool Search(T element, Node<T> node)
        {
            if (Comparer.Compare(element, node.Value) < 0)
            {
                if (node.LeftNode == null)
                    return false;
                else
                    Search(element, node.LeftNode);
            }
            else if (Comparer.Compare(element, node.Value) > 0)
            {
                if (node.RightNode == null)
                    return false;
                else
                    Search(element, node.RightNode);
            }

            return true;
        }

        public void Print(PrintOrder order)
        {
            order(this);
        }

        public static void PreOrder(BinarySearchTree<T> tree)
        {
            Console.WriteLine(tree.root.Value);
        }

        public static void InOrder(BinarySearchTree<T> tree)
        {

        }

        public static void PostOder(BinarySearchTree<T> tree)
        {

        }
    }
}
