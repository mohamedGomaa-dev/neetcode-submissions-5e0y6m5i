public class Solution {
    public bool IsAnagram(string s, string t) {
        // if s.Length != t.Length return false
        // create a dictionary for counting frequency of each letter in either string
        // loop through the other string
        // if (freq.containskey(t[i])) freq[t[i]]-- and check if it is less than zero return false
        // if not return false
        // return true

        if (s.Length != t.Length) return false;
        Dictionary<char, int> freq = new Dictionary<char, int>();

        for (int i =0; i< s.Length; i++) {
            if (freq.ContainsKey(s[i])) {
                freq[s[i]]++;
            } else {
                freq[s[i]] = 1;
            }
        }
        for (int i = 0; i< t.Length; i++) {
            if (freq.ContainsKey(t[i])) {
                freq[t[i]]--;
                if (freq[t[i]] <0) {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
