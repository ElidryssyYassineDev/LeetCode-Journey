public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        int maxRight=-1;
        
        for (int i=arr.Length-1; i>=0;i--){
            
            int current=arr[i];
            arr[i]=maxRight;
            maxRight=Math.Max(maxRight,current);
        }
        
        return arr;
    }
}