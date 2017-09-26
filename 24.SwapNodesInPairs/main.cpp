#include <iostream>

using namespace std;
struct ListNode
{
    int val;
    ListNode *next;
    ListNode(int x) : val(x), next(nullptr) {}
};
class Solution
{
public :
    ListNode* swapPairs(ListNode* head)
    {
        if ( head==nullptr ||head->next==nullptr) return head;

        ListNode*  t=head->next;
        head->next=swapPairs(head->next->next);
        t->next=head;
        return t;

    }

};
int main()
{
    ListNode node1(1);
    ListNode node2(2);
    ListNode node3(3);
    ListNode node4(4);
    node1.next=&node2;
    node2.next=&node3;
    node3.next=&node4;

    Solution su;

    ListNode* _node=  su.swapPairs(&node1);

    for(ListNode* cur=_node; cur; cur=cur->next)
    {
        std::cout<<cur->val<< " ";

    }
    return 0;
}
