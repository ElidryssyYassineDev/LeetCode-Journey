public class Solution {
    public int ReverseDegree(string s) {
        int sum = 0;
        Dictionary<char, int> hashmap = new Dictionary<char, int>();
        char[] alphabets = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'];
        int i = 26;
        foreach(char alpha in alphabets){
            hashmap.Add(alpha,i);
            i--;
        }

        for (int j = 0; j < s.Length; j++){
            sum += ((j+1) * hashmap[s[j]]);
        }
        return sum;
    }
}