using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Problems
{
    internal class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            string[] arrStr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arrStr);
            return string.Join(' ', arrStr);
        }
    }
}
