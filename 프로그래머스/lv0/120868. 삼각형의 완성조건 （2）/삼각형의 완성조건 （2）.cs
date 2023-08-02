using System;
using System.Linq;

public class Solution {
       public int solution(int[] sides)
        {
            int answer = 0;
            sides = sides.OrderBy(n => n).ToArray();
  
            for (int i = 1; i <= sides[0] + sides[1]; i++)
            {
                if (i <= sides[1] && i + sides[0] > sides[1])
                {
                    answer++;
                }
                else if (i >= sides[1] && sides[0] + sides[1] > i)
                {
                    answer++;
                }
            }

            return answer;
        }
}