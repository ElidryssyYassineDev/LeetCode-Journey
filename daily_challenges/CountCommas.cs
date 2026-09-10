class Solution {
    public int countCommas(int n) {
        int countCommas = 0;

        for (int i = 0; i <= n - 1000; ++i){
            countCommas++;
        }
        return countCommas;
    }
}