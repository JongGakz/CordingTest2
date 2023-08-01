using System;

public class Solution {
 public int solution(int[] array, int n)
        {
            int answer = array[0];
            int abs = Math.Abs(array[0] - n);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - n) < abs)
                {
                    abs = Math.Abs(array[i] - n);
                    answer = array[i];
                }
                 if (Math.Abs(array[i] - n) == abs && array[i] < answer)
                {
                    answer = array[i];
                }
            }

            return answer;
        }
}