public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        HashSet<int> numbers = new HashSet<int>();
        foreach (int num in nums) {
            numbers.Add(num);
        }
        for (int i = 1; i <= nums.Length; ++i){
            if (!numbers.Contains(i)){
                result.Add(i);
            }
        }
        return result;
    }
}