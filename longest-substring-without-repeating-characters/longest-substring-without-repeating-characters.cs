public class Solution {
    public int LengthOfLongestSubstring(string s) {
       HashSet<char> visited = new HashSet<char>();
        int maxLength = 0;
        
        int start = 0, end = 0;
        while (end < s.Length) {
            if (!visited.Contains(s[end])) {
                visited.Add(s[end]);
                end++;
                maxLength = Math.Max(maxLength, end - start);
            } else {
                while (s[start] != s[end]) {
                    visited.Remove(s[start]);
                    start++;
                }
                start++; // Move past the duplicate character
                end++;
            }
        }
        
        return maxLength;
    }
}