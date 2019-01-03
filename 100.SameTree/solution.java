package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Stack;

public class Main {

    public static void main(String[] args) {

        TreeNode node1 = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);

        node1.left = node2;
        node1.right = node3;

        node2.left = node2.right = null;
        node3.left = node3.right = null;

        List<TreeNode> list = traverseTree(node1);
        for (TreeNode node : list) {
            if (node == null) System.out.println("null");
            else
                System.out.println(node.val);
        }


    }

    public boolean isSameTree(TreeNode p, TreeNode q) {
        List<TreeNode> nodesP = traverseTree(p);
        List<TreeNode> nodesQ = traverseTree(q);
        if (nodesP.size() == nodesQ.size()) {
            for (int i = 0; i < nodesP.size(); i++) {
                if (nodesP.get(i) != null && nodesQ.get(i) != null) {
                    if (nodesP.get(i).val != nodesQ.get(i).val) return false;
                } else {
                    if (nodesP.get(i) == nodesQ.get(i)) {
                    } else {
                        return false;
                    }
                }

            }
            return true;
        }

        return false;
    }

    private static List<TreeNode> traverseTree(TreeNode node) {
        List<TreeNode> list = new ArrayList<>();
        Stack<TreeNode> stack = new Stack<>();
        while (stack.empty() == false || node != null) {
            while (node != null) {
                list.add(node);
                stack.push(node);
                node = node.left;
            }
            list.add(null);
            if (stack.empty() == false) {

                node = stack.peek();
                stack.pop();
                node = node.right;
            }
        }
        return list;
    }


}
