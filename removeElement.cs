public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k=0;
        int length=0;
        // count the number of elements and the number of elements not equal to val
        foreach(int num in nums){
            length++;
            if(num != val){
                k++;
            }
        }
        
        for (int i=0;i<length;i++){
            // if the current element is equal to val, shift the elements to the left
            if(nums[i]==val) {
                for(int j=i;j<length-1;j++){
                        nums[j]=nums[j+1];
                }
                // decrease the length and the index to check the next element
                length--;
                i--;
            }
                 
               
           
        }
        return k;
        
    }
}