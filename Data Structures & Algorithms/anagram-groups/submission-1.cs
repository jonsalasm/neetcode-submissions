public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new();
        Dictionary<string, string> ordered = new();

        foreach (var item in strs) {
            var charArray = item.ToCharArray();
            System.Array.Sort(charArray);
            ordered[item] = new String(charArray);
        }

      var y = strs
    .GroupBy(s => new string(s.Order().ToArray()))
    .Select(g => g.ToList())
    .ToList();
    return y;
    }
}
