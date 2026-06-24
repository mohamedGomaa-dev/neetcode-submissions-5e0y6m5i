public class Solution {
    public bool IsAnagram(string s, string t) {
        // check if the two strings are equal
        if (s.Length != t.Length) return false;

        // create a dictionary to mark the frequency of the letters in a string
        Dictionary<char, int> freq = new Dictionary<char, int>();
        for (int i=0; i<s.Length; i++)
        {
            if (!freq.ContainsKey(s[i]))
            {
                freq[s[i]]  =0;
            }
            freq[s[i]]++;
        }

        // loop through the other string
        for (int i = 0; i < t.Length; i++)
        {
            if (freq.ContainsKey(t[i]))
            {
                freq[t[i]]--;
                if (freq[t[i]] < 0) return false;
            } else
            {
                return false;
            }
        }
        return true;
    }
}
