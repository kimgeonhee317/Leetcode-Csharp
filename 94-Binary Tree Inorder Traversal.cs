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
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();
        traversal(list, root);

        //foreach (int item in list)
        //{
        //    console.writeline(item);
        //}


        return list;
    }

    public void traversal(List<int> list, TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        traversal(list, node.left);
        list.Add(node.val);
        traversal(list, node.right);
    }
}