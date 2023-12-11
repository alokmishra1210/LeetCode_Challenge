public class Solution {
    public int MaxArea(int[] height) {
        int start=0, end=height.Length-1;
        int maxarea=0;

        while(start<end){
            if(height[start]<height[end]){
               maxarea = Math.Max(maxarea, height[start]*(end-start));
                start++;
            }else{
               
                maxarea = Math.Max(maxarea, height[end]*(end-start));
                 end--;
            }
            
        }

        return maxarea;


    }
}