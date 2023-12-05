public class MinStack {

    private Stack<int> mainStack;
    private Stack<int> minStack;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (mainStack.Peek() == minStack.Peek()) {
            minStack.Pop();
        }
        mainStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */