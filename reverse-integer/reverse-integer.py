class Solution:
    def reverse(self, x: int) -> int:   
        reversed=0
        remainder=0
        flg=0
        if x<0:
            flg=1
            x=x*(-1)
        while x>0:            
            remainder=x%10
            x=x//10
            reversed=reversed*10+remainder
        if reversed>(pow(2,31)-1):
            return 0
        if flg==1:
            reversed=reversed*(-1)
        return reversed