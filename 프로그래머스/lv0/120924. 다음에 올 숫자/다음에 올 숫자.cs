using System;

public class Solution {
      public int solution(int[] common)
        {
            int answer = common[0];
            int a = common[1] - common[0];
            int b = common[2] - common[1];


            if (a == b)
            {
                for (int i = 0; i < common.Length; i++)
                {
                    answer += a;
                }
            }
            else if (a != b)
            {
                a = common[1] / common[0];
                for (int i = 0; i < common.Length; i++)
                {
                    answer *= a;
                }
            }
            else if (a != b && a == 1)
            {
                for (int i = 0; i < common.Length; i++)
                {
                    answer *= b;
                }
            }
          
            return answer;
        }
}