

using System;
using System.Linq;

namespace Demo
{
class Solution {
        public int FindKthLargest(int[] nums, int k) {
        Array.Sort(nums);
        Array.Reverse(nums);
        return nums[k-1];
    }

	static void Main()
	{
		Solution s = new Solution();
		int r = s.FindKthLargest(new int[]{3,2,3,1,2,4,5,5,6},1);
		Console.Write(r);
	}

}

}