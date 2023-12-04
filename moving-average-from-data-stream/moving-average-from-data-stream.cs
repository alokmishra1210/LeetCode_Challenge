public class MovingAverage {
    private Queue<int> queue;
    private int maxSize;
    private double sum;
   public MovingAverage(int size) {
        queue = new Queue<int>();
        maxSize = size;
        sum = 0;
    }
    
    public double Next(int val) {
        if (queue.Count == maxSize) {
            sum -= queue.Dequeue();
        }

        queue.Enqueue(val);
        sum += val;

        return sum / queue.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */