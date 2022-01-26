public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int left;
        int[] answer = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            left = target - nums[i];
            int index = Array.IndexOf(nums, left);

            if (i == index)
            {
                continue;
            }

            if (index != -1)
            {
                answer[0] = i;
                answer[1] = index;
                break;
            }
        }

        return answer;
    }
}