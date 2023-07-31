using System;

public class Solution {
        public int solution(int n)
            {
                int answer = 1;
                int fac = 1;
                while (true)
                {
                    answer++;
                    fac *= answer;
                    if (n < fac)
                    {
                        break;
                    }
                    
                }

                return answer-1;
            }

}