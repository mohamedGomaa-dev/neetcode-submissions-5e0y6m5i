public class MyStack
{
    private Queue<int> _queue;
    private Queue<int> _temp;
    public MyStack()
    {
        _queue = new Queue<int>();
        _temp = new Queue<int>();
    }

    public void Push(int x)
    {

        // Move all elements from _queue to _temp
        // put the x in the front of the queue
        // return elements to the queue
        while (_queue.Count > 0)
        {
            _temp.Enqueue(_queue.Dequeue());
        }

        _queue.Enqueue(x);
        
        while (_temp.Count > 0)
        {
            _queue.Enqueue(_temp.Dequeue());
        }
    }

    public int Pop()
    {
        // dequeue the first element of the queue and return it
        if (_queue.Count <= 0)
        {
            return -1;
        }
        return _queue.Dequeue();
    }

    public int Top()
    {
        if (_queue.Count <= 0)
        {
            return -1;
        }
        return _queue.Peek();
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */