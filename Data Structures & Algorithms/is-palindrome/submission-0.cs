public class Solution {
    public bool IsPalindrome(string s) {
        string wordCleaned = "";
s = s.ToLower().Trim();
foreach (char ch in s)
{
    if (char.IsLetter(ch) || char.IsDigit(ch))
    {
        wordCleaned += ch;
    } else
    {
        continue;
    }
}
var start = 0;
var end = wordCleaned.Length - 1;
while (start <= end)
{
    if (wordCleaned[start] == wordCleaned[end])
    {
        start++;
        end--;
    }
    else
    {
        return false;
    }
}

return true;
    }
}
