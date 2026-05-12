public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach (int ast in asteroids) {
            bool destroyed = false;
            
            // Only collide if the current is negative and the top of stack is positive
            while (stack.Count > 0 && ast < 0 && stack.Peek() > 0) {
                if (stack.Peek() < Math.Abs(ast)) {
                    stack.Pop(); // Positive asteroid destroyed, keep checking
                    continue;
                } else if (stack.Peek() == Math.Abs(ast)) {
                    stack.Pop(); // Both destroyed
                }
                destroyed = true; // Current negative destroyed (or both)
                break;
            }

            if (!destroyed) {
                stack.Push(ast);
            }
        }

        int[] result = stack.ToArray();
        Array.Reverse(result); // Stack is LIFO, so we need to reverse it
        return result;
    }
}
