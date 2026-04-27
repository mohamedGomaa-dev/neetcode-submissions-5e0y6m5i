public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        // create a queue for students
        // create a stack for sandwiches
        // enqueue students in queue and sands in stack
        // while queue.count > 0 
        // if (queue.front() == stack.peek()) queue.pop(); stack.pop();
        // else length++;
        // if length == queue.count return queue.count
        // after the loop return queue.count
        // length is for incrementing to prevent infinite loop
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        int studentsReturningCount = 0;
        for (int i = 0; i< students.Length; i++) {
            queue.Enqueue(students[i]);
            
        }
        for (int i = sandwiches.Length - 1; i >= 0; i--) {
            stack.Push(sandwiches[i]);
        }

        while (queue.Count >0) {
            if (studentsReturningCount == queue.Count + 1) {
                return queue.Count;
            }
            if (queue.Peek() == stack.Peek()) {
                queue.Dequeue();
                stack.Pop();
                studentsReturningCount = 0;
            } else {
                queue.Enqueue(queue.Dequeue());
                studentsReturningCount++;
            }
            
        }
        return queue.Count;
    }
}