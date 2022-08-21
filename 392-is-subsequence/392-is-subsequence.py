class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        k=0
        ln=len(s)
        if ln==0:
            return True
        for i in range(len(s)):
            while k>=0 and k<len(t):
                if s[i]==t[k]:
                    ln=ln-1
                    if ln==0:
                        return True
                    k=k+1
                    break
                else:
                    k=k+1
     
