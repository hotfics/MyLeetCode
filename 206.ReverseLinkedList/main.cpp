#include <iostream>

using namespace std;
struct ListNode
{
    int val;
    ListNode *next;
    ListNode(int x) : val(x), next(NULL) {}
};
class Solution
{
public :
    ListNode* reverseList(ListNode* head)
    {
        if((head==NULL)||(head->next==NULL)) return head;
        ListNode*    p=head;
        ListNode*   q=head->next;
        ListNode*  r;
        head->next=NULL;
        while(q)
        {
			//q->next信息将要丢失,必须进行保存
            r=q->next;
            q->next=p;
            p=q;
            q=r;

        }
        return p;
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
    ListNode* head=&node1;
    su.reverseList(head);

    for(ListNode* cur=&node4; cur; cur=cur->next)
    {
        std::cout<<cur->val<< " ";

    }
    return 0;
}
