public class Solution {
    public int[] ReplaceElements(int[] arr) {
        // loop through arr
        // get max element after current index
        // equal current index with max element

        for (int i = 0;i < arr.Length; i++) {
            var max = GetMaxElement(i, arr);
            arr[i] = max;
        }

        return arr;
    }

    public int GetMaxElement(int index, int[] arr) {
        if (index >= arr.Length - 1) return -1;
        int max = 0;
        for (int i = index + 1;i < arr.Length; i++ ) {
            if (arr[i] > max) max = arr[i];
        }

        return max;
    }
}