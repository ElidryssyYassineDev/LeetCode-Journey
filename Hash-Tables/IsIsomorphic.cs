public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> mapST = new Dictionary<char,char>();
        Dictionary<char, char> mapTS = new Dictionary<char,char>();
        
        for (int i = 0; i < s.Length; ++i){
            char charS = s[i];
            char charT = t[i];
            
            if(mapST.ContainsKey(charS) && mapST[charS] != charT){
                return false;
            }
            
            if(mapTS.ContainsKey(charT) && mapTS[charT] != charS){
                return false;
            }
            
            mapST[charS] = charT;
            mapTS[charT] = charS;
            
        }
        return true;

    }
}