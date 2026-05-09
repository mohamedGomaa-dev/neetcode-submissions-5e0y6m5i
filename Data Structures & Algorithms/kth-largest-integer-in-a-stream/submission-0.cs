public class KthLargest
{
    List<int> _heap;
    int _k;
    public KthLargest(int k, int[] nums)
    {
        _k = k;
        _heap = new List<int>();
        _heap.Add(0);
        foreach (var num in nums) {
            Add(num);
        }
    }

    public int Add(int val)
    {
        // add the value
        _heap.Add(val);
        // we want to maintain a max heap property so we heapify this value up

        // initialize i at index of the value in order to compare it with the parent
        int i = _heap.Count - 1;
        while (i > 1 && _heap[i] < _heap[i / 2])
        {
            int temp = _heap[i];
            _heap[i] = _heap[i / 2];
            _heap[i / 2] = temp;
            i = i / 2;
        }
        while (_heap.Count > _k + 1) {
            Pop();
        }
        return _heap[1];
    }
    public int Pop()
{
    if (_heap.Count == 1) return -1;
    if (_heap.Count == 2)
    {
        int res = _heap[_heap.Count - 1];
        _heap.Remove(_heap[_heap.Count - 1]);
        return res;
    }
    int result = _heap[1];
    _heap[1] = _heap[_heap.Count - 1];
    _heap.Remove(_heap[_heap.Count - 1]);
    int i = 1;

    while (i * 2 < _heap.Count)
    {
        if (i * 2 + 1 < _heap.Count &&
            _heap[i * 2 + 1] < _heap[i * 2] &&
            _heap[i * 2 + 1] < _heap[i])
        {
            int temp = _heap[i];
            _heap[i] = _heap[i * 2 + 1];
            _heap[i * 2 + 1] = temp;
            i = i * 2 + 1;
        } else if (_heap[i * 2] < _heap[i])
        {
            int temp = _heap[i];
            _heap[i] = _heap[i * 2 ];
            _heap[i * 2 ] = temp;
            i = i * 2 ;
        } else
        {
            break;
        }
    }
    return result;
}
}
