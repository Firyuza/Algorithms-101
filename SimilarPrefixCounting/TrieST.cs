using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarPrefixCounting
{
    public class TrieST
    {
        private static int R = 256;
        private Node Root;
        private int Count = 0;

        public class Node
        {
            public  char Value;
            public Node[] next = new Node[R];
            public bool HasItem = false;
        }

        public int GetCount()
        {
            return Count;
        }

        public char? Get(String key)
        {
            Node x = Get(Root, key, 0);

            if (x == null)
                return null;

            return x.Value;
        }

        public Node Get(Node x, string key, int d)
        {
            if (x == null)
                return null;
            if (d == key.Length)
                return x;

            var c = key.ElementAt(d);

            return Get(x.next[c], key, d + 1);
        }

        public void Put(String key, char val)
        {
            Root = Put(Root, key, val, 0);
        }

        public Node Put(Node x, String key, char val, int d)
        {
            if (x == null)
                x = new Node();

            if(d == key.Length)
            {
                x.Value = val;
                return x;
            }

            var c = key.ElementAt(d);

            if (x.next[c] != null)
            {
                if (x.next[c].HasItem)
                {
                    Count++;
                }

            }
            x.next[c] = Put(x.next[c], key, val, d + 1);
            x.next[c].HasItem = true;

            return x;
        }

    }
}
