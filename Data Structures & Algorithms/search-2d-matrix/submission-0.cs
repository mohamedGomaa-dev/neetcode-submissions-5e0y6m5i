public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] <= target && matrix[i][matrix[i].Length - 1] >= target)
            {
                return _binarySearch(matrix[i], target);
            } else
            {
                continue;
            }
        }
        return false;
    }

    private bool _binarySearch(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;

        while (l <=r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] == target)
            {
                return true;
            } else if (arr[m] < target)
            {
                l = m + 1;
            } else
            {
                r = m - 1;
            }
        }
        return false;
    }
}
