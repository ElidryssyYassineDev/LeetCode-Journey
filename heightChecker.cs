public class Solution {
    public int HeightChecker(int[] heights) {
        
        int[] expected= (int[])heights.Clone();//clone the heights array to sort it without affecting the original array
        
        Array.Sort(expected);
        int counter=0;
        
        for(int i=0;i<heights.Length;i++){//compare the expected array with the original array and count the number of different elements
            if (expected[i]!=heights[i]){
                counter++;
                }   
        }
        return counter;
    }
}