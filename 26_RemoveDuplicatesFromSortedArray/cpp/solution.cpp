class Solution {
public:
    int removeDuplicates(vector<int>& nums) {

        sort(nums.begin(), nums.end());
        nums.erase(unique(nums.begin(), nums.end()), nums.end());
        return nums.size();
    }
};

// Time complexity: O(n)
// Space complexity: O(1)

// std::unique remoces all but the first element from every consecutive group of elements in the range [first, last)
// return value: an iterator to the element that follows the last element not removed

// https://stackoverflow.com/questions/1041620/whats-the-most-efficient-way-to-erase-duplicates-and-sort-a-vector
// http://www.cplusplus.com/reference/algorithm/unique/
// http://www.cplusplus.com/reference/vector/vector/erase/
