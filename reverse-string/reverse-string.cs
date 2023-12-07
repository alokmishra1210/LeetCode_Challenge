public class Solution {
    public void ReverseString(char[] s) {
        int left =0;
        int right = s.Length-1;
        reverseString(left, right, s);
     
    }
    
    private void reverseString(int left, int right, char[] s){
        
        if(left>=right) return;
        
        // Swap the characters at the left and right indices
        char temp = s[left];
        s[left] = s[right];
        s[right] = temp;

        // Recursive call with updated indices
        reverseString(left + 1, right - 1, s);
    }
}