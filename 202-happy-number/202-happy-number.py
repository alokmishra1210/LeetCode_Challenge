class Solution:
    def isHappy(self, n: int) -> bool:
        visited=set()
        while n not in visited or n!=1:
            nm=str(n)
            y=0
            for i in range(len(nm)):
                y=y+(int(nm[i])*int(nm[i]))
            if y==1:
                return True
            elif y in visited:
                return False
            else:
                n=y
                visited.add(y)
        return False
        
            
        