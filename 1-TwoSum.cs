public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) {
            int c = target - numbers[i];

            if (map.ContainsKey(complement)) {
                return new int[] { map[c], i };
            }
            if (!map.ContainsKey(nums[i])) {
                map[nums[i]] = i;
            }
        }

        return new int[0];
    }
}
