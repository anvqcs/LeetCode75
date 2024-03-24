using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Problems
{
    public class MergeAlternately
    {
        public string MergeStringsAlternately(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1)) return word2;
            if (string.IsNullOrEmpty(word2)) return word1;

            string res = "";
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                res += word1[i].ToString() + word2[i].ToString();
            }
            if (word1.Length > word2.Length) return res + word1.Substring(word2.Length, word1.Length - word2.Length);
            return res + word2.Substring(word1.Length, word2.Length - word1.Length);
        }
    }
}
