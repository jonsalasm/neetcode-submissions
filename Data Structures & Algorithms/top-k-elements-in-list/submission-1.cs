public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(g => g)
        .Select(u => new { Value = u.Key, Count = u.Count() })
        .OrderByDescending(j => j.Count)
        .Take(k)
        .Select(v => v.Value)
        .ToArray();

    }
}
