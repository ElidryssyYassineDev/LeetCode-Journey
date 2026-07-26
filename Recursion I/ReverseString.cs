public class Solution {
    public void ReverseString(char[] s) {
        Helper(s, 0, s.Length - 1);
    }
    
    public void Helper(char[] s, int left, int right){
        if (left >= right){
            return;
        }
        (s[left], s[right]) = (s[right], s[left]);
        Helper(s, left + 1, right - 1);
    }
}