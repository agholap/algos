﻿using System;
using System.Collections.Generic;
using System.Text;

namespace algos
{
   public static class BalancedParenthesis
    {
        static void _printParenthesis(char[] str, int pos, int n, int open, int close)
        {
            if (close == n)
            {
                // print the possible combinations
                for (int i = 0; i < str.Length; i++)
                   Console.WriteLine(str[i]);              
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = '}';
                    _printParenthesis(str, pos + 1, n, open, close + 1);
                }
                if (open < n)
                {
                    str[pos] = '{';
                    _printParenthesis(str, pos + 1, n, open + 1, close);
                }
            }
        }

        // Wrapper over _printParenthesis()
        static void printParenthesis(char[] str, int n)
        {
            if (n > 0)
                _printParenthesis(str, 0, n, 0, 0);
            return;
        }

        // driver program 
        public static void Call()
        {
            int n = 3;
            char[] str = new char[100];
            printParenthesis(str, n);
        }
    }
}
