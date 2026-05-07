public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        int i = 0;
        int j = 0;
        while (i < word1.Length && j < word2.Length) {
            result += word1[i++];
            result += word2[j++];
        }   
        while (i < word1.Length) {
            result += word1[i++];

        }
        while (j < word2.Length) {
            result += word2[j++];

        }
        return result;
    }
}