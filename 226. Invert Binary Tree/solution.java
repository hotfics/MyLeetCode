package com.company;

public class Main {
    public static void main(String[] args) {

    }
    public static TreeNode invertTree(TreeNode root) {
        if (root == null) return null;
        invertExcute(root);
        invertTree(root.left);
        invertTree(root.right);
        return root;
    }
    private static void invertExcute(TreeNode node) {
        if (node == null) return;
        TreeNode temp = new TreeNode(1);
        temp.left = node.left;
        node.left = node.right;
        node.right = temp.left;
    }


}

