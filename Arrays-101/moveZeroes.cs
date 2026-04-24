public class Solution {
    public void MoveZeroes(int[] nums) {
       
        
        int nonZero=0;
        
        for(int i=0;i<nums.Length;i++){
            if (nums[i]!=0){
                int temp=nums[nonZero];
                nums[nonZero]=nums[i];
                nums[i]=temp;
                
                nonZero++;
            }
            
        }
    }
}