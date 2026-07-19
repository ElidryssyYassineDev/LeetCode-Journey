public class Solution 
{
    public bool IsHappy(int n) 
    {
        HashSet<int> seenNumbers = new HashSet<int>();
        
        // Loop continues until n becomes 1 or enters a cycle
        while (n != 1 && !seenNumbers.Contains(n)) 
        {
            seenNumbers.Add(n);
            n = GetSumOfSquares(n);
        }
        
        return n == 1;
    }

    private int GetSumOfSquares(int num) 
    {
        int sum = 0;
        while (num > 0) 
        {
            int digit = num % 10;   // Extract the last digit
            sum += digit * digit;   // Square it and add to sum
            num /= 10;              // Remove the last digit
        }
        return sum;
    }
}
