public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        // we create an array for result
        // we loop through tempratures
        // we do a nested loop to loop through the next elements to the current element
        // we initialize the count to one in the nested loop
        // if the element in nested loop is less than or equal to current we increase count 
        // else we make result[current] = count
        // after loop finishes the last element of resutl should be zero

        int[] result = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            int count = 0;

            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] <=  temperatures[i])
                {
                    count++;
                } else
                {
                    count++;
                    result[i] = count;
                    break; 
                }
            }
        }
        result[temperatures.Length - 1] = 0;
        return result;
    }
}
