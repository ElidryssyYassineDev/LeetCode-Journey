public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Handle edge case of empty array
        if (nums.Length == 0) return 0;
        // Initialize the index for the unique elements
        int i = 0;

        for (int j = 1; j < nums.Length; j++) {
            // If the current element is different from the last unique element, update the unique index and value
            if (nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j];
            }
        }
        // The length of the unique elements is i + 1
        return i + 1;
    }
}