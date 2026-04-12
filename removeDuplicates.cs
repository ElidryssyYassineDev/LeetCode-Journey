public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k=nums.Length;
        
        for (int i=1;i<k;i++){
            // if the current element is equal to the previous element, shift the elements to the left
            if (nums[i]==nums[i-1]){
                for(int j=i; j<k-1;j++){
                    nums[j]=nums[j+1];
                }
                // decrease the length and the index to check the next element
                k--;
                i--;
            }
        }
        return k;
    }
}