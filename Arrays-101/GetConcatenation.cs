public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[2*n];
        int index = 0;
        
        for (int i = 0; i < ans.Length; ++i){
            ans[i] = nums[index];
            index++;
            if (index >= n){
                index = 0;
            }
        }
        return ans;
    }
}