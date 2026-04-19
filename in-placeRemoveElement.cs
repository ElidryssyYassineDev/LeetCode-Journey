public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //edge cases
        if (nums.Length==1 &&nums[0]==val){
            return 0;
        }
        //point on the non equal to val elements
        int k=0;
        for(int i=0;i<nums.Length;i++){
            //if the current element is not equal to val then overrite val
            if(nums[i]!=val){
                nums[k]=nums[i];
                k++;
            }
        }
        return k;
    }
}