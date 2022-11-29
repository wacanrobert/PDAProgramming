using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDAProgramming
{
    internal class Palindrome
    {
        public Palindrome()
        {

        }

        public bool IsPalindrome(char[] str)
        {
            // Make stack for checking
            Stack<char> stack = new Stack<char>();

            int length = str.Length;

            // Find the half of string
            int i, half = length / 2;

            // Push half of string
            for (i = 0; i < half; i++)
            {
                Console.WriteLine("Push " + str[i]);
                stack.Push(str[i]);
            }

            // If odd, skip character in the middle
            if (length % 2 != 0)
            {
                Console.WriteLine("Skip " + str[i]);
                i++;
            }

            // Loop until end of string
            while (i < length)
            {
                // If the top of stack is the same as current character, then pop
                if (stack.Peek() == str[i])
                {
                    Console.WriteLine("Pop " + stack.Peek() + " on input " + str[i]);
                    stack.Pop();
                }

                // If the character is different then it is not a palindrome
                else
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
