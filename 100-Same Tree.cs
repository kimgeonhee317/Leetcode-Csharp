/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {

        if (p == null && q == null) // both empty -> identical
        {
            return true;
        }
        else if (p == null || q == null) // one of them empty -> not identical
        {
            return false;
        }
        else if (p.val != q.val) // diffrent -> not identical
        {
            return false;
        }
        else //recursion of traversal
        {
            bool left = IsSameTree(p.left, q.left);
            bool right = IsSameTree(p.right, q.right);

            return left && right;
        }
    }
}