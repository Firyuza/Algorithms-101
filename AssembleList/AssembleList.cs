using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembleList
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }
    }
    public class AssembleList
    {
        public static Node Assamble(Node list, int n)
        {
            Node p1 = list;
            Node p2 = null;
            var count = 1;

            if (p1.Next != null)
            {
                p2 = p1.Next;
            }

            while (p2.Next != null)
            {
                p2 = p2.Next;
                count++;

                if (count > n)
                {
                    p1 = p1.Next;
                    count--;
                }
            }

            p2.Next = list;
            var root = p1.Next;
            p1.Next = null;

            return root;
        } 
    }
}
