public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        Dictionary<char, int> tMap = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (!sMap.ContainsKey(c))
            {
                sMap[c] = 0;
            }
            sMap[c]++;
        }
        foreach (char c in t)
        {
            if (!tMap.ContainsKey(c))
            {
                tMap[c] = 0;
            }
            tMap[c]++;
        }

        foreach (var kvp in sMap)
        {
            if (!tMap.ContainsKey(kvp.Key))
            {
                return false;
            } else
            {
                if (tMap[kvp.Key] != kvp.Value) {
                    return false;
                }
            }
        }


        return true;
    }
}
