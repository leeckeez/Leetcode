/*
You are given an integer array nums where the largest integer is unique.
Determine whether the largest element in the array is at least twice as much as every other number in the array. 
If it is, return the index of the largest element, or return -1 otherwise.

Example 1:

Input: nums = [3,6,1,0]
Output: 1
Explanation: 6 is the largest integer.
For every other number in the array x, 6 is at least twice as big as x.
The index of value 6 is 1, so we return 1.
Example 2:

Input: nums = [1,2,3,4]
Output: -1
Explanation: 4 is less than twice the value of 3, so we return -1.
*/


public class Solution {
    public int DominantIndex(int[] nums) {
        int largest = int.MinValue;
        int largestIndex = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int i in nums)
        {
            if(i > largest)
            {
                secondLargest = largest;
                largest = i;
                largestIndex = Array.IndexOf(nums, i);
            }
            else if(i > secondLargest)
            {
                secondLargest = i;
            }
        }

        if(largest >= secondLargest * 2)
        {
            return largestIndex;
        }
        else
            return -1;       
    }
}