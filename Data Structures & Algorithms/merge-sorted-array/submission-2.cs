public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // allocate nums1 one in left arr
        // allocate nums 2 in right arr
        // have index l = 0 for left, and r = 0 for right
        // have index k = 0 => the pointer for the main arr
        // while l < lenght of left and r < length of right
        // if left[l] <= right[r] => nums1[k] = left[l++]
        // else num1[k] = right[r++]
        // k++
        // after that we loop through the rest of left and right arr
        // to make sure to include the rest of the elements
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int nonZeroIndex = nums1.Length - 1;
        
        for (int i = 0; i < m; i++) {
                left.Add(nums1[i]);
            
        }
        for (int i = 0; i < n; i++) {
            right.Add(nums2[i]);
        }

        int l = 0;
        int r = 0;
        int k = 0;

        while (l < left.Count && r < right.Count) {
            if (left[l] <= right[r]) {
                nums1[k] = left[l++];
            } else {
                nums1[k] = right[r++];
            }
            k++;
        }

        while (l < left.Count) {
            nums1[k++] = left[l++];
        }
        while (r < right.Count) {
            nums1[k++] = right[r++];
        }
    }
}