public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> seq = new();
        var max = 0;

        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return 1;

        for (int i = 0; i < nums.Length; i++) {
            if (!seq.ContainsKey(i))
                seq[i] = 1;
            else
                break;

            for (int j = 0; j < nums.Length; j++) {
                if (nums.Contains(nums[i] + j + 1)) {
                    seq[i] = seq[i] + 1;
                    if (seq[i] > max)
                        max = seq[i];

                } else
                    break;
            }
        }

        return max == 0 ? 1 : max;
    }
}
