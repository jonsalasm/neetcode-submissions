public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var word1 = s.ToCharArray();
        var word2 = t.ToCharArray();
        
        Array.Sort(word1);
        Array.Sort(word2);

        for (int i = 0; i < word1.Length; i++) {
            if (word1[i] != word2[i])
                return false;
        }

        return true;
    } 
}