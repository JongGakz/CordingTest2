using System;

public class Solution {
    public int solution(int n)
        {
           
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    n++;
                    
                }
            }

            return   n;
        }
}