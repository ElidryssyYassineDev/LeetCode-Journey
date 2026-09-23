public class Solution
{
    public int MinOperations(int[] nums, int x)
    {
        long total = 0;

        foreach (int num in nums)
        {
            total += num;
        }

        if (total < x)
            return -1;

        long target = total - x;

        if (target == 0)
            return nums.Length;

        int n = nums.Length;
        int left = 0;
        long sum = 0;
        int maxLen = -1;

        for (int right = 0; right < n; ++right)
        {
            sum += nums[right];

            while (sum > target && left <= right)
            {
                sum -= nums[left];
                ++left;
            }

            if (sum == target)
            {
                maxLen = Math.Max(maxLen, right - left + 1);
            }
        }

        return maxLen == -1 ? -1 : n - maxLen;
    }
}