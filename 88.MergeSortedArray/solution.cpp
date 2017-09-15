#include <iostream>
#include<algorithm>
/*题目有点模糊,相同的如何处理,我理解为只保留nums1的*/
using namespace std;
class Solution
{
public :
    void merge(vector<int>& nums1, int m, vector<int>& nums2, int n)
    {
        std::vector<int> v_intersection;
        std::set_union(nums1.begin(),nums1.end(),nums2.begin(),nums2.end(),inserter(v_intersection, v_intersection.begin()));
        nums1.clear();
        nums1.assign(v_intersection.begin(),v_intersection.end());
    }
};
int main()
{
    vector<int> a= {9,14};
    vector<int> b = {11,12,13};
    Solution su;
    su.merge(a,a.capacity(),b,b.capacity());
    for(auto i: a)
        std::cout<<i<<" ";

    return 0;
}
