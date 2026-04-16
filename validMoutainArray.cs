/*public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
        if (arr.Length<3){
            return false;
        }
        int maxValue=arr.Max();
        int maxIndex=Array.IndexOf(arr,maxValue);
        
        //max cannot be at edges
        if (maxIndex==0 && maxIndex==arr.Length-1){
            return false;
        }
        
        //check strictly increasing
        for (int i=0;i<maxIndex-1;i++){
            if(arr[i]>=arr[i-1]){
                return false;
            }
        }
        //check strictly decreasing
        for(int i=maxIndex;i<arr.Length-1;i++){
            if(arr[i]<=arr[i+1]){
                return false;
            }
           
        }
        return true;
    }
}*/
//Optimized version without using Max and IndexOf
public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int n = arr.Length;
        if (n < 3) return false;

        int i = 0;

        // Walk up
        while (i + 1 < n && arr[i] < arr[i + 1]) {
            i++;
        }

        // Peak can't be first or last
        if (i == 0 || i == n - 1) return false;

        // Walk down
        while (i + 1 < n && arr[i] > arr[i + 1]) {
            i++;
        }

        return i == n - 1;
    }
}