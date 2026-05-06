public class Solution {
    public int StrStr(string haystack, string needle) {
        int n = needle.Length;
        int m = haystack.Length;

        if (n == 0) return 0;

        for (int i = 0; i <= m - n; i++) {
            int j = 0;

            for (j = 0; j < n; j++) {
                if (haystack[i + j] != needle[j]) {
                    break;
                }
            }

            if (j == n) { // full match
                return i;
            }
        }

        return -1;
    }
}