public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        if (nums.Length==1){
            return nums;
        }
        //pointer on even numbers
        int evenNum=0;
        
        for(int i=0;i<nums.Length;i++){
            //if the current element is even then swap
            if(nums[i]%2==0){
                int temp=nums[evenNum];
                nums[evenNum]=nums[i];
                nums[i]=temp;
                evenNum++;
            }
        }
        return nums;
    }
}