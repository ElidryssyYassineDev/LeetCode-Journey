public class Solution {
    public int ThirdMax(int[] nums) {
        
        SortedSet<int> topThree = new SortedSet<int>();//use a sorted set to keep track of the top three maximum numbers
        
        foreach(int num in nums){
            topThree.Add(num);//add each number to the sorted set, duplicates will be automatically handled
            
            if(topThree.Count>3){
                topThree.Remove(topThree.Min);//remove the smallest number if we have more than three numbers in the set
            }
        }
        if (topThree.Count<3){
            return topThree.Max;//if we have less than three numbers, return the maximum number in the set
        }
        return topThree.Min;
    }
}