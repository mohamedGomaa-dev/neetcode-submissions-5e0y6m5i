public class Solution
{

    
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] word = strs[i].ToCharArray();
            Array.Sort(word);
            string wordToString = new string(word);
            if (!map.ContainsKey(wordToString))
            {
                map[wordToString] = new List<string> { strs[i] };
            } else
            {
                map[wordToString].Add(strs[i]);
            }
        }

        List<List<string>> result = new List<List<string>>();
        foreach (var kvp in map)
        {
            result.Add(kvp.Value); 
        }

        return result;
    }
}