public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var heap = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            heap.Enqueue(i, nums[i]);
        }
        while (heap.Count > k) {
            heap.Dequeue();
        }
        return nums[heap.Peek()];
    }
}
