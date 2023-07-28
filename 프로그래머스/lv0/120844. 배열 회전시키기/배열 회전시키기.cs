using System;

public class Solution {
 public int[] solution(int[] numbers, string direction)
            {
                int[] answer = new int[numbers.Length];


                if (direction.Equals("left"))
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        answer[i - 1] = numbers[i];
                    }

                    answer[answer.Length - 1] = numbers[0];
                }
                else
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        answer[i + 1] = numbers[i];
                    }
                    answer[0] = numbers[numbers.Length - 1];
                }

                return answer;
            }
}