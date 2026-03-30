public class Solution {
    public bool IsAnagram(string s, string t) {
          SortedDictionary<char, int> sChars = new SortedDictionary<char, int>();
 SortedDictionary<char, int> tChars = new SortedDictionary<char, int>();

  foreach (var ch in s)
  {
      if (!sChars.ContainsKey(ch))
      {
          sChars[ch] = 1;
      } else
      {
          sChars[ch]++;

      }
  }

  foreach (var ch in t)
  {
      if (!tChars.ContainsKey(ch))
      {
          tChars[ch] = 1;
      }
      else
      {
          tChars[ch]++;

      }
  }
        if (sChars.Count != tChars.Count) return false;

  foreach (var kvp in  sChars)
  {
      if (!tChars.ContainsKey(kvp.Key))
      {
          return false;
      } else
      {
          if (tChars[kvp.Key] !=  kvp.Value)
          {
              return false;
          }
      }

  }
  

  return true;
    }
}
