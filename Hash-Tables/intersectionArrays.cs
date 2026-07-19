public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hashSet1 = new HashSet<int>(nums1);
        List<int> res = new List<int>();
        
        foreach(int num in nums2){
            if (hashSet1.Remove(num)){
                res.Add(num);
            }
        }
        return res.ToArray();
    }
}