public class MyQueue {
    private Stack<int> stack; // the stack that will have the result
    private List<int> temp; // stack for alternating data to fit the queue
    public MyQueue() {
        // we initialize our fields
        stack = new Stack<int>();
        temp = new List<int>();
    }
    private void ReverseStack() {
        while (stack.Count >0) {
            temp.Add(stack.Pop());
        }
        for (int i = 0; i < temp.Count;i++) {
            stack.Push(temp[i]);
        }
        temp.Clear();
    }
    public void Push(int x) {
        // enquee will be pushing to the end of the queue
        // [1] => [1, 2] => [1, 2, 3]
            ReverseStack();

        // I will use the temp to reverse stack
        stack.Push(x);
        
            ReverseStack();
        
    }
    
    public int Pop() {
        return stack.Pop();
    }
    
    public int Peek() {
        return stack.Peek();
    }
    
    public bool Empty() {
        // check if stack count is zero
        return stack.Count <=0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */