public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            result[i] = FindMax(arr, i);
        }
        result[arr.Length - 1] = -1;
        return result;
    }

    public int FindMax(int[] arr, int startingIndex)
    {
        int max = int.MinValue;
        for (int i = startingIndex + 1; i < arr.Length;i++)
        {
            if (arr[i] > max) max = arr[i];
        }

        return max;
    }
}