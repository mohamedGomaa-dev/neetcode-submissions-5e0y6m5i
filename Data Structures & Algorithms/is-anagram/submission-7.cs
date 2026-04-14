public class Solution
{
   public bool IsAnagram(string s, string t)
{
    // create an array of 26 letter (alphabet) initialized by zero for all items
    // loop through both arrays
    // first array incement the letter frequency
    // second one decrement it 
    // loop through the letters array and find items that doesn't equal zero

    int[] map = new int[26];
    for (int i = 0; i < s.Length; i++)
    {
        map[s[i] - 'a']++;
    }

    for (int i = 0; i < t.Length; i++)
    {
        map[t[i] - 'a']--;
    }

    foreach(var num in map) {
        if (num != 0) {
            return false;
        }
    }
    return true;
}

}
