public class Solution {
    public void ReverseString(char[] s) {
        // I will create two pointers one at first letter one at last
        // swap the two and then increase one and decrease the other
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}