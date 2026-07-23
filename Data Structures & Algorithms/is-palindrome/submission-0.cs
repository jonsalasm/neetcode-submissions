public class Solution {
    public bool IsPalindrome(string s) {
        var sArray = s.ToLower().ToCharArray();
        var sRev = sArray.Reverse().ToArray();
        List<char> normS = new();
        List<char> normRev = new();

        for (int i = 0; i < s.Length; i++) {
            if (Char.IsLetterOrDigit(sArray[i]))
                normS.Add(sArray[i]);

            if (Char.IsLetterOrDigit(sRev[i]))
                normRev.Add(sRev[i]);
        }

        for (int i = 0; i < normS.Count; i++) {
            if (normS[i] != normRev[i])
                return false;
        }

        return true;
    }
}
