namespace LeetcodeProblems.Trees
{
    public class Problem1InvertBinaryTree
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

        public TreeNode InvertTree(TreeNode root)
        {
            TreeNode returnNode = root;
            //recursion
            if(returnNode == null)
            {
                return null;
            }
            else
            {
                TreeNode temp = returnNode.left;
                returnNode.left = returnNode.right;
                returnNode.right = temp;
                this.InvertTree(returnNode.left);
                this.InvertTree(returnNode.right);
                return returnNode;
            }
        }
    }
}
