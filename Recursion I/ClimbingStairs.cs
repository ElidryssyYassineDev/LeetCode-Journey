public class Solution {
    
    Dictionary<int, int> cache = new Dictionary<int, int>();
    
    public int ClimbStairs(int n) {
        
        if (cache.ContainsKey(n)){
            return cache[n];
        }
        int result;
        
        if (n == 0 || n == 1){
            return 1;
        }else{
            result = ClimbStairs(n-1) + ClimbStairs(n-2);
        }
        
        cache.Add(n,result);
        
        return result;
    }
}