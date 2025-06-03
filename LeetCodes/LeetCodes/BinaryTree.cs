namespace LeetCodes;

public class BinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }
        
        return dfs(root, 0);
    }
    
    private int dfs(TreeNode root, int depth)
    {
        if (root is null)
        {
            return depth;
        }
        
        var left = dfs(root.left, depth + 1);
        var right = dfs(root.right, depth + 1);
        return int.Max(left, right);
    }
    
    public int MinimumDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }
        
        return dfsMinimum(root, 1);
    }
    
    private int dfsMinimum(TreeNode root, int depth)
    {
        if (root is null)
        {
            return int.MaxValue;
        }

        if (root.left is null && root.right is null)
        {
            return depth;
        }
        
        return int.Min(dfsMinimum(root.left, depth + 1), dfsMinimum(root.right, depth + 1));
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}