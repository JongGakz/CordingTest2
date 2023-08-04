using System;

public class Solution {
   public int solution(int a, int b)
        {
            int answer = 0;
            int x = 0;
            for (int i = 1; i <= Math.Max(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    x = i;
                }
            }

            b /= x;

            while (b % 2 == 0)
            {
                b /= 2;
            }

            if (b == 1)
            {
                return 1;
            }
            else
            {
                while (b % 5 == 0)
                {
                    b /= 5;
                }

                if (b == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                
            }

        }
}