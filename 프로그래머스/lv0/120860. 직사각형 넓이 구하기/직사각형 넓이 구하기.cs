using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] dots)
        {
            int answer = 0;
            List<int> xList = new List<int>();
            List<int> yList = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                xList.Add(dots[i, 0]);
                yList.Add(dots[i, 1]);
            }
            return (xList.Max()- xList.Min()) * (yList.Max() - yList.Min());
        }
}