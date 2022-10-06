class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        carry=0
        mx_len=len(digits)-1
        temp_n=(int(digits[mx_len])+1)+carry
        carry=temp_n//10
        tmp=temp_n%10
        digits[mx_len]=tmp
        mx_len=mx_len-1    
        while carry!=0 and mx_len>=0:
            temp_n=int(digits[mx_len])+carry
            carry=temp_n//10
            tmp=temp_n%10
            digits[mx_len]=tmp
            mx_len=mx_len-1
        if carry==1:
            digits.insert(0,carry)        
        return digits
                
    