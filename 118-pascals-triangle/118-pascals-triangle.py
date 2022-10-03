class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        res=[[1], [1,1]]
        
        for i in range(2, numRows):
            last_val=res[-1]
            temp_res=[]
            temp_res.append(1)
            for j in range(len(last_val)-1):
                temp_res.append(last_val[j]+last_val[j+1])
            temp_res.append(1)
            res.append(temp_res)
        return res if numRows>1 else [res[0]]