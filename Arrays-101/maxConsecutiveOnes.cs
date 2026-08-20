public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsecutiveOnes = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; ++i){
            if (nums[i] == 1){
                count++;
                if (maxConsecutiveOnes < count){
                    maxConsecutiveOnes = count;
                }
            }else{
                count = 0;
            }
        }
        return maxConsecutiveOnes;
    }
}