class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        start_index=0
        last_index=len(s)-1
        while last_index>start_index:
            s[start_index], s[last_index]=s[last_index], s[start_index]
            start_index=start_index+1
            last_index=last_index-1
            
        return s
        