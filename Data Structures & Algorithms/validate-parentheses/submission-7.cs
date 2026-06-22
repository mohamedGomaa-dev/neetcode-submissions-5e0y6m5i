public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        for (int i = 0 ;i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            } else
            {
                if (stack.Count == 0) return false;
                if ((stack.Peek() == '(' && s[i] != ')') ||
                (stack.Peek() == '[' && s[i] != ']') ||
                (stack.Peek() == '{' && s[i] != '}'))
                {
                    return false;
                } else
                {
                    stack.Pop();
                }
                
            }
        }

        return stack.Count == 0;
    }
}
