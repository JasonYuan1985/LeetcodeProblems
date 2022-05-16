namespace LeetcodeProblems.Trees
{
    public class Problem2MaximunDepthOfBinaryTree
    {
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

        public int MaxDepth(TreeNode root)
        {
            TreeNode returnNode = root;
            //recursion
            if (returnNode == null)
            {
                return 0;
            }
            else
            {
                var leftMaxDepth = this.MaxDepth(returnNode.left);
                var rightMaxDepth = this.MaxDepth(returnNode.right);
                return (leftMaxDepth > rightMaxDepth ? leftMaxDepth : rightMaxDepth) + 1;
            }
        }
    }
}
