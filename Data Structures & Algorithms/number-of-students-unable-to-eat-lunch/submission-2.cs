public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        // frequency count for sandwiches
        // loop through students
        // count[0]++ if student is willing to eat 0
        // count[1]++ if student is willing to eat 1
        Dictionary<int, int> freq = new Dictionary<int, int>();
        freq[0] = 0; freq[1] = 0;

        for (int i =0; i< students.Length; i++) {
            freq[students[i]]++;
        }
        int result = students.Length;
        for (int i = 0; i< sandwiches.Length; i++) {
            if (freq[sandwiches[i]] > 0) {
                freq[sandwiches[i]]--;
                result--;
            } else {
                break;
            }
        }
        return result;
    }
}