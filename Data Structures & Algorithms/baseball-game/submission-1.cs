public class Solution
{
    public int CalPoints(string[] operations)
    {
        // create a list for the result
        // loop through operations
        // if element is: 
        // int push to list (stack)
        // + Add(result[result.Length - 1] + result[Length -2])
        // D Add(result[result.Length - 1] * 2);
        // C RemoveAt(result.Length -1)
        // return result.Sum();

        List<int> points = new List<int>();
        
        for (int i =0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int number))
            {
                points.Add(number);
            } else
            {
                switch (operations[i])
                {
                    case "+":
                        points.Add(points[points.Count - 1] + points[points.Count - 2]);
                        continue;
                    case "D":
                        points.Add(points[points.Count - 1] * 2);
                        continue;
                    case "C":
                        points.RemoveAt(points.Count - 1);
                        continue;

                    default:
                        continue;
                }
            }
        }

        return points.Count() == 0? 0 : points.Sum();
    }
}