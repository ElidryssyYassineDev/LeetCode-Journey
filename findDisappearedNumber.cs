public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums);//use a hash set to store the numbers in the input array for O(1) lookups
        foreach(int num in nums){
            numbers.Add(num);
        } 
        
        IList<int> disappearedNumbers = new List<int>();
        for(int i=1;i<=nums.Length;i++){
            if(!numbers.Contains(i)){
                disappearedNumbers.Add(i);//if the number is not in the hash set, it means it is missing from the input array, so we add it to the result list
            }
        }
        return disappearedNumbers;
    }
}