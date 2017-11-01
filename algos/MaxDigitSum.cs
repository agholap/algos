using System;
using System.Collections.Generic;
using System.Text;

namespace algos
{
    //http://www.geeksforgeeks.org/biggest-integer-maximum-digit-sum-range-1-n/
//    Biggest integer which has maximum digit sum in range from 1 to n
//1
//Given a number n, find a number in range from 1 to n such that its sum is maximum.If there are several such integers, determine the biggest of them.

//Examples:

//Input:  n = 100
//Output: 99  
//99 is the largest number in range from
//1 to 100 with maximum sum of digits.

//Input: n = 48
//Output: 48
//Explanation: 
//There are two numbers with maximum
//digit sum. The numbers are 48 and 39
//Since 48 > 39, it is our answer.
    public static class MaxDigitSum
    {
        public static void getMaxDigitSumBrute(int n1)
        {
            //assume max sum
            // try to find next max 
            //brute force - two for loop to check the sum
            //time complexity - o(n)
            //space complexity - o
            int maxSum = 0;
            Stack<int> nu = new Stack<int>();
            int sum = 0;int n = 0;int c = 0;
            for(int i =1; i < n1;i++)
            {
                n = i;
                while(n>0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
               if(sum>maxSum)
                {
                    if(nu.Count > 0)
                    {
                        nu.Clear();
                        nu.Push(i);
                    }  
                    else
                    {
                        nu.Push(sum);
                    }
                }
               else if (sum==maxSum)
                {
                    nu.Push(i);
                }
            }
            Console.WriteLine(nu.Peek().ToString());
        }
    }
}
