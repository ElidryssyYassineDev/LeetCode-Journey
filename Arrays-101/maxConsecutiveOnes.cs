public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int tracker = 0;
        int help = 0;
        for (int i=0;i<nums.Length;i++){
            
            if (nums[i]==1){
                tracker+=1;
                if(help<tracker){
                    help=tracker;
                }
            
            }
            else{
                
                tracker =0;
            }
           
            
        }
        
        return help;
    }
}