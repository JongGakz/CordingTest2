using System;

public class Solution {
             public int solution(int[] numbers)
            {
              int max = int.MinValue;
                for (int i = 0; i < numbers.Length; i++)
                {

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i != j)
                        {
                            int sum = numbers[i] * numbers[j];
                            if (sum > max)
                            {
                                max = sum;
                            }
                        }
                    }
                }
                return max;
            }
}