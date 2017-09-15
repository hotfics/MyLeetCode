#include <iostream>
#include<algorithm>
/*

        1
       / \
      2   3
     /
    4
   / \
  5   6
*/

using namespace std;
struct TreeNode
{
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
};
class Solution
{
public :
    int  MaxTreeDepth(TreeNode* rootNode)
    {
        if(rootNode==nullptr) return 0;
        int depthLeft=MaxTreeDepth(rootNode->left)+1;
        int depthRight=MaxTreeDepth(rootNode->right)+1;
        int deepest=std::max(depthLeft,depthRight);
        return deepest;
    }

};
int main()
{
    TreeNode nodeRoot(1);

    TreeNode node2(2);
    TreeNode node3(3);
    TreeNode node4(4);
    TreeNode node5(5);
    TreeNode node6(6);
    nodeRoot.left=&node2;
    nodeRoot.right=&node3;
    node2.left=&node4;
    node4.left=&node5;
    node4.right=&node6;
    Solution su;
    int depth=su.MaxTreeDepth(&nodeRoot);
    std::cout<<depth<<endl;

    return 0;
}
