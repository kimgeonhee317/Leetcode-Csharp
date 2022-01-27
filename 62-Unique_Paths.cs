public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] memo = new int[m, n];

        makeMemo(memo, m, n); //construct dp map

        return memo[m - 1, n - 1];
    }

    public void makeMemo(int[,] memo, int m, int n)
    {

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                {
                    memo[i, j] = 1;
                    continue;
                }
                memo[i, j] = memo[i - 1, j] + memo[i, j - 1];
            }
        }
    }
}