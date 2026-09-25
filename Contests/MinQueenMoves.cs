public class Solution {
    public int MinQueenMoves(int[] source, int[] target) {
        if (source[0] == target[0] && source[1] == target[1]){
            return 0;
        }

        if (target[0] == source[0] || target[1] == source[1] || Math.Abs((source[0]-target[0])) == Math.Abs((source[1] - target[1]))){
            return 1;
        }else{
            return 2;
        }
    }
}