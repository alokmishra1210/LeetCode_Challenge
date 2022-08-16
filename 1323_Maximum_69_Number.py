#1323. Maximum 69 Number

class Solution:
    def maximum69Number (self, num: int) -> int:
        num=str(num)
        j=0
        for i in range(len(num)):
            if int(num[i])!=9:
                if j==0:
                    num=num[:i] + "9" + num[i+1:]
                    j=j+1
        return int(num)
