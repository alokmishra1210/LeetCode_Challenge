class Solution:
    def fizzBuzz(self, n: int) -> List[str]:
        
        ls=[]
        m=n+1
        for i in range(m):
            if i>0:
                if i%5==0 and i%3==0:
                    ls.append("FizzBuzz")
                elif i%3==0:
                    ls.append("Fizz")
                elif i%5==0:
                    ls.append("Buzz")
                else:
                    ls.append(str(i))
        return ls
            
        
        