using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembleList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Node
            {
                Value = 1,
                Next = new Node
                {
                    Value = 2,
                    Next = new Node
                    {
                        Value = 3,
                        Next = new Node
                        {
                            Value = 4,
                            Next = new Node
                            {
                                Value = 5,
                                Next = new Node
                                {
                                    Value = 6,
                                    Next = null
                                }
                            }
                        }
                    }
                }
            };

            var result = AssembleList.Assamble(list, 2);

            var root = result;

            while (root != null)
            {
                Console.Write(root.Value + " -> ");
                root = root.Next;
            }

            Console.ReadKey();
        }
    }
}
