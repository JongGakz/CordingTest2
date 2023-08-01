using System;

public class Solution {
     public int solution(int[] array)
        {
            int answer = 0;

            foreach (int i in array)
            {
                int a = i;
                while (a != 0)
                {
                    if (a % 10 == 7)
                    {
                        answer++;
                    }
                    a /= 10;
                }
            }
            return answer;
        }
}