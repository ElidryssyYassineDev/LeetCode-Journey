public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, IList<string>>();

        foreach (string s in strs) {
            // Sort characters to create a canonical key
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // Group strings with the same sorted key
            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }

        return new List<IList<string>>(groups.Values);
    }
}