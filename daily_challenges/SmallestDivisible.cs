public class Solution {
    public int SmallestNumber(int n, int t) {
        while (!Check(n, t)) {
            n++;
        }
        return n;
    }

    private bool Check(int num, int t) {
        int product = 1;
        while (num > 0) {
            product *= num % 10;
            num /= 10;
            if (product == 0) {
                break;
            }
        }
        return product % t == 0;
    }
}