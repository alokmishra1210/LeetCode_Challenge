public class Solution {
    public int FirstUniqChar(string s) {
       HashSet<char> repeated = new HashSet<char>();
        HashSet<char> repeat = new HashSet<char>();
       foreach(char c in s){
           if(repeated.Contains(c)){
               repeat.Add(c);
           }else{
               repeated.Add(c);
           }
       }
        
        for(int i=0; i<s.Length; i++){
            if(!repeat.Contains(s[i])){
                return i;
            }
        }
        
        return -1;
    }
}