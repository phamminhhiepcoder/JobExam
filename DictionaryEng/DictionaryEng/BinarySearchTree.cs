using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEnglishToVietnamese
{
    class BinarySearchTree
    {
        private Node root;

        private class Node
        {
            public string Key;
            public Node Left;
            public Node Right;

            public Node(string key)
            {
                Key = key;
                Left = null;
                Right = null;
            }
        }

        public void Insert(string key)
        {
            root = Insert(root, key);
        }

        private Node Insert(Node node, string key)
        {
            if (node == null)
            {
                node = new Node(key);
            }
            else
            {
                if (string.Compare(key, node.Key) < 0)
                {
                    node.Left = Insert(node.Left, key);
                }
                else
                {
                    node.Right = Insert(node.Right, key);
                }
            }
            return node;
        }

        public void Delete(string key)
        {
            root = Delete(root, key);
        }

        private Node Delete(Node node, string key)
        {
            if (node == null)
            {
                return node;
            }

            if (string.Compare(key, node.Key) < 0)
            {
                node.Left = Delete(node.Left, key);
            }
            else if (string.Compare(key, node.Key) > 0)
            {
                node.Right = Delete(node.Right, key);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Key = MinValue(node.Right);
                node.Right = Delete(node.Right, node.Key);
            }
            return node;
        }

        private string MinValue(Node node)
        {
            string minValue = node.Key;
            while (node.Left != null)
            {
                minValue = node.Left.Key;
                node = node.Left;
            }
            return minValue;
        }

        public void Clear()
        {
            root = null;
        }
    }
}
