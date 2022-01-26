public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {

        int x = 0;

        foreach (string operation in operations)
        {
            if (operation == "--X" || operation == "X--")
            {
                x--;
            }
            else if (operation == "++X" || operation == "X++")
            {
                x++;
            }
        }

        return x;
    }
}