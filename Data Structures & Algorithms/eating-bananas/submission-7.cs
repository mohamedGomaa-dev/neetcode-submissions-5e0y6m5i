public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int r = piles.Max();
        int l = 1;
        int result =r;
        while (l <= r) {
            int k = l + (r - l) / 2;
            long totalHours = 0;
            foreach(var pile in piles) {
                totalHours += (int)Math.Ceiling((double)pile / k);
            }
            if (totalHours > h) {
                l = k + 1;
            } else {
                r = k - 1;
                result = k;
            }
        }
        return result;
    }
}
