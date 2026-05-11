public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int right=0;
        int left=numbers.Length-1;
        int[] res =new int[2];
        
        while(right<left){
            if(numbers[right]+numbers[left]>target){
                left--;
            }
            else if (numbers[right]+numbers[left]<target){
                right++;
            }
            else{
                res[0]=right+1;
                res[1]=left+1;
                return res;
            } 
        }
        return res;
    }
}