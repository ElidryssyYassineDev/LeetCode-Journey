public class Solution {
    public string AddBinary(string a, string b) {
        int m = a.Length;
        int n = b.Length;

        int maxLen = Math.Max(m, n);
        char[] resChar = new char[maxLen + 1]; // +1 for possible carry

        int i = m - 1;
        int j = n - 1;
        int k = maxLen;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;

            if (i >= 0) {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }

            resChar[k] = (char)((sum % 2) + '0');
            carry = sum / 2;
            k--;
        }

        // If no carry used at index 0, skip it
        if (resChar[0] == '\0') {
            return new string(resChar, 1, maxLen);
        }

        return new string(resChar);
    }
}