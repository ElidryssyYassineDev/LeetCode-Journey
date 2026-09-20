public class Solution {
    public int ReverseDegree(string s) {
        int sum = 0;
        //if z is 26 and a is 1, and we want a to return 26 and z to retun 1, 
        for(int i = 0; i < s.Length; i++) {
            sum += ('z' - s[i] + 1)*(i+1);
        }
        return sum;
    }
}