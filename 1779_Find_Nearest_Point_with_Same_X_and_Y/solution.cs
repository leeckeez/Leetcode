/*
You are given two integers, x and y, which represent your current location on a Cartesian grid: (x, y). 
You are also given an array points where each points[i] = [ai, bi] represents that a point exists at (ai, bi). 
A point is valid if it shares the same x-coordinate or the same y-coordinate as your location.

Return the index (0-indexed) of the valid point with the smallest Manhattan distance from your current location. 
If there are multiple, return the valid point with the smallest index. If there are no valid points, return -1.

The Manhattan distance between two points (x1, y1) and (x2, y2) is abs(x1 - x2) + abs(y1 - y2).
*/


public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        bool isValid = false;
        int minDis = Int32.MaxValue;
        int index = Int32.MaxValue;
        for(int i = 0; i < points.Length; i++)
        {
            if (points[i].First() == x || points[i].Last() == y)
            {
                isValid= true;
                int distance = Math.Abs(points[i].First() - x) + Math.Abs(points[i].Last() - y);
                if(distance < minDis)
                {
                    minDis = distance;
                    index = i;
                }     
            }
        }
        if(isValid)
            return index;
        else
            return -1;
    }
}