public class Solution {
    public bool IsIsomorphic(string s, string t) {
       if (s.Length != t.Length) return false;

        Dictionary<char, char> sToTMap = new Dictionary<char, char>();
        Dictionary<char, char> tToSMap = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            char sChar = s[i];
            char tChar = t[i];

            if (sToTMap.ContainsKey(sChar)) {
                if (sToTMap[sChar] != tChar) {
                    return false;
                }
            } else {
                sToTMap[sChar] = tChar;
            }

            if (tToSMap.ContainsKey(tChar)) {
                if (tToSMap[tChar] != sChar) {
                    return false;
                }
            } else {
                tToSMap[tChar] = sChar;
            }
        }

        return true;
    }
}