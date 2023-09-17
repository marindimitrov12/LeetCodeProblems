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
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int>arr=new List<int>();
        Inorder(root,arr);
        return arr;
        
            
    }
    public void Inorder(TreeNode root,List<int>arr){
        if(root==null){
            return;
        }
        Inorder(root.left,arr);
        arr.Add(root.val);
        Inorder(root.right,arr);
    }
}