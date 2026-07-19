public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> group = new();

        for (int i = 0; i < strs.Length; i++) {
            var ordered2 = new String(strs[i].Order().ToArray());

            if (!group.ContainsKey(ordered2))
                group[ordered2] = [];

            group[ordered2].Add(strs[i]);
        }

        return group.Values.ToList();
    }
}
