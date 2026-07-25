public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; ++i){
            if (hashMap.ContainsKey(nums[i]) && Math.Abs(i - hashMap[nums[i]]) <= k){
                return true;
            }
            hashMap.Add(nums[i],i);
        }
        
        return false;
    }
}