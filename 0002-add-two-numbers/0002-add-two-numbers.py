# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    
    def addTwoNumbers(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """  
        str_l1="";
        str_l2=""
        current_l1=l1
        current_l2=l2
        while current_l1 is not None:
            str_l1=str_l1+str(current_l1.val)
            current_l1=current_l1.next        
        while current_l2 is not None:
            str_l2=str_l2+str(current_l2.val)
            current_l2=current_l2.next
        str_l1 = str_l1[::-1]
        str_l2 = str_l2[::-1]
        l1=int(str_l1)
        l2=int(str_l2)
        l3=l1+l2
        l3=str(l3)
        wrd=list(l3)
        ln=len(wrd)  
        newnode=ListNode(wrd[0])
        if(ln>1):  
            for i in range(1, ln):
                newnode=ListNode(wrd[i], newnode)
        return newnode
        
  
    
               
        