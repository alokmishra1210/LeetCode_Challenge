public class Solution {
    StringBuilder result = new StringBuilder();
    public int KthGrammar(int n, int k) {
       return recursion(n,k);
             
    }
    public int recursion(int n, int k){
        if(n==1) return 0;

        int totalElements = (int)Math.Pow(2, n-1);
        int halfElements = totalElements/2;

        if(k>halfElements){
            return 1- recursion(n, k-halfElements);
        }

        return recursion(n-1,k);
    }
}