public class Solution {
    public int DominantIndex(int[] nums) {
        int maxIndex = Array.IndexOf(nums, nums.Max());//find the index of the maximum element in the array
            
        for (int i=0;i<nums.Length;i++){//iterate through the array and check if the maximum element is at least twice as big as every other number
            if(i!=maxIndex && nums[maxIndex]<2*nums[i]){
                return -1;
            }
        }
        return maxIndex;
    }
}