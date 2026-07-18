public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
      var y = strs
    .GroupBy(s => new string(s.Order().ToArray()))
    .Select(g => g.ToList())
    .ToList();
    return y;
    }
}
