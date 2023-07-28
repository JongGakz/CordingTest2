using System;

public class Solution {
     public int[,] solution(int[] num_list, int n)
            {
                int[,] answer = new int[num_list.Length / n ,n];

                int a = 0;
                int b = 0;
                for (int i = 0; i < num_list.Length; i++)
                {
                    answer[a, b++] = num_list[i];
                    if (b == n)
                    {
                        a++;
                        b = 0;
                    }
                }

                return answer;
            }
}