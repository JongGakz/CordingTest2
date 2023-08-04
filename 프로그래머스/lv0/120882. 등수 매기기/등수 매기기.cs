using System;

public class Solution {
    public int[] solution(int[,] score)
        {
            int[] answer = new int[score.GetLength(0)];

            for (int i = 0; i < score.GetLength(0); i++)
            {
                double x = (((double)(score[i, 0])) + (double)(score[i, 1])) / 2;
                answer[i] = 1;
                for (int j = 0; j < score.GetLength(0); j++)
                {
                    double y = (((double)(score[j, 0])) + (double)(score[j, 1])) / 2;
                    if (x < y)
                    {
                        answer[i]++;
                    } 
                }
                
            }
            return answer;
        }
}