class Solution:
    def isPalindrome(self, x: int) -> bool:
        x_str=str(x)
        x_str_inv=x_str[::-1]
        if x_str==x_str_inv:
            return True
        else:
            return False