public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> stonesList = stones.ToList();
        stonesList.Sort();
        while(stonesList.Count > 1) {
            int y = stonesList[stonesList.Count - 1];
            int x = stonesList[stonesList.Count - 2];
            stonesList.Remove(stonesList[stonesList.Count - 1]);
            stonesList.Remove(stonesList[stonesList.Count - 1]);
            if (y == x) {
                continue;
            } else {
                y = y - x;
                stonesList.Add(y);
                stonesList.Sort();
            }
        }
        return stonesList.Count == 0 ? 0 : stonesList[0];
    }

    
}
