public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int k = 0;
        int[] ans = new int[nums.Length];
        for(int i = 0; i < n; ++i){
            ans[k++] = nums[i];
            ans[k++] = nums[i + n];
        }
        return ans;
    }
}