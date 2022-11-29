using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PDAProgramming
{
    internal class Brackets
    {
        public Brackets()
        {

        }

        // Check if brackets are balanced
        public int CheckBalanced(char[] brackets)
        {
            // Stack for checking balance
            Stack<char> stck = new Stack<char>();

            // Traverse brackets
            for (int i = 0; i < brackets.Length; i++)
            {
                // If character is a starting bracket, push
                if (brackets[i] == '{' || brackets[i] == '(' || brackets[i] == '[')
                {
                    Console.WriteLine("Push " + brackets[i]);
                    stck.Push(brackets[i]);
                }

                //  If character is a closing bracket, pop it
                else if (brackets[i] == '}' || brackets[i] == ')' || brackets[i] == ']')
                {
                    
                    // Compare current bracket to top of stack
                    if (Match(stck.Peek(), brackets[i]))
                    {
                        Console.WriteLine("Pop " + stck.Peek() + " on input " + brackets[i]);
                        stck.Pop();
                    }
                }
                // If character is not a bracket
                else
                {
                    return 2;
                }
            }
            // balanced
            if (stck.Count == 0)
                return 1; 
            else
            {
                // not balanced
                return 0;
            }
        }

        // Helper method to check if brackets are a pair
        public bool Match(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }
    }
}
