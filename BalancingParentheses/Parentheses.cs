using System;
using System.Collections.Generic;

namespace BalancingParentheses
{
    public class Parentheses
    {
        public static Stack<char> stack { get; set; }

        public static void Balance(string str)
        {
            var result = "";
            stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == '(')
                {
                    stack.Push('(');
                }
                else
                {
                    if (stack.Count != 0)
                    {
                        result += stack.Pop() + ")";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
