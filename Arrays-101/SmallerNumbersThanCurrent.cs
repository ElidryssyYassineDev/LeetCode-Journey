public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i){
            for (int j = 0; j < nums.Length; ++j){
                if (i != j && nums[j] < nums[i]){
                    result[i]++;
                }
            }
        }
        return result;
    }
}