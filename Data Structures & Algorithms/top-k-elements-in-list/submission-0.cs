public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        foreach (int num in nums) {
            if (!frequency.ContainsKey(num))
                frequency[num] = 0;

            frequency[num] = frequency[num] + 1;
        }

        var freqOrdered = frequency.OrderByDescending(x => x.Value).ToList();

        List<int> result3 = new();
        for (int i = 0; i < k; i++) {
            result3.Add(freqOrdered[i].Key);
        }

        return result3.ToArray();
    }
}
