public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        IList<int> result = new List<int>();
        int maxNum = nums.Max();
        int minNum = nums.Min();

        for (int i = minNum; i < maxNum; ++i){
            if (!nums.Contains(i)){
                result.Add(i);
            }
        }
        return result;
    }
}