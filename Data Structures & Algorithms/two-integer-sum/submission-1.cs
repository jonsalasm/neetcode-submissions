public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> unico = new(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            int value;
            if (unico.TryGetValue(target - nums[i], out value))
               return new int[] {value, i}; 
            
            unico[nums[i]] = i;            

        }
        return new int[] {0,0};
    }
}
