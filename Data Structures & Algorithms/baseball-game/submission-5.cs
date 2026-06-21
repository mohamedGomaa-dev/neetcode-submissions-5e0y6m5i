public class Solution
{
    public int CalPoints(string[] operations)
    {
        Stack<int> result = new Stack<int>();
        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int number))
            {
                result.Push(number);
            } else
            {
                switch (operations[i])
                {
                    case "+":
                    int top1 = result.Pop();
                    int top2 = result.Peek();
                    result.Push(top1);
                    result.Push(top1 + top2);
                    continue;
                    case "D":
                    result.Push(result.Peek() * 2);
                    continue;
                    case "C":
                    result.Pop();
                    continue;
                    default: continue;
                }
            }
        }

        return result.Count == 0 ? 0: result.Sum();
    }
}