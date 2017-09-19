#include <iostream>
#include<algorithm>
#include <unordered_map>
using namespace std;
class Solution
{
public :
    vector<int> twoSum(vector<int>& nums,int target)
    {
        unordered_map<int, int> m;
        vector<int> res;
        for (int i = 0; i < nums.size(); ++i)
        {
            m[nums[i]] = i;
        }
        for (int i = 0; i < nums.size(); ++i)
        {
            int t = target - nums[i];
            if (m.count(t) && m[t] != i)
            {
                res.push_back(i);
                res.push_back(m[t]);
                break;
            }
        }
        return res;
    }
};
int main()
{
    vector<int> a= {1,2,3,7,22,11};
    Solution su;
    vector<int> b=  su.twoSum(a,24);
    for(auto i: b)
        std::cout<<i<<" ";

    return 0;
}
