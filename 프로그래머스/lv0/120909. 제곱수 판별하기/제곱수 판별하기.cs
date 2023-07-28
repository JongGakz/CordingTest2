using System;

public class Solution {
   public int solution(int n)
            {
                int answer = 0;
                if (Math.Sqrt(n) % 1 == 0)
                    return 1;
                else
                    return 2;
            }
}