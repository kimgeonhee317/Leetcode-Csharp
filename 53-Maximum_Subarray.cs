public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int[] local_maximum = new int[nums.Length];
        int global_maximum;

        global_maximum = nums[0];
        local_maximum[0] = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != 0)
            {
                local_maximum[i] = local_maximum[i - 1] + nums[i];
            }

            if (local_maximum[i] > global_maximum)
            {
                global_maximum = local_maximum[i];
            }

            if (local_maximum[i] < 0)
            {
                local_maximum[i] = 0;
            }
        }

        return global_maximum;
    }

}
