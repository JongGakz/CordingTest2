using System;

public class Solution {
    public int solution(int i, int j, int k)
        {
            int answer = 0;

            for (int z = i; z <= j; z++)
            {
                int a = z;
                while (a != 0)
                {
                    if (a % 10 == k)
                    {
                        answer++;
                    }
                    a /= 10;
                }
            }
            return answer;
        }
}