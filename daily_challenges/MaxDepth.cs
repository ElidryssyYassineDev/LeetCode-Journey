public class Solution {
    public int MaxDepth(string s) {
        int nestingDepth = 0;
        int current = 0;

        foreach (char c in s){
            if (c == '('){
                nestingDepth = Math.Max(nestingDepth, ++current);
            }
            if (c == ')'){
                current--;
            }
        }
        return nestingDepth;
    }
}