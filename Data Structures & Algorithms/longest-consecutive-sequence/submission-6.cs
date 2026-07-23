public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
    int best = 0;
    foreach (int x in set)
    {
        // solo empezar si x es el inicio de una racha
        if (set.Contains(x - 1))
            continue;
        int length = 1;
        while (set.Contains(x + length))
            length++;
        if (length > best)
            best = length;
    }
    return best;
    }
}
