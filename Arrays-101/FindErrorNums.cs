public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int[] count = new int[n + 1];

        foreach (int num in nums)
        {
            count[num]++;
        }

        int duplicate = 0;
        int missing = 0;

        for (int i = 1; i <= n; i++)
        {
            if (count[i] == 2)
                duplicate = i;

            if (count[i] == 0)
                missing = i;
        }

        return [duplicate, missing];
    }
}