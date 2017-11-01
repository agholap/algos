using System;
using System.Collections.Generic;
using System.Text;

namespace algos
{
    //https://www.youtube.com/watch?v=78t_yHuGg-0
    //http://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    //A permutation, also called an “arrangement number” or “order,” is a rearrangement of the elements of an ordered list S into a one-to-one correspondence with S itself.A string of length n has n! permutation.
    //Source: Mathword(http://mathworld.wolfram.com/Permutation.html)
    //Below are the permutations of string ABC.
    //ABC ACB BAC BCA CBA CAB
    //Permute BC 
    //BC 
    //CB
    //Permute ABC
    //ABC
    //BAC
    //BCA
    //ACB
    //CAB
    //CBA
    public class PermutationOfString
    {
        public static void permuteString()
        {
            string per = "abc";
            List<string> lstPer = new List<string>();
            var permutation = permuteString(per);
            for (int i = 0; i < permutation.Count; i++)
            {
                Console.WriteLine(permutation[i]);
            }
          
        }
        //first get the permuation of string
        //append addional letter to index places of new string
        public static List<string> permuteString(string permute)
        {
            var ls = new List<string>();
            if (permute == "")//base case
            {
                ls.Add("");
                return ls;
            }
            else
            {
                var firstChar = permute.Substring(0, 1); // take the first word
                var remender = permute.Substring(1); // take the remaining string
                var words = permuteString(remender); // 
                foreach (var w in words)
                {
                    for (int i = 0; i <= w.Length; i++)
                    {
                        ls.Add(InsertChar(w, i, firstChar));
                    }
                }
            }
            return ls;
        }
       static string InsertChar(string str, int index, string prefix)
        {
           return str.Substring(0, index) + prefix + str.Substring(index);
        }
    }
}
