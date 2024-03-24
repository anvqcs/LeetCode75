using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Problems
{
    internal class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];

            res[0] = 1;
            for (int i = 1; i< nums.Length; i++)
            {
                res[i] = nums[i - 1] * res[i - 1];
            }

            int rightProduct = 1;
            for (int i = nums.Length - 1; i >=0; i--)
            {
                res[i] *= rightProduct;
                rightProduct *= nums[i];
            }
            return res;
        }
    }
}
