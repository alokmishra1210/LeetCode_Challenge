public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answer = new int[temperatures.Length];
        Stack<int> indexes = new Stack<int>(); 
        for(int i=0; i<temperatures.Length; i++ ){
            while (indexes.Count > 0 && temperatures[i] > temperatures[indexes.Peek()]) {
                int prevIndex = indexes.Pop();
                answer[prevIndex] = i - prevIndex;
            }
            indexes.Push(i);
        }
        return answer;
    }
}