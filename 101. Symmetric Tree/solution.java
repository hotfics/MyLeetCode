package com.company;
public class Main {
    public static void main(String[] args) {

    }
    public static boolean isSymmetric(TreeNode root) {
        if (root == null) return true;
        return isSymmetricTree(root.right, root.left);
    }
    private static boolean isSymmetricTree(TreeNode nodeL, TreeNode nodeR) {

        if (nodeL != null && nodeR != null) {
            return (nodeL.val == nodeR.val) && isSymmetricTree(nodeL.left, nodeR.right) && isSymmetricTree(nodeL.right, nodeR.left);
        } else if (nodeL == null && nodeR == null) {
            return true;
        } else {
            return false;
        }
    }
}










