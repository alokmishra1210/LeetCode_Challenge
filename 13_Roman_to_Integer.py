#13. Roman to Integer

class Solution:
    def romanToInt(self, s: str) -> int:
        roman={
            'I':1,
            'IV':4,
            'V':5,
            'IX':9,
            'X':10,
            'XL':40,
            'L':50,
            'XC':90,
            'C':100,
            'CD':400,
            'D':500,
            'CM':900,
            'M':1000
        }
        ttl=0
        for i in range(len(s)):
            if (s[i]=='V' or s[i]=='X' or s[i]=='L' or s[i]=='C' or s[i]=='D' or s[i]=='M') and i!=0:
                if roman.__contains__(s[i-1]+s[i]):
                    ttl=ttl-roman[s[i-1]]
                    ttl=ttl+roman[s[i-1]+s[i]]
                else:
                     ttl=ttl+roman[s[i]]
            else:
                print(s[i])
                ttl=ttl+roman[s[i]]
        return ttl
