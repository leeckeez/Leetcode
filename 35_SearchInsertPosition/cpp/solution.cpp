class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int i = 0, j, result;
        for(j = 0; j < nums.size(); j++)
        {
            if(nums[j] == target)
                result = j;
            else if(nums[j] < target)
                result = ++i;
            else
                result = i;
        }
        return result;
    }
};
