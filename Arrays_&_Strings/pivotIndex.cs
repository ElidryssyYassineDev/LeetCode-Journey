public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        int leftSum = 0;
        int rightSum = 0;
        
        foreach(int num in nums){
            sum+=num;
        }
        
        for(int i=0;i<nums.Length;i++){
            rightSum=sum-leftSum-nums[i];
            
            if(leftSum == rightSum){
                return i;
            }
            leftSum+=nums[i];
        }
        return -1;
    }
}