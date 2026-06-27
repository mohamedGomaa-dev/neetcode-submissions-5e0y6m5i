public class NumArray {
    private int[] _nums;
    private List<int> _prefixSum = new List<int>();
    public NumArray(int[] nums) {
        _nums = nums;
        int total = 0;
        for (int i = 0; i < nums.Length; i++) {
            total += nums[i];
            _prefixSum.Add(total);
        }
    }
    
    public int SumRange(int left, int right) {
        int leftSum = left - 1 >= 0 ? _prefixSum[left - 1] : 0;
        int rightSum = _prefixSum[right];
        return (rightSum - leftSum);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */