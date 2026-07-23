public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> hashMap = new Dictionary<char, int>();
        foreach(char character in s ){
            if (hashMap.TryGetValue(character, out int count)){
                hashMap[character] = count + 1;
            }
            else {
                hashMap.Add(character,1); 
            }
        }
        for (int i = 0; i<s.Length; ++i) {
            if (hashMap[s[i]] == 1){
                return i;
            }
        }
        return -1;
    }
}