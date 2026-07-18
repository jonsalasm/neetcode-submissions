public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new();
       foreach (var a in nums)
       {
        if (!map.Contains(a))
        map.Add(a);
        else
        return true;
       }
       return false;
    }
}