public class Solution {
    public bool IsPalindrome(string s) {
        var sArray = s.ToLower().ToCharArray();
        List<char> normS = new();

        for (int i = 0; i < s.Length; i++) {
            if (Char.IsLetterOrDigit(sArray[i]))
                normS.Add(sArray[i]);
        }

        for (int i = 0; i < normS.Count; i++) {
            if (normS[i] != normS[normS.Count - i - 1])
                return false;
        }

        return true;
    }
}
