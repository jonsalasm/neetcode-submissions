public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var product = 1;
        int[] output = new int[nums.Length];
        

        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (i != j)
                    product = nums[j] * product;
            }
            output[i] = product;
            product = 1;
        }

        return output;
    }
}
