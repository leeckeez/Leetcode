// Given an integer array sorted in non-decreasing order
// there is exactly one integer in the array that occurs more than 25% of the time, return that integer.
/*
Example 1:

Input: arr = [1,2,2,6,6,6,6,7,10]
Output: 6
Example 2:

Input: arr = [1,1]
Output: 1
*/



public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        Dictionary<int, int> p = new Dictionary<int, int>();
        foreach (var n in arr)
        {
            if (p.ContainsKey(n))
            {
                p[n]++;
            }
            else 
            {
                p.Add(n, 1);
            }
        }
        foreach (var n in p.Keys) 
        {
            if (p[n] > arr.Length/4)
                return n;
        }
        return 0;

    }
}
