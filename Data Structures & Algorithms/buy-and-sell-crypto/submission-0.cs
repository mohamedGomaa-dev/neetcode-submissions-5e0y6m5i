public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int maxProfit = 0;
        for (int sell = 0; sell < prices.Length; sell++) {
            if (prices[sell] < prices[buy]) {
                buy = sell;
            }
            int currentProfit = prices[sell] - prices[buy];
            if (currentProfit > maxProfit) 
                maxProfit = currentProfit;
            
            
        }
        return maxProfit;
    }
}
