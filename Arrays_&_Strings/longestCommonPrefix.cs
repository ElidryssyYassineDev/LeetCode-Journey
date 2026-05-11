public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";

        string firstStr = strs[0];

        StringBuilder prefix = new StringBuilder();

        for (int i = 0; i < firstStr.Length; i++) {

            char currentChar = firstStr[i];

            for (int j = 1; j < strs.Length; j++) {

                if (i >= strs[j].Length || strs[j][i] != currentChar) {
                    return prefix.ToString();
                }
            }

            prefix.Append(currentChar);
        }

        return prefix.ToString();
    }
}