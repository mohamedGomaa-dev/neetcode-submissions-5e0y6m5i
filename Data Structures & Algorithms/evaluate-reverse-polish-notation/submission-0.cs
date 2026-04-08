public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        // when I face a number I will put it into the stack
        // when I face an operation I will evaluate the two numbers using this operation
        // I will put the result into the stack
        // I will continue until the tokens are done
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (int.TryParse(tokens[i], out int num))
            {
                stack.Push(num);
            } else
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                switch (tokens[i])
                {
                    case "+":
                        int result = num2 + num1;
                        stack.Push(result);
                        continue;
                    case "-":
                        result = num2 - num1;
                        stack.Push(result);
                        continue;
                    case "*":
                        result = num2 * num1;
                        stack.Push(result);
                        continue;
                    case "/":
                        result = num2 / num1;
                        stack.Push(result);
                        continue;
                    default:
                        continue;
                }
            }
        }

        return stack.Count > 0 ? stack.Pop() : 0;

    }
}
