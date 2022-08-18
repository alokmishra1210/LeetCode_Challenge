class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        
        if len(s)!=len(t):
            return False
        
        sort_s=sorted(s)
        sort_t=sorted(t)
        sort_st="".join(sort_s)
        sort_ts="".join(sort_t)
        if sort_st==sort_ts:
            return True
        else:
            return False
       