public class Solution {
    public int SmallestIndex(int[] nums) {
        

        for (int i = 0; i < nums.Length; i++){
            int temp = nums[i];
            int sum = 0;
            while(temp > 0){
                sum += temp % 10;
                temp /= 10;
            }
            if (i == sum){
                return i;
            }
        }
        return -1;
    }
}